using DatabaseAnalysis.Models;

namespace DatabaseAnalysis
{
    internal class Program
    {
        #region Private Fields

        private static echinacareersContext db = new echinacareersContext();

        #endregion Private Fields

        #region Private Methods

        private static void Main(string[] args)
        {
            ///Job Posts
            //Functions.WordSummation(db.JobPost.Select(s => s.Content).ToList(), "JobPostWordCount.txt");

            //Employer Profiles
            //Functions.WordSummation(db.Employer.Select(s => s.Description).ToList(), "EmployerProfiles_WordCount.txt");

            ///Candidate Profile
            //Functions.WordSummation(db.Candidate.Select(s => s.Description).ToList(), "CandidateProfiles_WordCount.txt");

            ///Blog posts
            //Functions.WordSummation(db.BlogPost.Select(s => s.PostText).ToList(), "BlogPosts_WordCount.txt");

            // Recruiter Candidate Nationalities
            Functions.RecruiterCandidatesAnalysis(db.RecruiterCandidate, "RecruiterCandidate_Nationalities.txt");
        }

        #endregion Private Methods
    }
}