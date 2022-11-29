using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreOnline.Models
{
    public class Admin
    {
        [Required]
        public int Id { get; set; }

        public string Bookname { get; set; }

        public DateTime RealeaseDate { get; set; }

        public decimal Price { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

    }
    public class AdminDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
    }
}