using
CashManagementSystem.Models;
using
 Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using
 Microsoft.EntityFrameworkCore;

namespace 
CashManagementSystem.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public DbSet<CashBox> CashBoxes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

}
