#region Bai 1: Tinh so ngay trong tuan va so ngay le
// Console.WriteLine("Nhập ngày bắt đầu (dd/MM/yyyy): ");
// DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

// Console.WriteLine("Nhập ngày kết thúc (dd/MM/yyyy): ");
// DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

// // Tính toán số ngày giữa hai ngày
// TimeSpan difference = endDate - startDate;
// int totalDays = (int)difference.TotalDays;

// // Tính số ngày trong tuần và số ngày lẻ
// int weeks = totalDays / 7;
// int remainingDays = totalDays % 7;

// // Xuất kết quả
// Console.WriteLine($"Số ngày giữa hai ngày là: {totalDays}");
// Console.WriteLine($"Số tuần: {weeks}");
// Console.WriteLine($"Số ngày lẻ: {remainingDays}");

#endregion

#region Bai 2: Tinh tong gia tri don hang sau khi ap dung giam gia
// // input
// // nhap gia tien tra sua 
// // nhap % giam gia
// Console.WriteLine("Moi ban nhap gia tien tra sua");
// string? giaTien = Console.ReadLine();
// Console.WriteLine("Moi ban nhap voucher giam gia")
// string? giamGia = Console.ReadLine();

// // output 
// int tienGiam = 0;
// int tienPhaiTra = 0;

// // process
// int formatGiaTien = Convert.ToInt32(giaTien);
// int formatGiamGia = Convert.ToInt32(giamGia);
// tienGiam = formatGiaTien * formatGiamGia / 100;
// tienPhaiTra = formatGiaTien - tienGiam;

// Console.WriteLine($"So tien giam sau khi ap voucher: {tienGiam}");
// Console.WriteLine($"So tien phai tra sau khi ap voucher: {tienPhaiTra}");

#endregion

#region Bai 3: Chuyen doi tu phut sang gio va phut
// // Nhập số phút từ người dùng
// Console.WriteLine("Nhập số phút: ");
// int totalMinutes = Convert.ToInt32(Console.ReadLine());

// // Tính số giờ và số phút
// int hours = totalMinutes / 60;
// int minutes = totalMinutes % 60;

// // Xuất kết quả
// Console.WriteLine($"{totalMinutes} phút tương đương với {hours} giờ và {minutes} phút.");

#endregion

#region Bai 4: Tinh tong so tien sau khi cong them thue VAT
// // Nhập số tiền gốc
// Console.WriteLine("Nhập số tiền gốc: ");
// double originalAmount = Convert.ToDouble(Console.ReadLine());

// // Nhập tỷ lệ thuế VAT 
// Console.WriteLine("Nhập tỷ lệ thuế VAT: ");
// double vatRate = Convert.ToDouble(Console.ReadLine());

// // Tính tổng số tiền sau khi cộng thêm thuế VAT
// double vatAmount = originalAmount * (vatRate / 100);
// double totalAmount = originalAmount + vatAmount;

// // Xuất kết quả
// Console.WriteLine($"Số tiền gốc: {originalAmount}");
// Console.WriteLine($"Số tiền thuế VAT: {vatAmount}");
// Console.WriteLine($"Tổng số tiền sau khi cộng thêm thuế VAT: {totalAmount}");

#endregion

#region Bai 5: Chuyen doi don vi tien te
// // Nhập số tiền cần chuyển đổi
// Console.WriteLine("Nhập số tiền cần chuyển đổi: ");
// double amount = Convert.ToDouble(Console.ReadLine());

// // Nhập tỷ giá hối đoái
// Console.WriteLine("Nhập tỷ giá hối đoái (1 đơn vị tiền tệ gốc = bao nhiêu đơn vị tiền tệ đích): ");
// double exchangeRate = Convert.ToDouble(Console.ReadLine());

// // Tính toán số tiền sau khi chuyển đổi
// double convertedAmount = amount * exchangeRate;

// // Xuất kết quả
// Console.WriteLine($"{amount} đơn vị tiền tệ gốc tương đương với {convertedAmount} đơn vị tiền tệ đích.");

#endregion

#region Bai 6: Tinh so du sau khi rut tien tu tai khoan
// // Nhập số dư hiện tại
// Console.WriteLine("Nhập số dư hiện tại của tài khoản: ");
// double currentBalance = Convert.ToDouble(Console.ReadLine());

// // Nhập số tiền muốn rút
// Console.WriteLine("Nhập số tiền muốn rút: ");
// double amountToWithdraw = Convert.ToDouble(Console.ReadLine());


//  // Tính số dư sau khi rút tiền
// double newBalance = currentBalance - amountToWithdraw;

//  // Xuất kết quả
// Console.WriteLine($"Số dư sau khi rút tiền là: {newBalance}");

#endregion

#region Bai 7: Tinh toc do trung binh
// // Nhập quãng đường (km)
// Console.WriteLine("Nhập quãng đường đã đi (km): ");
// double distance = Convert.ToDouble(Console.ReadLine());

// // Nhập thời gian (giờ)
// Console.WriteLine("Nhập thời gian đã sử dụng (giờ): ");
// double time = Convert.ToDouble(Console.ReadLine());

// // Tính tốc độ trung bình
// double averageSpeed = distance / time;

// // Xuất kết quả
// Console.WriteLine($"Tốc độ trung bình là: {averageSpeed} km/h");

#endregion

#region Bai 9: Chuyen doi tu km/h sang m/s
// // Nhập tốc độ từ km/h
// Console.WriteLine("Nhập tốc độ (km/h): ");
// double speedKmH = Convert.ToDouble(Console.ReadLine());

// // Chuyển đổi sang m/s
// double speedMs = speedKmH / 3.6;

// // Xuất kết quả
// Console.WriteLine($"{speedKmH} km/h tương đương với {speedMs} m/s."); 

#endregion

#region Bai 8: Tinh ty le phan tram
// // Nhập giá trị phần
// Console.WriteLine("Nhập giá trị phần: ");
// double partValue = Convert.ToDouble(Console.ReadLine());

// // Nhập giá trị tổng
// Console.WriteLine("Nhập giá trị tổng: ");
// double totalValue = Convert.ToDouble(Console.ReadLine());

// // Tính tỷ lệ phần trăm
// double percentage = (partValue / totalValue) * 100;

// // Xuất kết quả
// Console.WriteLine($"Tỷ lệ phần trăm là: {percentage}%");

#endregion

#region Bai 10: Tinh luong calo tieu thu
// // Nhập loại hoạt động
// Console.WriteLine("Chọn loại hoạt động:");
// Console.WriteLine("1. Chạy bộ (10 calo/phút)");
// Console.WriteLine("2. Đi bộ (5 calo/phút)");
// Console.WriteLine("3. Bơi lội (7 calo/phút)");
// Console.WriteLine("Nhập số tương ứng: ");
// int activityChoice = Convert.ToInt32(Console.ReadLine());

// // Nhập thời gian hoạt động (phút)
// Console.WriteLine("Nhập thời gian hoạt động (phút): ");
// double duration = Convert.ToDouble(Console.ReadLine());

// // Khai báo biến để lưu trữ số calo tiêu thụ
// double caloriesBurned = 0;

// // Xuất kết quả
// Console.WriteLine($"Lượng calo tiêu thụ là: {caloriesBurned} calo.");
    
#endregion