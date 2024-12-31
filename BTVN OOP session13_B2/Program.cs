using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        InventoryManager manager = new InventoryManager();
        string productFilePath = "products.json";
        string orderFilePath = "orders.json";
        
        manager.LoadDataFromJson(productFilePath, orderFilePath);

        // Thêm sản phẩm
        manager.AddProduct(new Product { ProductCode = "P001", ProductName = "Bánh Trung Thu", Price = 100000, QuantityInStock = 100 });
        manager.AddProduct(new Product { ProductCode = "P002", ProductName = "Bánh Quy", Price = 50000, QuantityInStock = 200 });

        // Hiển thị sản phẩm
        manager.DisplayProducts();

        // Tìm kiếm sản phẩm theo tên
        var product = manager.FindProductByName("Bánh Trung Thu");
        if (product != null)
        {
            Console.WriteLine($"Tìm thấy sản phẩm: {product.ProductName}, Giá: {product.Price}");
        }

        // Cập nhật sản phẩm
        manager.UpdateProduct("P001", 120000, 150);

        // Xóa sản phẩm
        manager.RemoveProduct("P002");

        // Hiển thị sản phẩm theo giá bán tăng dần
        manager.DisplayProductsByPrice();

        // Hiển thị sản phẩm theo tên
        manager.DisplayProductsByName();

        // Thêm đơn hàng
        manager.AddOrder(new Order { OrderCode = "O001", ProductCode = "P001", QuantitySold = 10, CustomerName = "Nguyen Thi Mai", IsDelivered = false });
        
        // Cập nhật đơn hàng
        manager.UpdateOrderStatus("O001", true);

        // Hiển thị đơn hàng
        manager.DisplayOrders();

        // Lưu dữ liệu vào file
        manager.SaveDataToJson(productFilePath, orderFilePath);
    }
}