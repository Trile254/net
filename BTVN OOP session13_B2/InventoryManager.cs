public class InventoryManager
{
    private List<Product> products = new List<Product>();
    private List<Order> orders = new List<Order>();

    // Thêm sản phẩm mới
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Tìm kiếm sản phẩm theo tên
    public Product FindProductByName(string name)
    {
        return products.FirstOrDefault(p => p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase));
    }

    // Cập nhật giá bán hoặc số lượng tồn kho
    public void UpdateProduct(string productCode, decimal? newPrice, int? newQuantity)
    {
        var product = products.FirstOrDefault(p => p.ProductCode == productCode);
        if (product != null)
        {
            if (newPrice.HasValue)
                product.Price = newPrice.Value;

            if (newQuantity.HasValue)
                product.QuantityInStock = newQuantity.Value;
        }
    }

    // Tính tổng giá trị kho hàng
    public decimal CalculateTotalStockValue()
    {
        return products.Sum(p => p.TotalStockValue());
    }

    // Xóa sản phẩm khỏi danh sách
    public void RemoveProduct(string productCode)
    {
        var product = products.FirstOrDefault(p => p.ProductCode == productCode);
        if (product != null)
        {
            products.Remove(product);
        }
    }

    // Hiển thị danh sách sản phẩm và tổng giá trị kho
    public void DisplayProducts()
    {
        foreach (var product in products)
        {
            Console.WriteLine($"Mã sản phẩm: {product.ProductCode}, Tên: {product.ProductName}, Giá bán: {product.Price}, Tồn kho: {product.QuantityInStock}, Tổng giá trị: {product.TotalStockValue()}");
        }
        Console.WriteLine($"Tổng giá trị kho hàng: {CalculateTotalStockValue()}");
    }

    // Hiển thị sản phẩm theo giá bán tăng dần
    public void DisplayProductsByPrice()
    {
        var sortedProducts = products.OrderBy(p => p.Price).ToList();
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.ProductName} - {product.Price}");
        }
    }

    // Hiển thị sản phẩm theo tên (sắp xếp theo từ cuối của tên)
    public void DisplayProductsByName()
    {
        var sortedProducts = products.OrderBy(p => p.ProductName.Split(' ').Last()).ToList();
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.ProductName} - {product.Price}");
        }
    }
}    