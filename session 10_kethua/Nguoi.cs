class Nguoi {
    public string ID;
    public string ten;
    public string ngaySinh;
    public string gioiTinh;
    public string email;

    public Nguoi(string ID, string ten, string ngaySinh, string gioiTinh, string email) {
        this.ID = ID
        this.ten = ten;
        this.ngaySinh = ngaySinh;
        this.gioiTinh = gioiTinh;
        this.email = email;
    }

    public virtual void inThongTin() {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Ten: {ten}");
        Console.WriteLine($"Ngay sinh: {ngaySinh}");
        Console.WriteLine($"Gioi tinh: {gioiTinh}");
        Console.WriteLine($"email: {email}");
    }
}