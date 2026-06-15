public class FindDuplicateSolution
{
    public static void RunExample()
    {
        int[] nums = { 1, 3, 4, 2, 2 };
        float duplicate = findDuplicate(nums);
        Console.WriteLine($"Duplicate number: {duplicate}");
    }

    public static float findDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (var item in nums)
        {
            if (seen.Contains(item))
            {
                return item;
            }
            seen.Add(item);
        }
        throw new ArgumentException("No duplicate found");
    }
}