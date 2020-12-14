using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Models.Servico>
    {
        public void Configure(EntityTypeBuilder<Models.Servico> builder)
        {
            builder.ToTable("Servico", "MeuAppVictor");
            builder.HasKey("IdServico");


            builder.Property("IdTrabalhador")
                .HasColumnName("IdTrabalhador")
                .HasColumnType("int");

            builder.Property("IdCliente")
                .HasColumnName("IdCliente")
                .HasColumnType("int");

            builder.Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("char(30)");

            builder.Property("Valor")
                .HasColumnName("Valor")
                .HasColumnType("real");

            builder.Property("Descricao")
                .HasColumnName("Descricao")
                .HasColumnType("varchar(300)");

        }
    }
}

