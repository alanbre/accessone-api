﻿using AccessOne.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessOne.Infra.Data.Mapping
{
    public class ComputadorMap : IEntityTypeConfiguration<Computador>
    {
        public void Configure(EntityTypeBuilder<Computador> builder)
        {
            builder.ToTable("Computador");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                    .IsRequired()
                    .HasColumnName("Nome");

            builder.Property(c => c.Ip)
                    .IsRequired()
                    .HasColumnName("Ip");

            builder.Property(c => c.Disco)
                    .HasColumnName("EspacoEmDisco");

            builder.Property(c => c.Memoria)
                    .HasColumnName("Memoria");
        
            builder.HasMany(c => c.Comandos)
                .WithOne(cm => cm.Computador)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
