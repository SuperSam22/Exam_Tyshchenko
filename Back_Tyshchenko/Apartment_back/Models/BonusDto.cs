using System.ComponentModel.DataAnnotations;
using static System.Double;

namespace Apartment_back.Models;

public class ExpenseDto
{
    public string Id_Apartment { get; set; } = null!;
    
    [Range(0, MaxValue)]
    public double Price { get; set; }
    public Location { get; set; }
    public Category Category { get; set; }
}