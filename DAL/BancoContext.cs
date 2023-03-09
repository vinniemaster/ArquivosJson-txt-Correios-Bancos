using Microsoft.EntityFrameworkCore;
using TESTE.Models;

namespace TESTE.DAL
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<TB_NUMEROS> TB_NUMEROS { get; set; }
        //public DbSet<TB_JSON> TB_JSON { get; set; }
    }
}
