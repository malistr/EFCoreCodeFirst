﻿using Microsoft.EntityFrameworkCore;
using ReceteZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) 
        {
            
        }

        public virtual DbSet<Doktor> Doktorlar { get; set; }    
        public virtual DbSet<Recete> Receteler { get; set; }    
        public virtual DbSet<KullanimSekli> KullanimSekilleri { get; set; }    
        public virtual DbSet<Tani> Tanilar { get; set; }    
        public virtual DbSet<Ilac> Ilaclar { get; set; }    
        public virtual DbSet<ReceteIlac> ReceteIlaclari { get; set; }    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer("Server=DESKTOP-F2FGRQ0\\SQLEXPRESS;" +
          "Database=ReceteCF;Integrated Security=True;TrustServerCertificate=Yes");

    }
}
