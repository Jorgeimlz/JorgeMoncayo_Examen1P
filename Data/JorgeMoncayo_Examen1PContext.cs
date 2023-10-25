using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JorgeMoncayo_Examen1P.Models;

namespace JorgeMoncayo_Examen1P.Data
{
    public class JorgeMoncayo_Examen1PContext : DbContext
    {
        public JorgeMoncayo_Examen1PContext (DbContextOptions<JorgeMoncayo_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JorgeMoncayo_Examen1P.Models.JorgeMoncayo_tabla> JorgeMoncayo_tabla { get; set; } = default!;
    }
}
