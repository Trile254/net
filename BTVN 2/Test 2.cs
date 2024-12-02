internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region B1: Tính tổng các số trong mảng
        int[] IstNumber1 = {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
        
        // Tính tổng các phần tử trong mảng
        int sum = IstNumber1.Sum();
        
        Console.WriteLine("Tổng các số trong mảng: " + sum);
        #endregion

        #region B2: Tìm hai số trong mảng có tổng bằng giá trị target
        int[] IstNumber2 = {2, 7, 11, 15};
        int target = 9;
        
        for (int i = 0; i < IstNumber2.Length; i++)
        {
            for (int j = i + 1; j < IstNumber2.Length; j++)
            {
                if (IstNumber2[i] + IstNumber2[j] == target)
                {
                    Console.WriteLine("Vị trí của 2 số có tổng bằng " + target + ": [" + i + ", " + j + "]");
                    return;
                }
            }
        }
        
        Console.WriteLine("Không tìm thấy cặp số nào có tổng bằng " + target);
        #endregion

        #region B3: Loại bỏ các phần tử trùng lặp từ mảng đã sắp xếp
        int[] IstNumber3 = {1, 1, 2, 2, 2, 3, 4, 4, 5};
        
        int uniqueCount = RemoveDuplicates(IstNumber3);
        
        Console.WriteLine("Chiều dài mảng sau khi loại bỏ trùng lặp: " + uniqueCount);
        #endregion

        #region B4: Tìm phần tử xuất hiện nhiều nhất trong mảng
       int[] IstNumber = {1, 1, 1, 2, 2, 3};
        int k = 2;
        
        var result = FindMostFrequentElements(IstNumber, k);
        
        Console.WriteLine("Các phần tử xuất hiện nhiều nhất: " + string.Join(", ", result));
        #endregion

        #region B5: Tìm thời điểm mua và bán cổ phiếu để đạt lợi nhuận cao nhất
        int[] prices = {7, 1, 5, 3, 6, 4};
        
        int maxProfit = MaxProfit(prices);
        
        Console.WriteLine("Lợi nhuận cao nhất có thể đạt được: " + maxProfit);
        #endregion
    }
}