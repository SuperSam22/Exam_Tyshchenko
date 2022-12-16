using System.ComponentModel.DataAnnotations;
using static System.Double;

namespace Apartment_back.Models;

public enum Category
{
    Price,
    Square,
    location,
    Area,
    drawing_scheme,
    ID
}

public class Expense
{
    public int Id_Apartment { get; set; }
    public string Edit apartments { get; set; } = null!;
    
    [Range(0, MaxValue)]
    public double Location { get; set; }
    public Price { get; set; }
    public Category Category { get; set; }
}