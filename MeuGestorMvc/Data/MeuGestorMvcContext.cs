using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeuGestorMvc.Models;

namespace MeuGestorMvc.Data
{
    public class MeuGestorMvcContext : DbContext
    {
        public MeuGestorMvcContext (DbContextOptions<MeuGestorMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MeuGestorMvc.Models.Client> Client { get; set; } = default!;
    }
}
