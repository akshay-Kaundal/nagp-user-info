﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nagp.UserInfo.Models;

public partial class NagpUserDbContext : DbContext
{
    public NagpUserDbContext()
    {
    }

    public NagpUserDbContext(DbContextOptions<NagpUserDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserInformation> UserInformations { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Initial Catalog=NagpUserDb;Persist Security Info=True;TrustServerCertificate=True;User Id=SA;Password=1Secure*Password1; connect timeout=500");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserInfo__3214EC07F9F9E6CD");

            entity.ToTable("UserInformation");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
