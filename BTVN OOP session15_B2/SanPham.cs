abstract class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public int GiaGoc { get; set; }

    // Constructor để khởi tạo các thuộc tính
    public SanPham(string maSanPham, string tenSanPham, int giaGoc)
    {
        MaSanPham = maSanPham;
        TenSanPham = tenSanPham;
        GiaGoc = giaGoc;
    }

    // Phương thức trừu tượng tính giá bán
    public abstract int TinhGiaBan();

    // Phương thức hiển thị thông tin sản phẩm
    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã Sản Phẩm: {MaSanPham}");
        Console.WriteLine($"Tên Sản Phẩm: {TenSanPham}");
        Console.WriteLine($"Giá Gốc: {GiaGoc}");
    }
}