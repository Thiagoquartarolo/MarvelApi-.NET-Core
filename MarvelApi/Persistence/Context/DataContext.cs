using Microsoft.EntityFrameworkCore;
using MarvelApi.Domain.Models;

namespace MarvelApi.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }

        public DbSet<Characters> Characters { get; set; }
        public DbSet<Comics> Comics { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Stories> Stories { get; set; }
    }
}