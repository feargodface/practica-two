class Program
{
    static void Main()
    {
        int[] candidates1 = {2, 5, 2, 1, 2};
        int target1 = 5;
        
        int[] candidates2 = {10, 1, 2, 7, 6, 1, 5};
        int target2 = 8;
        
        List<List<int>> result1 = CombinationSum2(candidates1, target1);
        List<List<int>> result2 = CombinationSum2(candidates2, target2);
        
        Result(result1);
        Result(result2);
    }
    
    static List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        FindCombinations(candidates, target, 0, new List<int>(), result);
        return result;
    }
    
    static void FindCombinations(int[] candidates, int target, int start, List<int> current, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }
        
        for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1]) continue; 
            current.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
    
    static void Result(List<List<int>> result)
    {
        Console.WriteLine("[");
        foreach (var list in result)
        {
            Console.WriteLine($"[{string.Join(",", list)}],");
        }
        Console.WriteLine("]");
    }
}