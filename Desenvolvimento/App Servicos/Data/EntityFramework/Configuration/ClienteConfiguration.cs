using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Models.Cliente> builder)
        {
            builder.ToTable("Cliente", "MeuAppVictor");
            builder.HasKey("IdCliente");


            builder.Property("NomeCliente")
                .HasColumnName("NomeCliente")
                .HasColumnType("varchar(100)");

            builder.Property("DataNasc")
                .HasColumnName("DataNasc")
                .HasColumnType("date");

            builder.Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("char(30)");

            builder.Property("VisualizarTrabalhos")
                .HasColumnName("VisualizarTrabalhos")
                .HasColumnType("int");

            builder.Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("string");

        }
    }
}
