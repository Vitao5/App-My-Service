using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class PrestadorServicoConfiguration : IEntityTypeConfiguration<PrestadorServico>
    {
        public void Configure(EntityTypeBuilder<PrestadorServico> builder)
        {
            builder.ToTable("PrestadorServico", "MeuAppVictor");
            builder.HasKey("IdTrabalhador");

            builder.Property("NomeTrabalhador")
                .HasColumnName("NomeTrabalhador")
                .HasColumnType("varchar(100)");

            builder.Property("DataNascimento")
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder.Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("varchar(11)");

            builder.Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("varchar(30)");

        }
    }
}
