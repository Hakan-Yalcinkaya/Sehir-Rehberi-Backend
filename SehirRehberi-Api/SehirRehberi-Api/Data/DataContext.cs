﻿
using Microsoft.EntityFrameworkCore;
using SehirRehberi_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi_Api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
               
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
