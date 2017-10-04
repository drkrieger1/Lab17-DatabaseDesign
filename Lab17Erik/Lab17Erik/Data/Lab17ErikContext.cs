using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab17Erik.Model;

namespace Lab17Erik.Models
{
    public class Lab17ErikContext : DbContext
    {
        public Lab17ErikContext (DbContextOptions<Lab17ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab17Erik.Model.Destenation> Destenation { get; set; }
    }
}
