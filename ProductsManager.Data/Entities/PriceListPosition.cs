namespace ProductsManager.Data.Entities;

public class PriceListPosition
{
    public int Id { get; set; }
    public int PositionsNr { get; set; }

    public decimal Price { get; set; }

    public PriceList PriceList { get; set; }
    public int PriceListId { get; set; }
    
    public Product Product { get; set; }
    public int ProductId { get; set; }
}