﻿using Microsoft.EntityFrameworkCore;
using System;

namespace ProjetoFinalBloco2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            
        }

    }
}