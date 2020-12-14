using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App_Servicos.Data.Entity_Framework.Configuration;
using App_Servicos.Data.EntityFramework.Configuration;
using App_Servicos.Models;

namespace App_Servicos.Data.Entity_Framework.Comum
{
    public class Contexto : DbContext
    {
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }
        public DbSet<LoginSistema> LoginSistema { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<PrestadorServico> PrestadorServico { get; set; }
        public DbSet<AvaliarServico> AvaliarServico { get; set; }
        public DbSet<VisualizarTrabalhos> VisualizarTrabalhos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ServicoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new CadastroConfiguration());
            modelBuilder.ApplyConfiguration(new LoginSistemaConfiguration());
            modelBuilder.ApplyConfiguration(new PagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new PrestadorServicoConfiguration());
            modelBuilder.ApplyConfiguration(new AvaliarServicoConfiguration());
            modelBuilder.ApplyConfiguration(new VisualizarTrabalhosConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Data source = 201.62.57.93;
                database = dbPICC_20202;
                user id = laboratorio;
                password = @laboratorio*;
            ");
        }
    }
}
