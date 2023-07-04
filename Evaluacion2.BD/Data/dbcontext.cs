using Evaluacion2.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data
{
    internal class dbcontext : DbContext
    {
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Moderador> Moderadores { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        

        public dbcontext() 
        { 
        
        }
        public dbcontext(DbContextOptions options) : base(options)
        { 
        
        }
    }
}
