using System;
using System.Data.Entity;
using System.Linq;

namespace StoreOnline.Controllers
{
    public class AdminDbContext : DbContext
    {
        // Your context has been configured to use a 'AdminDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StoreOnline.Controllers.AdminDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AdminDbContext' 
        // connection string in the application configuration file.
        public AdminDbContext()
            : base("name=AdminDbContext")
        {
        }

        public System.Data.Entity.DbSet<StoreOnline.Models.Admin> Admins { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}