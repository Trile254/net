// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

#region Hoc phep toan co ban
// // hoc +,-,*,/ (chia lay phan nguyen), % (chia lay phan du)
// // khai bao bien 
// int add  = 5 + 10;
// Console.WriteLine($"Ket qua cong hai so 5 va 10 la: {add}");

// int minus = 1231231 - 34546;
// Console.WriteLine($"Ket qua tru hai so 1231231 va 34546 la: {minus}");

// double devide = 5 / 2;
// Console.WriteLine($"Ket qua chia lay phan nguyen haiso 5 va 2 la: {devide}");

#endregion 

#region numberic toan tu

// int cong = 0; // dinh nghia bien cong co gia tri mac dinh 0
// cong += 10;
// Console.WriteLine($"Numberic toan tu cong: {cong}");

// int nhan = 1;
// nhan *= 100;
// Console.WriteLine($"Numberic toan tu nhan:{nhan}");
#endregion

#region ep kieu du lieu
// // Convert
// // nhap du lieu tu ban phim => ReadLine (string)
// Console.WriteLine("Moi ban nhap so:");
// string number = Console.ReadLine();

// int convertNumber = Convert.ToInt32(number);
// int sum = convertNumber + 1;

// Console.WriteLine($"value number: {sum}");
#endregion

#region Tinh chi so BMI
// // INPUT
// // Chieu cao va can nang duoc nhap tu ban phim
// Console.WriteLine("Moi ban nhap chieu cao (m)");
// string chieuCao = Console.ReadLine();
// // convert string -> double
// double formartChieuCao = Convert.ToDouble(chieuCao);

// Console.WriteLine("Moi ban nhap can nang(kg)");
// string canNang = Console.ReadLine();
// double formartCanNang = Convert.ToDouble(canNang);

// // OUTPUT
// // in ra chi so BMI
// //khoi tao bien bmi de luu gia tri BMI
// double bmi = 0.0;

// //PROCESS
// // BMI = (can nang) / (chieu cao)*(can nang)
// bmi = formartCanNang / (formartChieuCao*formartCanNang);
// Console.WriteLine($"Chi so BMI cua ban la: {bmi}");

#endregion

#region Tinh chu vi va dien tich hinh tron
// // input
// // B1: Nhap ban kinh tu ban phim
// Console.WriteLine("moi ban nhap ban kinh hinh tron");
// string banKinh = Console.ReadLine();
// //B2: Convrt kieu du lieu string -> double cho ban kinh
// double formartBanKinh = Convert.ToDouble(banKinh);

// //output
// double chuVi = 0.0;
// double dienTich = 0.0;

// // process
// // chu vi = 2*pi*banKinh
// // dien tich = pi*banKinh*banKinh
// double PI = Math.PI; // dung hang so PI co san cua thu vien Math trong C#
// chuVi = 2* PI * formartBanKinh;
// dienTich = PI * formartBanKinh * formartBanKinh;
// Console.WriteLine($"chu vi hinh tron la: {chuVi}");
// Console.WriteLine($"Dien tich hinh tron la: {dienTich}");

#endregion

