class TwoSum {

    public static List<int> twoSum(List<int> lst, int target){
        for(int i = 0; i < lst.Count - 1; i++){
            for(int j = i + 1; j < lst.Cont; j++) {
                if(lst[i] + lst[j] == target){
                    return new List<int>{i, j};
                }
            }
        }
        return null; // khong tim duoc 2 so thi tra ve null
    }

    public static List<int> twoSumDictionary(List<int> lst, int target){
        // khai bao Dictionary de danh dau tung so trong danh sach lst
        // key - luu gia tri tung phan tu cua mang
        // value - luu chi so cua phan tu tuong ung
        twoSumDictionary<int, int> seenNumbers = new Dictionary<int, int>();
        for(int i = 0; i < lst.Count; i++){
            int completion = target - lst[i];
            if(seenNumbers.ContainsKey(completion)){
                return new List<int>{seenNumbers[completion], i};            
            } else {
                // neu completion khong nam trong dic => add vao dic de danh dau 
                seenNumbers.Add(lst[i], i);
            }
        }
        return null;
    }
    
}