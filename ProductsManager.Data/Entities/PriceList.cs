using System.ComponentModel.DataAnnotations;

namespace ProductsManager.Data.Entities;

public class PriceList
{
    public int Id { get; set; }
    [MaxLength(200)] [Required] public string Titel { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }


    public Currency Currency { get; set; }
    public int CurrencyId { get; set; }

    public List<Customer> Customers { get; set; } = new();
    public List<PriceListPosition> PriceListPositions{ get; set; } = new();
}