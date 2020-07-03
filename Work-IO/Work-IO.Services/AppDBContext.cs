using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Work_IO.Models;

namespace Work_IO.Services
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Empresa> Empresas { get; set; } 
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Asesor> Asesores { get; set; }
        public DbSet<Referencias> Referencias { get; set; }
        public DbSet<Nacionalidad> Nacionalidad { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        
    }
}
