Console.WriteLine("Hello, World 3!");

#region Bai tap so 2
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

#region
// nhap con so nguyen tu ban phim. In ra so do la so le hay so chan 
// input
Console.WriteLine("Moi ban nhapso: ");
string? number = Console.ReadLine ();
int formatNumber = Convert.ToInt32(number);
if(formatNumber % 2 == 0) {
    Console.WriteLine($"So {number} la so chan");
} else {
    Console.WriteLine($"so{number} la so le" );
}

// output

// process

// truthy:
// int day = 5;
// if (day != 0) {
//     // >,<,>=,<=,!=
//     Console.WriteLine("Truthy");
// }

// nhap diem trung binh cua hoc sinh. Xuat ra hoc luc cua hoc sinh do
// >=9: Xuat sac
// 8 <= diem <9: gioi
// 6.5 <= diem < 8: kha
// 5 <= diem < 6.5: trung binh
// 3.5 <= diem < 5: yeu
// qua kem
// string? diemTrungBinh = Console.ReadLine();
// double formatDiem + Convert.ToDouble(diemTrungBinh);
// if(formatDiem >= 9) {
//     Console.WriteLine("Xuat sac");
// } else if (8 <= formatDiem && formatDiem < 9) {
//     Console.WriteLine("Gioi");
// } else if (6.5 <= formatDiem && formatDiem < 8){
//     Console.WriteLine("Kha");
// } else if (5 <= formatDiem && formatDiem < 6.5){
//     Console.WriteLine("Trung Binh");
// } else if (3.5 <= formatDiem && formatDiem < 5){
//      Console.WriteLine("Yeu");
// }else {
    //     Console.WriteLine("Qua Kem");
    // }    
#endregion

#region Nhap so co 3 chu so va tinh tong 3 chu so do 
string? number = Console.ReadLine();
int formatNumber = Convert.ToInt32(number);
if(formatNumber >= 100 && formatNumber < 1000) {
    // 987 
    // 9: hunderd, 8: tens, 7: unit
    int units = formatNumber % 10; // => 7
    int tens = (formatNumber % 100) / 10; // => 8
    int hunderds = formatNumber/ 100;

    int sum = units + tens + hunderds;
    Console.WriteLine($"Tong cac chu so co 3 chu so la: {sum}");
} else {
    Console.WriteLine("Day khong phai la so co 3 chu so");
}
#endregion

#region 
// switch...case
//c1: dung switch...case
// nhap so co trong khoang tu 1 den 10. Doc so
string? number2 = Console.ReadLine();
int formatNumber2 = Conver.ToInt32(number2);
switch (formatNumber2)
{
    case 1:
        Console.WriteLine("So 1");
        break;
    case 2:  
        Console.WriteLine("So 2");
        break;  
    case 3:
        Console.WriteLine("So 3");
        break;
    case 4:
        Console.WriteLine("So 4");
        break;
    case 5:
        Console.WriteLine("So 5");
        break;   
    default:
        Console.WriteLine("So 10");
        break;    
}

#endregion