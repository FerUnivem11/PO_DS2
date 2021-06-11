using Microsoft.EntityFrameworkCore;
using BelezaFut.Models;

namespace BelezaFut.Data
{
    public class BelezaFutContext : DbContext
    {
        public BelezaFutContext(DbContextOptions<BelezaFutContext> options) : base (options)
        {

        }

        public DbSet<Time> Time {get; set;}

        public DbSet<Jogador> Jogador{get; set;}
    }
}