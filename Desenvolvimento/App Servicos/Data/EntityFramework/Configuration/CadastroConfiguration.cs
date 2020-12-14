using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class CadastroConfiguration : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Models.Cadastro> builder)
        {
            builder.ToTable("Cadastro", "MeuAppVictor");
            builder.HasKey("IdCadastro");

            builder.Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property("Cidade")
                .HasColumnName("Cidade")
                .HasColumnType("varchar(100)");

            builder.Property("NumeroCasa")
                .HasColumnName("NumeroCasa")
                .HasColumnType("varchar(10)");

            builder.Property("UF")
                .HasColumnName("UF")
                .HasColumnType("varchar(2)");



        }
    }
}
