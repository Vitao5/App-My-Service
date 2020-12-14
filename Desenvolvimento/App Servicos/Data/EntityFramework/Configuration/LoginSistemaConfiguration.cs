using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.EntityFramework.Configuration
{
    public class LoginSistemaConfiguration : IEntityTypeConfiguration<LoginSistema>
    {
        public void Configure(EntityTypeBuilder<LoginSistema> builder)
        {
            builder.ToTable("LoginSistema", "MeuAppVictor");
            builder.HasKey("IdUsuario");

            builder.Property("Usuario")
                .HasColumnName("Usuario")
                .HasColumnType("varchar(200)");

            builder.Property("Senha")
                .HasColumnName("Senha")
                .HasColumnType("varchar(200)");
        }
    }
}
