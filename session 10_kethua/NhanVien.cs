class NhanVien {
    protected string MaNV;
    private string HoTen {get; set;}
    // muc dich dung getter va setter de truy cap vao cac thuoc tinh private
    public string NgaySinh;
    public int tuoi;
    public double luong;
    public string gioiTinh;

    // overload: nap chong phuong thuc
    // override: ghi de phuong thuc cua class cha
    public virtual double tinhLuong() {
        return 1000;
    }
}