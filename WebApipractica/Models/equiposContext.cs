﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebApipractica.Models
{
    public class equiposContext: DbContext
    {
        // es un constructor
        // alcance
        // alcance, nombre parametros
        public equiposContext(DbContextOptions<equiposContext> options) : base(options) { 
        } 

        public DbSet<equipos> equipos { get; set; }
    }
}
