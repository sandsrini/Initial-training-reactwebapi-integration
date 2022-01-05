using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace applynowcrud.Models
{
    public partial class jdContext : DbContext
    {
        public jdContext()
        {
        }

        public jdContext(DbContextOptions<jdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Jdapplynow> Jdapplynows { get; set; }
        public virtual DbSet<Jduserregister> Jduserregisters { get; set; }
        public virtual DbSet<JobDetail> JobDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=jd;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Jdapplynow>(entity =>
            {
                entity.HasKey(e => e.ApplyId)
                    .HasName("PK__jdapplyn__8260CA821395A3AF");

                entity.ToTable("jdapplynow");

                entity.Property(e => e.ApplyId).HasColumnName("apply_id");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Letter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("letter");

                entity.Property(e => e.Link)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Resume)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("resume");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Jdapplynows)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__jdapplyno__job_i__03F0984C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Jdapplynows)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__jdapplyno__user___02FC7413");
            });

            modelBuilder.Entity<Jduserregister>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__jduserre__B9BE370F3051AF7C");

                entity.ToTable("jduserregister");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Emailid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emailid");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.SecurityQuest)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("securityQuest");

                entity.Property(e => e.Securityans)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("securityans");
            });

            modelBuilder.Entity<JobDetail>(entity =>
            {
                entity.HasKey(e => e.JobDetailsId)
                    .HasName("PK__job_deta__6A69DCB1AB403421");

                entity.ToTable("job_details");

                entity.Property(e => e.JobDetailsId).HasColumnName("job_details_id");

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("company_address");

                entity.Property(e => e.Companyname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("companyname");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.Experience)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("experience");

                entity.Property(e => e.JobCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("job_category");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("job_description");

                entity.Property(e => e.JobLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("job_location");

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("job_type");

                entity.Property(e => e.NoOfVacancies).HasColumnName("no_of_vacancies");

                entity.Property(e => e.PhNo).HasColumnName("ph_no");

                entity.Property(e => e.Requiredskills)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("requiredskills");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
