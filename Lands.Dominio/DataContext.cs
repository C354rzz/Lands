namespace Lands.Dominio
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Lands.Dominio.User> Users { get; set; }

        public System.Data.Entity.DbSet<Lands.Dominio.UserType> UserTypes { get; set; }
    }
}
