using Microsoft.EntityFrameworkCore;

using Apartment_back.Efc.Models;

namespace Apartment_back.Efc.Efc;

public sealed class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Expense> Expenses { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expense>().HasData(
            new Expense
            {
                Id_apartment = 1,
                Square = "25",
                Price = 20000.75,
                Location = Lvivska_12,
                Category = Category.Square
            },
            new Expense
            {
                Id_apartment = 2,
                Square = "50",
                Price = 320000.75,
                Location = Lvivska_12,
                Category = Category.Square
            },
            new Expense
            {
                Id_apartment = 3,
                Square = "60",
                Price = 380000.75,
                Location = Striyska_10,
                Category = Category.Id
            },
            new Expense
            {
                Id_apartment = 4,
                Square = "75",
                Price = 500000.75,
                Location = Lvivska_45,
                Category = Category.Price
            }
        );
    }
}