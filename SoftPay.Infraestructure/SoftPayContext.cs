using Microsoft.EntityFrameworkCore;
using SoftPay.Core.Entities;
using System.Reflection;

namespace SoftPay.Infraestructure
{
    public class SoftPayContext(DbContextOptions options) : DbContext(options) //construtor atualizado
    {
        public virtual DbSet<Carteira> Carteiras { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Cofrinho> Cofrinhos { get; set; }

        public virtual DbSet<Endereco> Enderecos { get; set; }

        public virtual DbSet<Transacao> Transacaos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
