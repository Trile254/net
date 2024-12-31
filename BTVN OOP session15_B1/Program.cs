using Newtonsoft.Json;
// BÀI TẬP KẾ THỪA - ĐA HÌNH
// • Bài tập: Hệ thống thanh toán đa phương thức
// • Tạo interface IThanh Toan với phương thức:
// • ThanhToan(double soTien): Thực hiện thanh toán cho một số tiền cụ thể. • Xây dựng các lớp kế thừa từ IThanhToan:
// • Thanh ToanTienMat: Thực hiện thanh toán bằng tiền mặt.
// • ThanhToanBangThe: Thực hiện thanh toán bằng thẻ.
// • ThanhToanOnline: Thực hiện thanh toán online qua mạng.
// o Xử lý thanh toán cho từng lớp:
// * Thanh toán bằng tiền mặt:
// • Không yêu cầu thêm bước xác nhận.
// • Thanh toán bằng thẻ:
// Yêu cầu người dùng nhập mã PIN để xác nhận giao dịch.
// • Thanh toán online:
// • Yêu cầu xác nhận qua mã OTP gửi tới người dùng.
// • Menu chọn chức năng:
// • Hiển thị các lựa chọn cho người dùng:
// • Chọn phương thức thanh toán.
// • Nhập số tiền cần thanh toán.
// Gọi phương thức Thanh Toan của lớp tương ứng dựa trên lựa chọn.
// - Quy trình cụ thể:
// • Hiển thị menu cho người dùng:
// • Thanh toán bằng tiền mặt.
// • Thanh toán bằng thẻ.
// • Thanh toán online.
// • Xem lịch sử giao dịch.
// • Thoát.
// • Nhận lựa chọn từ người dùng.
// • Dựa vào lựa chọn, thực hiện:
// • Nhập số tiền cần thanh toán.
// • Nếu chọn thanh toán bằng thẻ, yêu cầu nhập mã PIN (Tự set mã ví dụ: 9999) hoặc làm thêm tính năng đăng ký tài khoản.
// • Nếu chọn thanh toán online, yêu cầu nhập mã OTP (Tự set mã ví dụ 1234) hoặc làm thêm tính năng quản lý .
// • Thông báo kết quả thanh toán (thành công/thất bại).
// • Lưu thông tin giao dịch vào lịch sử.
// • Lịch sử giao dịch:
// • Lưu các giao dịch vào file JSON.
// • Cho phép người dùng xem lại lịch sử giao dịch qua menu.
public interface IThanhToan
{
    void ThanhToan(double soTien);
}

public class ThanhToanTienMat : IThanhToan
{
    public void ThanhToan(double soTien)
    {
        Console.WriteLine($"Đã thanh toán {soTien} VNĐ bằng tiền mặt.");
    }
}

public class ThanhToanBangThe : IThanhToan
{
    private const string MaPIN = "9999"; // Mã PIN mặc định cho thẻ

    public void ThanhToan(double soTien)
    {
        Console.Write("Nhập mã PIN: ");
        string pin = Console.ReadLine();

        if (pin == MaPIN)
        {
            Console.WriteLine($"Đã thanh toán {soTien} VNĐ bằng thẻ.");
        }
        else
        {
            Console.WriteLine("Mã PIN không đúng! Thanh toán thất bại.");
        }
    }
}

public class ThanhToanOnline : IThanhToan
{
    private const string OTP = "1234"; // OTP mặc định

    public void ThanhToan(double soTien)
    {
        Console.Write("Nhập mã OTP: ");
        string otp = Console.ReadLine();

        if (otp == OTP)
        {
            Console.WriteLine($"Đã thanh toán {soTien} VNĐ qua online.");
        }
        else
        {
            Console.WriteLine("Mã OTP không đúng! Thanh toán thất bại.");
        }
    }
}

public class LichSuGiaoDich
{
    public string PhuongThuc { get; set; }
    public int SoTien { get; set; }
    public string ThoiGian { get; set; }
}

public class SystemThanhToan
{
    private static List<LichSuGiaoDich> lichSu = new List<LichSuGiaoDich>();
    private static string filePath = "lichsu.json";

    public static void LuuLichSuGiaoDich(LichSuGiaoDich giaoDich)
    {
        lichSu.Add(giaoDich);
        string json = JsonConvert.SerializeObject(lichSu, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static void XemLichSu()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            List<LichSuGiaoDich> lichSuGiaoDich = JsonConvert.DeserializeObject<List<LichSuGiaoDich>>(json);

            Console.WriteLine("Lịch sử giao dịch:");
            foreach (var item in lichSuGiaoDich)
            {
                Console.WriteLine($"Phương thức: {item.PhuongThuc}, Số tiền: {item.SoTien} VNĐ, Thời gian: {item.ThoiGian}");
            }
        }
        else
        {
            Console.WriteLine("Chưa có lịch sử giao dịch.");
        }
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Thanh toán bằng tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán online");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn phương thức thanh toán (1-5): ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 5) break;

            Console.Write("Nhập số tiền cần thanh toán: ");
            int soTien = Convert.ToInt32(Console.ReadLine());

            IThanhToan thanhToan = null;
            string phuongThuc = string.Empty;

            switch (choice)
            {
                case 1:
                    thanhToan = new ThanhToanTienMat();
                    phuongThuc = "Tiền mặt";
                    break;
                case 2:
                    thanhToan = new ThanhToanBangThe();
                    phuongThuc = "Thẻ";
                    break;
                case 3:
                    thanhToan = new ThanhToanOnline();
                    phuongThuc = "Online";
                    break;
                case 4:
                    XemLichSu();
                    continue;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    continue;
            }

            thanhToan.ThanhToan(soTien);

            // Lưu lịch sử giao dịch
            LichSuGiaoDich giaoDich = new LichSuGiaoDich
            {
                PhuongThuc = phuongThuc,
                SoTien = soTien,
                ThoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
            LuuLichSuGiaoDich(giaoDich);

            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }
    }
}