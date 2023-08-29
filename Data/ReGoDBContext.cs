using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ReGoAuthentication.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReGoAuthentication.Data
{
    public partial class ReGoDBContext : DbContext
    {
        public ReGoDBContext()
        {
        }

        public ReGoDBContext(DbContextOptions<ReGoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achievements> Achievements { get; set; }
        public virtual DbSet<CandidateAcademics> CandidateAcademics { get; set; }
        public virtual DbSet<CandidateExperience> CandidateExperience { get; set; }
        public virtual DbSet<CandidateSkills> CandidateSkills { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<Certifications> Certifications { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CompanyFollowers> CompanyFollowers { get; set; }
        public virtual DbSet<Connections> Connections { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Endorsements> Endorsements { get; set; }
        public virtual DbSet<Experiences> Experiences { get; set; }
        public virtual DbSet<JobApplications> JobApplications { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Recommendations> Recommendations { get; set; }
        public virtual DbSet<Referals> Referals { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<UserSkills> UserSkills { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-DFASQ2GB\\SQLEXPRESS;Database=ReGoDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievements>(entity =>
            {
                entity.HasKey(e => e.AchievementId)
                    .HasName("PK__Achievem__3C492E83C6A3BFE1");

                entity.Property(e => e.AchievementId).ValueGeneratedNever();

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Achievements)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Achieveme__candi__208CD6FA");
            });

            modelBuilder.Entity<CandidateAcademics>(entity =>
            {
                entity.HasKey(e => e.EducationId)
                    .HasName("PK__Candidat__45C0CFE7242EC5D2");

                entity.Property(e => e.Degree).IsUnicode(false);

                entity.Property(e => e.Major).IsUnicode(false);

                entity.Property(e => e.SchoolName).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateAcademics)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Candidate__candi__1AD3FDA4");
            });

            modelBuilder.Entity<CandidateExperience>(entity =>
            {
                entity.HasKey(e => e.ExperienceId)
                    .HasName("PK__Candidat__EB216AFC48341886");

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.StillWorkingHere).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateExperience)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Candidate__candi__17F790F9");
            });

            modelBuilder.Entity<CandidateSkills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__Candidat__FBBA837996693651");

                entity.Property(e => e.ProficiencyLevel).IsUnicode(false);

                entity.Property(e => e.SkillName).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Candidate__candi__1DB06A4F");
            });

            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.HasKey(e => e.CandidateId)
                    .HasName("PK__Candidat__39BD4C186220392B");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.ProfilePictureUrl).IsUnicode(false);

                entity.Property(e => e.RsaIdentityNum).IsUnicode(false);
            });

            modelBuilder.Entity<Certifications>(entity =>
            {
                entity.HasKey(e => e.CertificationId)
                    .HasName("PK__Certific__185D5AECCE88B5CE");

                entity.Property(e => e.CertificationId).ValueGeneratedNever();

                entity.Property(e => e.CertificationName).IsUnicode(false);

                entity.Property(e => e.IssuingOrganization).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Certifica__candi__236943A5");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__comments__E7957687DE361F52");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__comments__post_i__60A75C0F");
            });

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__companie__3E267235C3C09BB4");

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.Industry).IsUnicode(false);

                entity.Property(e => e.Website).IsUnicode(false);
            });

            modelBuilder.Entity<CompanyFollowers>(entity =>
            {
                entity.HasKey(e => e.FollowerId)
                    .HasName("PK__company___444E322F0268678C");

                entity.Property(e => e.FollowDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyFollowers)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__company_f__compa__0A9D95DB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CompanyFollowers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__company_f__user___09A971A2");
            });

            modelBuilder.Entity<Connections>(entity =>
            {
                entity.HasKey(e => e.ConnectionId)
                    .HasName("PK__connecti__E4AA4DD09812950D");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Connections)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__connectio__user___5441852A");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.Degree).IsUnicode(false);

                entity.Property(e => e.FieldOfStudy).IsUnicode(false);

                entity.Property(e => e.Institution).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__education__user___2B3F6F97");
            });

            modelBuilder.Entity<Endorsements>(entity =>
            {
                entity.HasKey(e => e.EndorsementId)
                    .HasName("PK__endorsem__48F082769AF3F71A");

                entity.Property(e => e.EndorsementDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Endorsements)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__endorseme__skill__05D8E0BE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Endorsements)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__endorseme__user___04E4BC85");
            });

            modelBuilder.Entity<Experiences>(entity =>
            {
                entity.HasKey(e => e.ExperienceId)
                    .HasName("PK__experien__EB216AFC5BADAB75");

                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__experienc__user___286302EC");
            });

            modelBuilder.Entity<JobApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__job_appl__3BCBDCF2D50B35F9");

                entity.Property(e => e.ApplicationDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobApplications)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__job_appli__job_i__71D1E811");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobApplications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__job_appli__user___72C60C4A");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK__jobs__6E32B6A506610E6D");

                entity.Property(e => e.JobType).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.PostedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__jobs__company_id__6E01572D");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK__Language__804CF6B3D2A4C61C");

                entity.Property(e => e.LanguageId).ValueGeneratedNever();

                entity.Property(e => e.LanguageName).IsUnicode(false);

                entity.Property(e => e.ProficiencyLevel).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Languages)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Languages__candi__29221CFB");
            });

            modelBuilder.Entity<Likes>(entity =>
            {
                entity.HasKey(e => e.LikeId)
                    .HasName("PK__likes__992C793015B5CAB0");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Likes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__likes__user_id__6477ECF3");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__messages__0BBF6EE6C0E0C869");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK__messages__sender__68487DD7");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__posts__3ED78766DD4CEAD2");

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__posts__user_id__5812160E");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__Projects__BC799E1FEAD8A6C0");

                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.ProjectName).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Projects__candid__2645B050");
            });

            modelBuilder.Entity<Recommendations>(entity =>
            {
                entity.HasKey(e => e.RecommendationId)
                    .HasName("PK__recommen__BCB11F4FC8E7A801");

                entity.Property(e => e.GivenAt).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Recommendations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__recommend__user___7B5B524B");
            });

            modelBuilder.Entity<Referals>(entity =>
            {
                entity.HasKey(e => e.ReferenceId)
                    .HasName("PK__Referals__8E860B28FFE7EC8E");

                entity.Property(e => e.ReferenceId).ValueGeneratedNever();

                entity.Property(e => e.ReferenceEmail).IsUnicode(false);

                entity.Property(e => e.ReferenceName).IsUnicode(false);

                entity.Property(e => e.ReferencePhone).IsUnicode(false);

                entity.Property(e => e.ReferenceRelationship).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Referals)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Referals__candid__2BFE89A6");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__skills__FBBA83799F612DDE");

                entity.Property(e => e.SkillName).IsUnicode(false);
            });

            modelBuilder.Entity<UserSkills>(entity =>
            {
                entity.HasKey(e => e.UserSkillId)
                    .HasName("PK__user_ski__FD3B576B8569C903");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__user_skil__skill__30F848ED");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user_skil__user___300424B4");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__users__B9BE370F8F24D3FA");

                entity.Property(e => e.AltCellNumber).IsUnicode(false);

                entity.Property(e => e.CellNumber).IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Headline).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.ProfilePicture).IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
