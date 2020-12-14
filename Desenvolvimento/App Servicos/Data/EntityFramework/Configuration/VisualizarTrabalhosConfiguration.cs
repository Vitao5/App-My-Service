using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class VisualizarTrabalhosConfiguration : IEntityTypeConfiguration<Models.VisualizarTrabalhos>
    {
        public void Configure(EntityTypeBuilder<VisualizarTrabalhos> builder)
        {
            builder.ToTable("VisualizarTrabalhos", "MeuAppVictor");
            builder.HasKey("IdVisualizacao");

            builder.Property("NomeTrabalhador")
                .HasColumnName("NomeTrabalhador")
                .HasColumnType("varchar(100)");

            builder.Property("DescricaoTrabalho")
                .HasColumnName("DescricaoTrabalho")
                .HasColumnType("varchar(100)");

            builder.Property("Cidade")
                .HasColumnName("Cidade")
                .HasColumnType("varchar(50)");

            builder.Property("Valor")
                .HasColumnName("Valor")
                .HasColumnType("decimal");
        }
    }
}
