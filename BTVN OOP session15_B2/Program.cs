internal class Program
{
    static List<SanPham> danhSachSanPham = new List<SanPham>();

    private static void Main(string[] args)
    {
        //         BÀI TẬP KẾ THỪA - ĐA HÌNH
        // Bài tập: Hệ thống quản lý bán hàng với menu và đa hình
        // - Mô tả bài toán:
        // Một cửa hàng cần quản lý các sản phẩm thuộc nhiều loại khác nhau như: Điện tử, Thời trang, và Thực phẩm. Cửa hàng cung cấp một hệ thống cho phép thêm sản phẩm, hiển thị sản phẩm, tính tổng doanh thu, và quản lý sản phẩm thông qua menu.
        // o Yêu cầu:
        // Tạo lớp trừu tượng SanPham với các thuộc tính và phương thức:
        // * string MaSanPham: Mã sản phẩm.
        // * string TenSanPham: Tên sản phẩm.
        // = double GiaGoc: Giá gốc của sản phẩm.
        // = abstract double TinhGiaBan(): Phương thức trừu tượng để tính giá bán sản phẩm.
        // = virtual void HienThiThongTin(): Hiển thị thông tin sản phẩm.
        // • Tạo các lớp kế thừa từ SanPham:
        // • DienTu: Cộng thêm thuế bảo hành vào giá gốc.
        // • ThoiTrang: Áp dụng giảm giá theo mùa.
        // • ThucPham: Cộng thêm phí vận chuyển vào giá gốc.
        // • Quản lý danh sách sản phẩm thông qua menu:
        // • Thêm sản phẩm vào danh sách.
        // * Hiển thị danh sách sản phẩm.
        // • Tính tổng doanh thu dự kiến.
        // • Xóa sản phẩm khỏi danh sách theo mã.
        // • Thoát chương trình.
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu");
            Console.WriteLine("4. Xóa sản phẩm theo mã");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            int chucNang = Convert.ToInt32(Console.ReadLine());

            switch (chucNang)
            {
                case 1:
                    ThemSanPham();
                    break;
                case 2:
                    HienThiDanhSachSanPham();
                    break;
                case 3:
                    TinhTongDoanhThu();
                    break;
                case 4:
                    XoaSanPham();
                    break;
                case 5:
                    return; // Thoát chương trình
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
            Console.WriteLine("\nNhấn Enter để tiếp tục...");
            Console.ReadLine();
        }
    }

    // Thêm sản phẩm vào danh sách
    static void ThemSanPham()
    {
        Console.WriteLine("Chọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");
        Console.Write("Chọn: ");
        int loaiSanPham = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập mã sản phẩm: ");
        string maSanPham = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string tenSanPham = Console.ReadLine();
        Console.Write("Nhập giá gốc: ");
        int giaGoc = Convert.ToInt32(Console.ReadLine());

        switch (loaiSanPham)
        {
            case 1:
                Console.Write("Nhập thuế bảo hành: ");
                int thueBaoHanh = Convert.ToInt32(Console.ReadLine());
                danhSachSanPham.Add(new DienTu(maSanPham, tenSanPham, giaGoc, thueBaoHanh));
                break;
            case 2:
                Console.Write("Nhập giảm giá mùa: ");
                int giamGiaMuaMua = Convert.ToInt32(Console.ReadLine());
                danhSachSanPham.Add(new ThoiTrang(maSanPham, tenSanPham, giaGoc, giamGiaMuaMua));
                break;
            case 3:
                Console.Write("Nhập phí vận chuyển: ");
                int phiVanChuyen = Convert.ToInt32(Console.ReadLine());
                danhSachSanPham.Add(new ThucPham(maSanPham, tenSanPham, giaGoc, phiVanChuyen));
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }

    // Hiển thị danh sách sản phẩm
    static void HienThiDanhSachSanPham()
    {
        if (danhSachSanPham.Count == 0)
        {
            Console.WriteLine("Danh sách sản phẩm trống.");
            return;
        }

        foreach (var sp in danhSachSanPham)
        {
            sp.HienThiThongTin();
            Console.WriteLine($"Giá bán: {sp.TinhGiaBan()}\n");
        }
    }

    // Tính tổng doanh thu dự kiến
    static void TinhTongDoanhThu()
    {
        int tongDoanhThu = 0;
        foreach (var sp in danhSachSanPham)
        {
            tongDoanhThu += sp.TinhGiaBan();
        }
        Console.WriteLine($"Tổng doanh thu dự kiến: {tongDoanhThu}");
    }

    // Xóa sản phẩm theo mã
    static void XoaSanPham()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        string maSanPham = Console.ReadLine();
        var sanPhamCanXoa = danhSachSanPham.Find(sp => sp.MaSanPham == maSanPham);

        if (sanPhamCanXoa != null)
        {
            danhSachSanPham.Remove(sanPhamCanXoa);
            Console.WriteLine("Sản phẩm đã được xóa.");
        }
        else
        {
            Console.WriteLine("Sản phẩm không tìm thấy.");
        }
    }
}