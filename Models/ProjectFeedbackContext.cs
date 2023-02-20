using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectFeedbackApi.Models
{
    public partial class ProjectFeedbackContext : DbContext
    {

        public ProjectFeedbackContext(DbContextOptions<ProjectFeedbackContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<ProjectFeedback> ProjectFeedback { get; set; }
        public virtual DbSet<Project> Project { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId)
                    .ValueGeneratedNever()
                    .HasColumnName("FeedbackId");

                entity.Property(e => e.FeedbackMessage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackTitle)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProjectFeedback>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId)
                    .ValueGeneratedNever()
                    .HasColumnName("RowID");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackId");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectId");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.Property(e => e.ProjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProjectId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}