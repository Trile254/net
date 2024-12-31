internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> lst = new List<int>{2, 7, 9, 11, 15};
        //                            0  1  2  3   4
        int target = 26;
        Console.WriteLine("Bai 1: Tim 2 so de tong 2 so bang voi target");
        if(TwoSum.twoSum(lst, target) == null) {
            Console.WriteLine("Khong co hai so nao co tong bang target");
        } else {
            List<int> indexes = TwoSum.twoSum(lst, target);
            Console.WriteLine($"Chi so 2 so co tong bang target la: {string.Join(',', indexes)} ");
        }

        Console.WriteLine("Cach 2: Dung dictionary")
        if(TwoSum.twoSum(lst, target) == null) {
            Console.WriteLine("Khong co hai so nao co tong bang target");
        } else {
            List<int> indexes = TwoSum.twoSum(lst, target);
            Console.WriteLine($"Chi so 2 so co tong bang target la: {string.Join(',', indexes)} ");
        }  

        #region  Khai niem ve cach luu tru bien trong may tinh
        int number1 = 10;
        int number2 = number1;
        number1 = 20;
        Console.WriteLine($"number1={number1}, number2={number2}");
        #endregion  
    }
}        