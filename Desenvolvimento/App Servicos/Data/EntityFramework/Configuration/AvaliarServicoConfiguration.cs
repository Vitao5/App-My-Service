using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class AvaliarServicoConfiguration : IEntityTypeConfiguration<AvaliarServico>
    {
        public void Configure(EntityTypeBuilder<AvaliarServico> builder)
        {
            builder.ToTable("AvaliarServico", "MeuAppVictor");
            builder.HasKey("IdAvaliacao");

            builder.Property(f => f.Descricao)
                .HasColumnName("Descricao") 
                .HasColumnType("varchar(50)");

            builder.Property(f => f.NomeCliente)
                   .HasColumnName("NomeCliente")
                   .HasColumnType("varchar(100)");

            builder.Property(f => f.NomeTrabalhador)
                   .HasColumnName("NomeTrabalhado")
                   .HasColumnType("varchar100)");

            builder.Property(f => f.IdServico)
                   .HasColumnName("IdServico")
                   .HasColumnType("int");

        }
    }
}
