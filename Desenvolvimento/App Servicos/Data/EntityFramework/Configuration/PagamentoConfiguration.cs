using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Configuration
{
    public class PagamentoConfiguration : IEntityTypeConfiguration<Pagamento>
    {

        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento", "MeuAppVictor");
            builder.HasKey("IdPagamento");

            builder.Property("FormaPagamento")
                .HasColumnName("FormaPagamento")
                .HasColumnType("varchar(20)");

            builder.Property("ContaPagante")
                .HasColumnName("ContaPagante")
                .HasColumnType("varchar(20)");

            builder.Property("ContaRecebedora")
                .HasColumnName("ContaRecebedora")
                .HasColumnType("varchar(20)");

            builder.Property("NomeTrabalhador")
                .HasColumnName("NomeTrabalhador")
                .HasColumnType("varchar(100)");

            builder.Property("NomeCliente")
                .HasColumnName("NomeCliente")
                .HasColumnType("varchar(100)");
        }
    }
}
