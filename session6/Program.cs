internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World 6!");
        #region kiem tra so nguyen to
        // Console.WriteLine("Moi ban nhap so: ");
        // string? number = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatNumber);
        // if (isPrime == true){
        //     Console.WriteLine($"So {number} la so nguyen to");
        // } else {
        //     Console.WriteLine($"So {number} khong la so nguyen to");
        // }
        #endregion

        #region In ra tam giac vuong co chieu cao n nhap tu ban phim
        // Console.WriteLine("Moi ban nhap chieu cao: ");
        // string? height = Console.ReadLine();
        // int formatHeight = Convert.ToInt32(height);
        // Method.printSquareTriangle(formatHeight);
        // // for (int i = 1; i <= formatHeight; i++) {
        // //     Method.printRowTriangle(i);
        // // }
        #endregion

        #region Collection trong C#
        // data structure
        // List
        List<int> numbers = new List<int>();

        // define gia tri ban dau
        List<string> names = new List<string> {"Phuong", "Duc", "Linh", "Hung", "Tri"};
        //                            index        0       1       2       3      4
        //                         reverseIndex   ^5       ^4      ^3     ^2      ^1
        Console.WriteLine($"Phan tu thu 2 la: {names[2]}");
        Console.WriteLine ($"Phan tu nghich dao la: {names[^3]}");
        // Console.WriteLine(names);
        // Luu y: WriteLine chi in duoc gia tri cho nhung kieu du lieu nguyen thuy: int, float, double,string,...
        // Con kieu du lieu Collection thi chi in ra dia chi vung nho cua bien do
        Console.Write(String.Join(", ", names));

        // bai tap lam quen: nhap n tu ban phim. Sau do nhap n phan tu va xuat ra n phan tu
        Console.WriteLine("Moi ban nhap so luong phan tu: ");
        string? number = Console.ReadLine();
        int formatNumber = Convert.ToInt32(number);
        // tao bien chua danh sach phan tu
        List<int> listNumbers = new List<int>();
        for(int i = 0; i < formatNumber; i++){
            // C1: dung insert
            Console.WriteLine($"Nhap phan tu thu {i+1}");
            string? item = Console.ReadLine();
            int formatItem = Convert.ToInt32(item);
            listNumbers.Insert(i, formatItem);
        }
        // in list phan tu ra ngoai man hinh
        // se co 2 cach duyet phan tu: for hoac foreach
        // C1: for
        Console.WriteLine("Danh sach phan tu sau khi nhap la: ");
        for(int i = 0; i < listNumbers.Count; i++){ // listNumbers.Count => 5
            Console.WriteLine(listNumbers[i]);
        }

        // C2: dung foreach
        Console.WriteLine("Danh sach phan tu dung foreach: ");
        foreach(int item in listNumbers) {
            Console.WriteLine(item);
        }
        #endregion
    }
}        




