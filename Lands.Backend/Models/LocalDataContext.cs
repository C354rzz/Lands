﻿namespace Lands.Backend.Models
{
    using Dominio;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Lands.Dominio.User> Users { get; set; }

        public System.Data.Entity.DbSet<Lands.Dominio.UserType> UserTypes { get; set; }
    }
}