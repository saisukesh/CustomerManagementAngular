using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Dal
{
    public class DAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Custi>().ToTable("tblCustomerr");
           

        }
        public DbSet<Custi> Customers { get; set; }

       

    }
}