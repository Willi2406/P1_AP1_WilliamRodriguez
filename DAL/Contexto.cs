using Microsoft.EntityFrameworkCore;
using P1_AP1_WilliamRodriguez.Models;

namespace P1_AP1_WilliamRodriguez.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<EntradasHuacales> Huacales {  get; set; }
    }
}
