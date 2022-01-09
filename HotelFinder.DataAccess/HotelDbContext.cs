using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace HotelFinder.DataAccess
{
    //Burada entity framework işlemlerini yapacağız.Bu yüzden dbcontext nesnesi gerekiyor.
    class HotelDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.; Database=HotelDb; Trusted_Connection=True;");
        }

        public DbSet<Hotel> Hotels { get; set; }


    }
}
