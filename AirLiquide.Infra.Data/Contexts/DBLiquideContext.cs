using AirLiquide.Domain.Entities;
using AirLiquide.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace AirLiquide.Infra.Data.Contexts
{
    public class DBLiquideContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public IDbContextTransaction Transaction { get; private set; }

        public DBLiquideContext(DbContextOptions<DBLiquideContext> options)
            : base(options)
        {
            /*
            if (Database.GetPendingMigrations().Count() > 0)
                Database.Migrate();
            */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer("Data Source=localhost;Port=11433;Initial Catalog=DBLiquide;Integrated Security=False;Persist Security Info=False;User ID=SA;Password=DockerSql2017!");

        }

        public IDbContextTransaction InitTransacao()
        {
            if (Transaction == null) Transaction = this.Database.BeginTransaction();
            return Transaction;
        }


        private void RollBack()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void SendChanges()
        {
            Salvar();
            Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
        }
    }
}
