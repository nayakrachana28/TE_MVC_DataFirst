using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TE_MVC_DataFirst.Models
{
    public partial class TE_ASP_DOTNET_MVCContext : DbContext
    {
        public TE_ASP_DOTNET_MVCContext()
        {
        }

        public TE_ASP_DOTNET_MVCContext(DbContextOptions<TE_ASP_DOTNET_MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ELW5242\\SQLEXPRESS01;Database=TE_ASP_DOTNET_MVC;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.StudentId).HasColumnName("student_ID");

                entity.Property(e => e.StudentAge).HasColumnName("student_Age");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("student_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
