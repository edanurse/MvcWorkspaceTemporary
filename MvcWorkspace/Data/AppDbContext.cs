using Microsoft.EntityFrameworkCore;
using MvcWorkspace.Models;

namespace MvcWorkspace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Expense> Expenses { get; set; }
    }
}
