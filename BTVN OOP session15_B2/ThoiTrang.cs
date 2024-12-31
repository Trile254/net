class ThoiTrang : SanPham
{
    public int GiamGiaMuaMua { get; set; }  // Giảm giá theo mùa

    public ThoiTrang(string maSanPham, string tenSanPham, int giaGoc, int giamGiaMuaMua)
        : base(maSanPham, tenSanPham, giaGoc)
    {
        GiamGiaMuaMua = giamGiaMuaMua;
    }

    // Tính giá bán sản phẩm thời trang (bao gồm giảm giá theo mùa)
    public override int TinhGiaBan()
    {
        return GiaGoc - GiamGiaMuaMua;
    }

    // Hiển thị thông tin sản phẩm thời trang
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Giảm Giá Mùa: {GiamGiaMuaMua}");
    }
}