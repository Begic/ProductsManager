using System.ComponentModel.DataAnnotations;

namespace ProductsManager.Data.Entities;

public class CustomerType
{
    public int Id { get; set; }
    [MaxLength(200)] [Required] public string Title { get; set; }
    [MaxLength(200)] [Required] public string Note { get; set; }


    public List<Customer> Customers { get; set; } = new();
}