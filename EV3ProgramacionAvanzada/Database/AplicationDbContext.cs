using EV3ProgramacionAvanzada.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace EV3ProgramacionAvanzada.Database
{
    public class AplicationDbContext
    {
        public AplicationDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<herramienta> herramientas { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<movimiento> movimientos { get; set; }
        public DbSet<asignacion> asignacion { get; set; }
    
    }
}
