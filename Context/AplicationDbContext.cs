using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Prueba_Técnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Context
{
    internal class AplicationDbContext:DbContext
    {
        
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EmpresaPrueba;Integrated Security=True;TrustServerCertificate=True")
                .EnableSensitiveDataLogging(true);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        public DbSet<Empresa> Empresas { get; set; }
    }
}
