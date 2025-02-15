﻿using Mazi.Pipeline.Api.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mazi.Pipeline.Api.DataAccess;

public partial class MaziAppDbContext : DbContext, IMaziAppDbContext
{
   public MaziAppDbContext(DbContextOptions<MaziAppDbContext> options)
      : base(options) { }

   public DbSet<ConfigurationItemEntity> ConfigurationItemEntities { get; set; }
   public DbSet<FeedbackEntity> FeedbackEntities { get; set; }
   public DbSet<LogEntryEntity> LogEntryEntities { get; set; }
   public DbSet<LookupEntity> LookupEntities { get; set; }
   public DbSet<PersonEntity> PersonEntities { get; set; }
   public DbSet<UserEntity> UserEntities { get; set; }
   public DbSet<UserClaimEntity> UserClaimEntities { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder
         .Entity<ConfigurationItemEntity>()
         .HasQueryFilter(e => e.Status != ApiConstants.StatusDeleted);
      modelBuilder
         .Entity<FeedbackEntity>()
         .HasQueryFilter(e => e.Status != ApiConstants.StatusDeleted);
      modelBuilder
         .Entity<LookupEntity>()
         .HasQueryFilter(e => e.Status != ApiConstants.StatusDeleted);
      modelBuilder
         .Entity<PersonEntity>()
         .HasQueryFilter(e => e.Status != ApiConstants.StatusDeleted);
      modelBuilder
         .Entity<UserEntity>()
         .HasQueryFilter(e => e.Status != ApiConstants.StatusDeleted);
      modelBuilder
         .Entity<UserClaimEntity>()
         .HasQueryFilter(e => e.Status != ApiConstants.StatusDeleted);
   }
}
