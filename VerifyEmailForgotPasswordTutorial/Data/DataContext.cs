

namespace VerifyEmailForgotPasswordTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            base.OnConfiguring(optionsbuilder);
            optionsbuilder.UseSqlServer("server=ATLAS;database=userdb;trusted_connection=true;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
