using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuscaDadosCVM.Models;

namespace BuscaDadosCVM.Data
{
    public class BuscaDadosCVMContext : DbContext
    {
        public BuscaDadosCVMContext (DbContextOptions<BuscaDadosCVMContext> options)
            : base(options)
        {
        }

        public DbSet<BuscaDadosCVM.Models.Taxa> Taxa { get; set; }
        public DbSet<BuscaDadosCVM.Models.ImportacaoTaxa> ImportacaoTaxa { get; set; }

        //public DbSet<BuscaDadosCVM.Models.DataAno> Mes { get; set; }
    }
}
