using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestCore.Models;

public partial class HarshaDbContext : DbContext
{
    public HarshaDbContext()
    {
    }

    public HarshaDbContext(DbContextOptions<HarshaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DepartmentModel> DepartmentModels { get; set; }

    public virtual DbSet<EmployeeModel> EmployeeModels { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-L1958T5\\SQLSERVER;Initial Catalog=HarshaDb;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentModel>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK_dbo.DepartmentModels");
        });

        modelBuilder.Entity<EmployeeModel>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK_dbo.EmployeeModels");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Login");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tblRole");

            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRoleMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserRoleMapping");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
