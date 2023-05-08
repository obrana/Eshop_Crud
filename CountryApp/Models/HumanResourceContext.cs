using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CountryApp.Models;

public partial class HumanResourceContext : DbContext
{
    public HumanResourceContext()
    {
    }

    public HumanResourceContext(DbContextOptions<HumanResourceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Country", "HumanResource");

            entity.Property(e => e.Capital).HasMaxLength(45);
            entity.Property(e => e.Currency).HasMaxLength(45);
            entity.Property(e => e.Economy).HasMaxLength(45);
            entity.Property(e => e.Name).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
