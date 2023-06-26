using System.ComponentModel.DataAnnotations;

namespace ProductsManager.Data.Entities;

public class Currency
{
    public int Id { get; set; }
    [MaxLength(200)] [Required] public string Title { get; set; }
    public string? Symbol { get; set; }


    public List<Customer> Customers { get; set; } = new();
}