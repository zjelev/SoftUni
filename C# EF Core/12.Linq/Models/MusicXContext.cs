﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace LinqDemo.Models
{
    public partial class MusicXContext : DbContext
    {
        public MusicXContext()
        {
        }

        public MusicXContext(DbContextOptions<MusicXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArtistMetadata> ArtistMetadata { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<SongArtists> SongArtists { get; set; }
        public virtual DbSet<SongMetadata> SongMetadata { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }
        public virtual DbSet<Sources> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=.\\SQLEXPRESS; Database=MusicX;Integrated Security=true;")
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    // .UseLazyLoadingProxies()
                    // .UseInMemoryDatabase() // for testing
                    ;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtistMetadata>(entity =>
            {
                entity.HasIndex(e => e.ArtistId);
                entity.HasIndex(e => e.IsDeleted);
                entity.HasIndex(e => e.SourceId);
                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistMetadata)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.SetNull);
                entity.HasOne(d => d.Source)
                    .WithMany(p => p.ArtistMetadata)
                    .HasForeignKey(d => d.SourceId);
            });

            modelBuilder.Entity<Artists>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);
            });

            modelBuilder.Entity<SongArtists>(entity =>
            {
                entity.HasIndex(e => e.ArtistId);
                entity.HasIndex(e => e.IsDeleted);
                entity.HasIndex(e => e.SongId);
                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.SongArtists)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Song)
                    .WithMany(p => p.SongArtists)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SongMetadata>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);
                entity.HasIndex(e => e.SongId);
                entity.HasIndex(e => e.SourceId);
                entity.HasOne(d => d.Song)
                    .WithMany(p => p.SongMetadata)
                    .HasForeignKey(d => d.SongId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Source)
                    .WithMany(p => p.SongMetadata)
                    .HasForeignKey(d => d.SourceId);
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.HasIndex(e => e.IsDeleted);
                entity.HasIndex(e => e.SourceId);
                entity.Property(e => e.Name).IsRequired();
                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.SourceId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
