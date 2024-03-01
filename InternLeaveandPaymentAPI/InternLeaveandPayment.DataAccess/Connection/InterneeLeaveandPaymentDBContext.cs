using System;
using InternLeaveandPayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace InternLeaveandPayment.DataAccess.Entities
{
    public partial class InterneeLeaveandPaymentDBContext : DbContext
    {
        public InterneeLeaveandPaymentDBContext()
        {
        }

        public InterneeLeaveandPaymentDBContext(DbContextOptions<InterneeLeaveandPaymentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DutyStation> DutyStations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Intern> Interns { get; set; }
        public virtual DbSet<InternDay> InternDays { get; set; }
        public virtual DbSet<InternLeave> InternLeaves { get; set; }
        public virtual DbSet<InternshipType> InternshipTypes { get; set; }
        public virtual DbSet<PermissionType> PermissionTypes { get; set; }
        public virtual DbSet<Statu> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;database=InterneeLeaveandPaymentDB;Trusted_Connection=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(100);
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("Day");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentManagerId).HasColumnName("DepartmentManagerID");

                entity.Property(e => e.DepartmentName).HasMaxLength(100);
            });

            modelBuilder.Entity<DutyStation>(entity =>
            {
                entity.ToTable("DutyStation");

                entity.Property(e => e.DutyStationId).HasColumnName("DutyStationID");

                entity.Property(e => e.DutyStationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeDepartmentId).HasColumnName("EmployeeDepartmentID");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.EmployeeSurname).HasMaxLength(100);
            });

            modelBuilder.Entity<Intern>(entity =>
            {
                entity.ToTable("Intern");

                entity.Property(e => e.InternId).HasColumnName("InternID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InternCompanyId).HasColumnName("InternCompanyID");

                entity.Property(e => e.InternContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternContactPersonPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternDepartmentId).HasColumnName("InternDepartmentID");

                entity.Property(e => e.InternDutyStationId).HasColumnName("InternDutyStationID");

                entity.Property(e => e.InternIntershipTypeId).HasColumnName("InternIntershipTypeID");

                entity.Property(e => e.InternManagerId).HasColumnName("InternManagerID");

                entity.Property(e => e.InternName).HasMaxLength(100);

                entity.Property(e => e.InternPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InternResponsibleTeacher).HasMaxLength(100);

                entity.Property(e => e.InternSchool).HasMaxLength(100);

                entity.Property(e => e.InternSchoolDepartment).HasMaxLength(100);

                entity.Property(e => e.InternSurname).HasMaxLength(100);

                entity.Property(e => e.InternTeacherPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.InternCompany)
                    .WithMany(p => p.Interns)
                    .HasForeignKey(d => d.InternCompanyId)
                    .HasConstraintName("FK_Intern_Company");

                entity.HasOne(d => d.InternDepartment)
                    .WithMany(p => p.Interns)
                    .HasForeignKey(d => d.InternDepartmentId)
                    .HasConstraintName("FK_Intern_Department");

                entity.HasOne(d => d.InternDutyStation)
                    .WithMany(p => p.Interns)
                    .HasForeignKey(d => d.InternDutyStationId)
                    .HasConstraintName("FK_Intern_DutyStation");

                entity.HasOne(d => d.InternIntershipType)
                    .WithMany(p => p.Interns)
                    .HasForeignKey(d => d.InternIntershipTypeId)
                    .HasConstraintName("FK_Intern_InternshipType");

                entity.HasOne(d => d.InternManager)
                    .WithMany(p => p.Interns)
                    .HasForeignKey(d => d.InternManagerId)
                    .HasConstraintName("FK_Intern_Employee");
            });

            modelBuilder.Entity<InternDay>(entity =>
            {
                entity.HasKey(e => e.InternDaysId);

                entity.ToTable("InternDay");

                entity.Property(e => e.InternDaysId).HasColumnName("InternDaysID");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.InternId).HasColumnName("InternID");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.InternDays)
                    .HasForeignKey(d => d.DayId)
                    .HasConstraintName("FK_InternDay_Day");

                entity.HasOne(d => d.Intern)
                    .WithMany(p => p.InternDays)
                    .HasForeignKey(d => d.InternId)
                    .HasConstraintName("FK_InternDay_Intern");
            });

            modelBuilder.Entity<InternLeave>(entity =>
            {
                entity.ToTable("InternLeave");

                entity.Property(e => e.InternLeaveId).HasColumnName("InternLeaveID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InternId).HasColumnName("InternID");

                entity.Property(e => e.LeaveEndDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveStartDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionTypeID");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.HasOne(d => d.Intern)
                    .WithMany(p => p.InternLeaves)
                    .HasForeignKey(d => d.InternId)
                    .HasConstraintName("FK_InternLeave_Intern");

                entity.HasOne(d => d.PermissionType)
                    .WithMany(p => p.InternLeaves)
                    .HasForeignKey(d => d.PermissionTypeId)
                    .HasConstraintName("FK_InternLeave_PermissionType");

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.InternLeaves)
                    .HasForeignKey(d => d.StatuId)
                    .HasConstraintName("FK_InternLeave_Statu");
            });

            modelBuilder.Entity<InternshipType>(entity =>
            {
                entity.ToTable("InternshipType");

                entity.Property(e => e.InternshipTypeId).HasColumnName("InternshipTypeID");

                entity.Property(e => e.InternshipTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermissionType>(entity =>
            {
                entity.ToTable("PermissionType");

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionTypeID");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PermissionTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statu>(entity =>
            {
                entity.ToTable("Statu");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.StatuName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
