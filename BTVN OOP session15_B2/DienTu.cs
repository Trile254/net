class DienTu : SanPham
{
    public int ThueBaoHanh { get; set; }  // Thêm thuế bảo hành

    public DienTu(string maSanPham, string tenSanPham, int giaGoc, int thueBaoHanh)
        : base(maSanPham, tenSanPham, giaGoc)
    {
        ThueBaoHanh = thueBaoHanh;
    }

    // Tính giá bán sản phẩm điện tử (bao gồm thuế bảo hành)
    public override int TinhGiaBan()
    {
        return GiaGoc + ThueBaoHanh;
    }

    // Hiển thị thông tin sản phẩm điện tử
    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Thuế Bảo Hành: {ThueBaoHanh}");
    }
}