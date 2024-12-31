class TruongNhom: NhanVien {
    
    public string MaQLNhom;

    public string getMaNV() {
        return this.MaNV;
    }

    public override double tinhLuong() {
        double luongCoBan = base.tinhLuong(); // ke thua lai phuong thuc tinhLuong()
        return luongCoBan + 1.5*luongCoBan;
    }
}