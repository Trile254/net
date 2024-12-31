public class Product
{
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
    
    public decimal TotalStockValue()
    {
        return Price * QuantityInStock;
    }
}