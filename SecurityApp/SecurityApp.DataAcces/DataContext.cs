namespace SecurityApp.DataAcces
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SecurityApp.Models;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {}
        public DbSet<Visitor> Visitors { get; set; }
    }
}