﻿#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio5Modulo3.Models;

public partial class Ejercicio5Modulo3Context : DbContext
{
    public Ejercicio5Modulo3Context(DbContextOptions<Ejercicio5Modulo3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        { 
            entity.ToTable("Usuario");

            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F1A81FC4F");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Apellido)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");

            entity.Property(e => e.Ciudad)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");

            entity.Property(e => e.Edad).HasColumnName("edad");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estado");

            entity.Property(e => e.Genero)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("genero");

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.Property(e => e.NombreUsuario)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");

            entity.Property(e => e.Pais)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pais");

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}