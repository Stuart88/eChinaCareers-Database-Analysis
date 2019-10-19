using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseAnalysis.Models
{
    public partial class echinacareersContext : DbContext
    {
        public echinacareersContext()
        {
        }

        public echinacareersContext(DbContextOptions<echinacareersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<ApplicationPipeline> ApplicationPipeline { get; set; }
        public virtual DbSet<ApplicationPipelineNote> ApplicationPipelineNote { get; set; }
        public virtual DbSet<BlogPost> BlogPost { get; set; }
        public virtual DbSet<BonusPercentage> BonusPercentage { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<CandidateCvnew> CandidateCvnew { get; set; }
        public virtual DbSet<CandidateFinancialTransaction> CandidateFinancialTransaction { get; set; }
        public virtual DbSet<CandidatePictureNew> CandidatePictureNew { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CompanyAttachment> CompanyAttachment { get; set; }
        public virtual DbSet<CompanyNote> CompanyNote { get; set; }
        public virtual DbSet<EchinaCareersFee> EchinaCareersFee { get; set; }
        public virtual DbSet<EmailOptOut> EmailOptOut { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<EmployerBusinessLicenseNew> EmployerBusinessLicenseNew { get; set; }
        public virtual DbSet<EmployerFinancialTransaction> EmployerFinancialTransaction { get; set; }
        public virtual DbSet<EmployerPictureNew> EmployerPictureNew { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventFileUploadNew> EventFileUploadNew { get; set; }
        public virtual DbSet<EventVisitor> EventVisitor { get; set; }
        public virtual DbSet<Industry> Industry { get; set; }
        public virtual DbSet<JobApplication> JobApplication { get; set; }
        public virtual DbSet<JobFunction> JobFunction { get; set; }
        public virtual DbSet<JobPost> JobPost { get; set; }
        public virtual DbSet<JobSearchData> JobSearchData { get; set; }
        public virtual DbSet<Lead> Lead { get; set; }
        public virtual DbSet<LeadNote> LeadNote { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Notarisation> Notarisation { get; set; }
        public virtual DbSet<NotarisationAttachment> NotarisationAttachment { get; set; }
        public virtual DbSet<NotarisationNote> NotarisationNote { get; set; }
        public virtual DbSet<RecruiterCandidate> RecruiterCandidate { get; set; }
        public virtual DbSet<RecruiterCandidateAttachment> RecruiterCandidateAttachment { get; set; }
        public virtual DbSet<RecruiterCandidateNote> RecruiterCandidateNote { get; set; }
        public virtual DbSet<RecruitingJobAttachment> RecruitingJobAttachment { get; set; }
        public virtual DbSet<RecruitingJobNote> RecruitingJobNote { get; set; }
        public virtual DbSet<RecruitingJobPost> RecruitingJobPost { get; set; }
        public virtual DbSet<RecruitmentFee> RecruitmentFee { get; set; }
        public virtual DbSet<Statistics> Statistics { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VisaProcess> VisaProcess { get; set; }
        public virtual DbSet<VisaProcessAttachment> VisaProcessAttachment { get; set; }
        public virtual DbSet<VisaProcessNote> VisaProcessNote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=STUART;Initial Catalog=echinacareers;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ECcAdminCandViews).HasColumnName("eCcAdminCandViews");

                entity.Property(e => e.LastActiveDate).HasColumnType("datetime");

                entity.Property(e => e.TrackKpi).HasColumnName("TrackKPI");
            });

            modelBuilder.Entity<ApplicationPipeline>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.CandidateName).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(512);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobTitle).HasMaxLength(512);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OfferAcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferGivenDate).HasColumnType("datetime");

                entity.Property(e => e.OfferRejectedDate).HasColumnType("datetime");

                entity.Property(e => e.PipelineTerminatedReason).HasMaxLength(512);

                entity.Property(e => e.PobationPassedDate).HasColumnType("datetime");

                entity.Property(e => e.RecruiterId).HasColumnName("RecruiterID");

                entity.Property(e => e.RecruiterName).HasMaxLength(255);

                entity.Property(e => e.WorkStartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApplicationPipelineNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.MainImageUrl)
                    .HasColumnName("MainImageURL")
                    .HasColumnType("text");

                entity.Property(e => e.Meta).HasMaxLength(255);

                entity.Property(e => e.Option)
                    .HasColumnName("option")
                    .HasMaxLength(20);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostTitle).HasMaxLength(300);

                entity.Property(e => e.PosterId).HasColumnName("PosterID");

                entity.Property(e => e.PosterName).HasMaxLength(100);
            });

            modelBuilder.Entity<BonusPercentage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppliedJobsIds)
                    .HasColumnName("AppliedJobs_IDs")
                    .HasColumnType("text");

                entity.Property(e => e.BillingEmail).HasMaxLength(50);

                entity.Property(e => e.CurrentCity).HasMaxLength(60);

                entity.Property(e => e.CurrentCountry).HasMaxLength(60);

                entity.Property(e => e.Cv)
                    .HasColumnName("CV")
                    .HasColumnType("text");

                entity.Property(e => e.CvStatus).HasColumnName("CV_Status");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.EducationLevel).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ExpectedSalary).HasMaxLength(20);

                entity.Property(e => e.Facebook).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.GooglePlus).HasMaxLength(100);

                entity.Property(e => e.Industry).HasColumnType("text");

                entity.Property(e => e.IndustryUseThis).HasColumnType("text");

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.LastActiveDate).HasColumnType("datetime");

                entity.Property(e => e.LastApplicationSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LinkedIn).HasMaxLength(200);

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.MandarinLevel).HasMaxLength(30);

                entity.Property(e => e.MinSalary).HasMaxLength(20);

                entity.Property(e => e.Nationality).HasMaxLength(60);

                entity.Property(e => e.Nickname).HasMaxLength(100);

                entity.Property(e => e.Nickname2).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfileImage).HasColumnType("text");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50);

                entity.Property(e => e.QualificationLevel).HasMaxLength(30);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ShortlistedJobsIds)
                    .HasColumnName("ShortlistedJobs_IDs")
                    .HasColumnType("text");

                entity.Property(e => e.Twitter).HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("text");

                entity.Property(e => e.Wechat).HasMaxLength(50);

                entity.Property(e => e.WorkExperience).HasMaxLength(50);

                entity.Property(e => e.WorkExperienceUseThis).HasMaxLength(50);
            });

            modelBuilder.Entity<CandidateCvnew>(entity =>
            {
                entity.ToTable("CandidateCVNew");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("Candidate_ID");

                entity.Property(e => e.LocalPath).HasMaxLength(255);

                entity.Property(e => e.WebPath).HasMaxLength(255);
            });

            modelBuilder.Entity<CandidateFinancialTransaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminTellerId).HasColumnName("Admin_Teller_ID");

                entity.Property(e => e.CandidateId).HasColumnName("Candidate_ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);
            });

            modelBuilder.Entity<CandidatePictureNew>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("Candidate_ID");

                entity.Property(e => e.LocalPath).HasMaxLength(255);

                entity.Property(e => e.WebPath).HasMaxLength(255);
            });

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Asap).HasColumnName("ASAP");

                entity.Property(e => e.CompanyAddress).HasMaxLength(512);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name");

                entity.Property(e => e.CompanyNameZh)
                    .HasColumnName("Company_Name_ZH")
                    .HasMaxLength(512);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.ContractEnd).HasColumnType("datetime");

                entity.Property(e => e.ContractStart).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Ds)
                    .HasColumnName("DS")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Industry).HasMaxLength(512);

                entity.Property(e => e.Level).HasMaxLength(50);

                entity.Property(e => e.Native).HasMaxLength(50);

                entity.Property(e => e.NonNative)
                    .HasColumnName("Non_Native")
                    .HasMaxLength(50);

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50);

                entity.Property(e => e.SchoolLisence)
                    .HasColumnName("School_Lisence")
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UploadedById).HasColumnName("UploadedByID");

                entity.Property(e => e.UploadedByName).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.Website).HasMaxLength(500);

                entity.Property(e => e.Wechat).HasMaxLength(100);
            });

            modelBuilder.Entity<CompanyAttachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DiskLocation).IsRequired();

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.WebLocation).IsRequired();
            });

            modelBuilder.Entity<CompanyNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EchinaCareersFee>(entity =>
            {
                entity.ToTable("EChinaCareersFee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployerId).HasColumnName("EmployerID");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Package).HasMaxLength(50);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailOptOut>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BillingEmail).HasMaxLength(50);

                entity.Property(e => e.CompanySizeNoOfEmployees).HasMaxLength(20);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.CvdownloadCredits).HasColumnName("CVDownloadCredits");

                entity.Property(e => e.DisplayNameEn).HasMaxLength(100);

                entity.Property(e => e.DisplayNameZh).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Facebook).HasMaxLength(100);

                entity.Property(e => e.GooglePlus).HasMaxLength(100);

                entity.Property(e => e.Industry).HasColumnType("text");

                entity.Property(e => e.IndustryIgnore).HasColumnType("text");

                entity.Property(e => e.LastActiveDate).HasColumnType("datetime");

                entity.Property(e => e.LinkedIn).HasMaxLength(200);

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.MembershipExpires).HasColumnType("datetime");

                entity.Property(e => e.Nickname).HasMaxLength(100);

                entity.Property(e => e.Nickname2).HasMaxLength(50);

                entity.Property(e => e.OldId).HasColumnName("oldID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfileImage).HasColumnType("text");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ShortlistedCandidatesIds)
                    .HasColumnName("ShortlistedCandidates_IDs")
                    .HasColumnType("text");

                entity.Property(e => e.Twitter).HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("text");

                entity.Property(e => e.ViewableCandidatesIds)
                    .HasColumnName("ViewableCandidates_IDs")
                    .HasColumnType("text");

                entity.Property(e => e.Wechat).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployerBusinessLicenseNew>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployerId).HasColumnName("Employer_ID");

                entity.Property(e => e.LocalPath).HasMaxLength(255);

                entity.Property(e => e.WebPath).HasMaxLength(255);
            });

            modelBuilder.Entity<EmployerFinancialTransaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminTellerId).HasColumnName("Admin_Teller_ID");

                entity.Property(e => e.AliPayOutTradeNo)
                    .HasColumnName("AliPay_OutTradeNo")
                    .HasMaxLength(50);

                entity.Property(e => e.AliPayTradeNo)
                    .HasColumnName("AliPay_TradeNo")
                    .HasMaxLength(50);

                entity.Property(e => e.CvCreditsAfterTransaction).HasColumnName("CV_CreditsAfterTransaction");

                entity.Property(e => e.CvCreditsExchanged).HasColumnName("CV_CreditsExchanged");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EccInvoiceNo).HasColumnName("Ecc_InvoiceNo");

                entity.Property(e => e.EmployerId).HasColumnName("Employer_ID");

                entity.Property(e => e.PaymentType).HasMaxLength(100);

                entity.Property(e => e.PaypalInvoiceNo)
                    .HasColumnName("Paypal_InvoiceNo")
                    .HasMaxLength(50);

                entity.Property(e => e.WechatOutTradeNo)
                    .HasColumnName("Wechat_OutTradeNo")
                    .HasMaxLength(50);

                entity.Property(e => e.YeePayTrackingId)
                    .HasColumnName("YeePayTrackingID")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<EmployerPictureNew>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployerId).HasColumnName("Employer_ID");

                entity.Property(e => e.LocalPath).HasMaxLength(255);

                entity.Property(e => e.WebPath).HasMaxLength(255);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<EventFileUploadNew>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.LocalPath).HasMaxLength(255);

                entity.Property(e => e.VisitorId).HasColumnName("VisitorID");

                entity.Property(e => e.WebPath).HasMaxLength(255);
            });

            modelBuilder.Entity<EventVisitor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CurrentJobTitle).HasMaxLength(100);

                entity.Property(e => e.CurrentLocation).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventLocation).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(5);

                entity.Property(e => e.HighestQualification).HasMaxLength(100);

                entity.Property(e => e.Industry).HasMaxLength(300);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LinkedIn).HasMaxLength(400);

                entity.Property(e => e.Major).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.QrcodeScanDate)
                    .HasColumnName("QRCodeScanDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegisteredToEcc).HasColumnName("RegisteredToECC");

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.UniversityName).HasMaxLength(400);

                entity.Property(e => e.Wechat).HasMaxLength(100);

                entity.Property(e => e.WorkExperience).HasMaxLength(15);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventVisitor)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventVisi__Event__5E1FF51F");
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NameChinese).HasColumnName("Name_Chinese");
            });

            modelBuilder.Entity<JobApplication>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.ApplicantName).HasMaxLength(300);

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.EmployerId).HasColumnName("EmployerID");

                entity.Property(e => e.EmployerName).HasMaxLength(300);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobTitle).HasMaxLength(300);
            });

            modelBuilder.Entity<JobFunction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NameChinese).HasColumnName("Name_Chinese");
            });

            modelBuilder.Entity<JobPost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicantIdsList)
                    .HasColumnName("ApplicantIDsList")
                    .HasColumnType("text");

                entity.Property(e => e.AuthorCity).HasMaxLength(70);

                entity.Property(e => e.AuthorCountry).HasMaxLength(70);

                entity.Property(e => e.AvailableTo).HasMaxLength(60);

                entity.Property(e => e.AvailableToIgnore).HasMaxLength(60);

                entity.Property(e => e.CareerLevel).HasMaxLength(50);

                entity.Property(e => e.ChineseRequired).HasMaxLength(15);

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.ClosingDateIgnore).HasMaxLength(20);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDateIgnore).HasMaxLength(20);

                entity.Property(e => e.CsUser)
                    .HasColumnName("CS_user")
                    .HasColumnType("text");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ExpiryDateIgnore).HasMaxLength(20);

                entity.Property(e => e.JobFeatredEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobFeatured).HasMaxLength(10);

                entity.Property(e => e.JobFeaturedHomePage).HasMaxLength(10);

                entity.Property(e => e.JobFeaturedHomePageEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(100);

                entity.Property(e => e.JobReferral).HasMaxLength(60);

                entity.Property(e => e.JobType).HasMaxLength(30);

                entity.Property(e => e.LastViewDate).HasColumnType("datetime");

                entity.Property(e => e.Locations).HasColumnType("text");

                entity.Property(e => e.Qualification).HasMaxLength(60);

                entity.Property(e => e.QualificationIgnore).HasMaxLength(60);

                entity.Property(e => e.Salary).HasMaxLength(50);

                entity.Property(e => e.SalaryPackage).HasMaxLength(50);

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.StatusIgnore).HasMaxLength(15);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.WorkLocation).HasMaxLength(50);
            });

            modelBuilder.Entity<JobSearchData>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Industries).HasMaxLength(1000);

                entity.Property(e => e.JobFunctions).HasMaxLength(500);

                entity.Property(e => e.JobType).HasMaxLength(50);

                entity.Property(e => e.Keywords).HasMaxLength(255);

                entity.Property(e => e.Locations).HasMaxLength(500);
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.ConsultantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FirstAttemptDate).HasColumnType("datetime");

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Link).HasMaxLength(512);

                entity.Property(e => e.SecondAttemptDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LeadNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LeadId).HasColumnName("LeadID");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CvCredits).HasColumnName("CV_Credits");

                entity.Property(e => e.LengthDays).HasColumnName("Length_Days");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.MessageSeenDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderName).HasMaxLength(200);
            });

            modelBuilder.Entity<Notarisation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).HasMaxLength(255);

                entity.Property(e => e.CandidateName).HasMaxLength(255);

                entity.Property(e => e.Citizenship)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConsultantFinishDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.ConsultantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PrePaymentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NotarisationAttachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DiskLocation).IsRequired();

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.NotarisationId).HasColumnName("NotarisationID");

                entity.Property(e => e.WebLocation).IsRequired();
            });

            modelBuilder.Entity<NotarisationNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.NotarisationId).HasColumnName("NotarisationID");
            });

            modelBuilder.Entity<RecruiterCandidate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateIdWebsite).HasColumnName("CandidateID_Website");

                entity.Property(e => e.ContactMethod).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentLocation).HasMaxLength(255);

                entity.Property(e => e.CvStatus).HasColumnName("CV_Status");

                entity.Property(e => e.Cvlocation).HasColumnName("CVLocation");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Facebook).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GooglePlus).HasMaxLength(100);

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LinkedIn).HasMaxLength(200);

                entity.Property(e => e.Nationality).HasMaxLength(60);

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50);

                entity.Property(e => e.QualificationLevel).HasMaxLength(30);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.ThirdPartyId).HasColumnName("ThirdPartyID");

                entity.Property(e => e.ThirdPartyName).HasMaxLength(255);

                entity.Property(e => e.Twitter).HasMaxLength(100);

                entity.Property(e => e.UniversityName).HasMaxLength(255);

                entity.Property(e => e.UploadedById).HasColumnName("UploadedByID");

                entity.Property(e => e.UploadedByName).HasMaxLength(255);

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UrlId)
                    .HasColumnName("URL_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.VisaExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Wechat).HasMaxLength(50);

                entity.Property(e => e.WorkExperience).HasMaxLength(50);

                entity.Property(e => e.WorkStartDate).HasMaxLength(255);
            });

            modelBuilder.Entity<RecruiterCandidateAttachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DiskLocation).IsRequired();

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.WebLocation).IsRequired();
            });

            modelBuilder.Entity<RecruiterCandidateNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RecruitingJobAttachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DiskLocation).IsRequired();

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.WebLocation).IsRequired();
            });

            modelBuilder.Entity<RecruitingJobNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnName("JobID");
            });

            modelBuilder.Entity<RecruitingJobPost>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(512);

                entity.Property(e => e.CompanyType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<RecruitmentFee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateName).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.ConsultantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Statistics>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.EmployerId).HasColumnName("EmployerID");

                entity.Property(e => e.TemporaryTrackingCookie).HasMaxLength(50);
            });

            modelBuilder.Entity<VisaProcess>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNo).HasMaxLength(255);

                entity.Property(e => e.CandidateName).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.ConsultantFinishedDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.ConsultantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PrePaymentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisaProcessAttachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DiskLocation).IsRequired();

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.VisaProcessId).HasColumnName("VisaProcessID");

                entity.Property(e => e.WebLocation).IsRequired();
            });

            modelBuilder.Entity<VisaProcessNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.VisaProcessId).HasColumnName("VisaProcessID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
