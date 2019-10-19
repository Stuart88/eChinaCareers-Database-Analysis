using DatabaseAnalysis.Models;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DatabaseAnalysis
{
    public static class Functions
    {
        #region Private Enums

        private enum CandidatePotential
        {
            NA,
            Pending,
            Potential,
            NotPotential,
            NotResponding,
            WillNotProcess,
            PendingOrPotential,
            Deferred
        }

        #endregion Private Enums

        #region Public Methods

        /// <summary>
        /// Groups candidates by nationality and analyses how many are deemed to have potential for recommending to jobs.
        /// Useful for understanding which countries to target for recruiting
        /// </summary>
        /// <param name="cands">RecruitCandidate database set</param>
        /// <param name="outputFileName">Must include .txt extension</param>
        public static void RecruiterCandidatesAnalysis(DbSet<RecruiterCandidate> cands, string outputFileName)
        {
            var query = (from r in cands
                         group r by r.Nationality into grp
                         select new
                         {
                             grp.Key,
                             count = grp.Count(),

                             potential = (from r in cands
                                          where r.Nationality == grp.Key
                                          && (
                                              r.Potential == (int)CandidatePotential.Potential
                                              || r.Potential == (int)CandidatePotential.Deferred
                                              )
                                          select r).Count(),

                             useful = ((double)(from r in cands
                                                where r.Nationality == grp.Key
                                                 && (
                                              r.Potential == (int)CandidatePotential.Potential
                                              || r.Potential == (int)CandidatePotential.Deferred
                                              )
                                                select r).Count() / grp.Count()) * 100
                         })
                         .OrderByDescending(x => x.count > 10)
                         .ThenByDescending(x => x.useful)
                         .ThenByDescending(x => x.count)
                         .Select(s => string.Format("{0,-6}   {1,-11}\t\t   {2,-12}\t   {3,6}%", s.count.ToString(), s.Key, s.potential, Math.Round(s.useful)))
                         .ToList();

            List<string> results = new List<string>();
            results.Add("Total  | Nationality\t\t |  Potential/\t  | Percent");
            results.Add("       |            \t\t |  Deferred  \t  |  Useful");
            results.Add("");

            results.AddRange(query);

            File.WriteAllLines(outputFileName, results);
        }

        /// <summary>
        /// Returns list of words ranked by how many times they appeared in a given set of HTML articles (blog posts, job posts, user profiles, etc)
        /// </summary>
        /// <param name="htmlContent">List of full HTML articles</param>
        /// <param name="outputFileName">Must include .txt extension</param>
        public static void WordSummation(List<string> htmlContent, string outputFileName)
        {
            int count = 0;

            HtmlDocument doc = new HtmlDocument();

            List<(string word, int count)> words = new List<(string word, int count)>();

            string entry_HTMLstripped = "";

            foreach (string jobContent in htmlContent)
            {
                doc.LoadHtml(jobContent);

                if (!doc.DocumentNode.HasChildNodes)
                    continue;

                try
                {
                    //Lazy... Use try/catch to avoid null reference errors...

                    foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
                    {
                        //Strip HTML tags from entry

                        entry_HTMLstripped += node.InnerText.Replace(@"\t", "");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! {0}", e.Message);
                }

                //Add or update count for each word

                foreach (string s in entry_HTMLstripped.Split(' '))
                {
                    if (words.Any(x => x.word == s))
                    {
                        var current = words.First(x => x.word == s);
                        int index = words.IndexOf(current);

                        words[index] = (current.word, ++current.count);
                    }
                    else
                    {
                        words.Add((s, 1));
                    }
                }

                entry_HTMLstripped = "";

                // Visually mark progress...

                count++;
                if (count % 20 == 0)
                {
                    Console.WriteLine("Processed {0} entries...", count);
                }
            }

            words = words.OrderBy(x => x.count).ToList();

            words.Sort((a, b) => b.count.CompareTo(a.count));

            // Write top 200 to text file.

            File.WriteAllLines(outputFileName, words.Take(200).Select(s => string.Format("{0}: {1}", s.count, s.word)).ToList());
        }

        #endregion Public Methods
    }
}