﻿using AccessOne.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessOne.Infra.Data.Mapping
{
    public class ComandoMap : IEntityTypeConfiguration<Comando>
    {
        public void Configure(EntityTypeBuilder<Comando> builder)
        {
            builder.ToTable("Comando");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.ComandoStr)
                    .IsRequired()
                    .HasColumnName("ComandoStr");

            builder.Property(c => c.DataRegistro)
                    .IsRequired()
                    .HasColumnName("DataRegistro");

            builder.Property(c => c.DataExecucao)
                    .IsRequired(false)
                    .HasColumnName("DataExecucao");

            builder.Property(c => c.Retorno)
                    .IsRequired(false)
                    .HasColumnName("Retorno");
        }
    }

}