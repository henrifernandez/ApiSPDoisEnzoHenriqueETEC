using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreBusines;

namespace ApiSPDoisEnzoHenriqueETEC.Data
{
    public class ApiSPDoisEnzoHenriqueETECContext : DbContext
    {
        public ApiSPDoisEnzoHenriqueETECContext (DbContextOptions<ApiSPDoisEnzoHenriqueETECContext> options)
            : base(options)
        {
        }

        public DbSet<CoreBusines.Aluno> Aluno { get; set; } = default!;
    }
}
