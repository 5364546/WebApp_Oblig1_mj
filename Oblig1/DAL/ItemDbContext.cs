﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oblig1.Models;

namespace Oblig1.DAL
{
    public class ItemDbContext : DbContext

    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {


        }
        public DbSet<Person> person { get; set; }
        public DbSet<Hus> hus { get; set; } 
        public DbSet<Kunde> kunde { get; set; } 

        public DbSet <Ordre> ordre { get; set; }

        public DbSet <Bruker> bruker { get; set; }


       
    }

    
}
