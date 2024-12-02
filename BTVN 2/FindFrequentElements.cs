class FindMostFrequentElements {
public static List<int> FindMostFrequentElements(int[] nums, int k)
    {
        var frequencyMap = nums.GroupBy(x => x)
                               .OrderByDescending(g => g.Count())
                               .Take(k)
                               .Select(g => g.Key)
                               .ToList();
        
        return frequencyMap;
    }
}