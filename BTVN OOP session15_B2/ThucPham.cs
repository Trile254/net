class ThucPham : SanPham
{
    public int PhiVanChuyen { get; set; }  // Phí vận chuyển

    public ThucPham(string maSanPham, string tenSanPham, int giaGoc, int phiVanChuyen)
        : base(maSanPham, tenSanPham, giaGoc)
    {
        PhiVanChuyen = phiVanChuyen;
    }

    // Tính giá bán sản phẩm thực phẩm (bao gồm phí vận chuyển)
    public override int TinhGiaBan()
    {
        return GiaGoc + PhiVanChuyen;
    }

    // Hiển thị thông tin sản phẩm thực phẩm
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Phí Vận Chuyển: {PhiVanChuyen}");
    }
}