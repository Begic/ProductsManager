using System.ComponentModel.DataAnnotations;

namespace ProductsManager.Data.Entities;

public class Product
{
    public int Id { get; set; }
    [MaxLength(200)][Required] public string Title { get; set; }
    public bool IsActive { get; set; }
    public DateTime Created { get; set; }
    [MaxLength(200)] public string? CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    [MaxLength(200)] public string? ModifiedBy { get; set; }


    public List<PriceListPosition> PriceListPositions { get; set; } =new();
}