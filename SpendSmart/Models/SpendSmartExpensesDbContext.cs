using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class SpendSmartExpensesDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartExpensesDbContext(DbContextOptions<SpendSmartExpensesDbContext> options)
            : base(options) 
        {
            
        }
    }
}
