using ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using PERSISTENCE.Configurations;

namespace PERSISTENCE
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        #region DbSets
        public DbSet<Character> Character { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ModelConfig(modelBuilder);
        }
        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new CharacerConfiguration(modelBuilder.Entity<Character>());
        }
    }
}
