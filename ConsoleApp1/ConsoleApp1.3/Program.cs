class Program 
{
    static void Main()
    {
        int[] nums1 = {1, 2, 3, 4 };
        int[] nums2 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        int[] nums3 = {1, 2, 3, 1};
                
        Console.WriteLine(Duplicate(nums1)); 
        Console.WriteLine(Duplicate(nums2)); 
        Console.WriteLine(Duplicate(nums3)); 
    }
    
    static bool Duplicate(int[] nums) 
    {
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 1; i++) 
        {
            if(nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        
        return false;
    }
}