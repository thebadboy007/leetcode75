public class TwoSumSolution{
    public static void Main(string[] args)
    {
        int nums[] = {2,5,7,8,10};
        int target = 9;
        int result = twoSum(nums, target);
        Console.Writeline($"Indexes:{result[0]},{result[1]}");

        public static twoSum(int nums[], int target)
        {
            var numToInsert =  new Dictonary<int int>();

            for(int i=0; i< nums.length; i++){
                int complement = target - nums[i];

                if(numToInsert.TryGetValue(complement, out int index))
                {
                    return new int[]{index, i};

                }
                numToInsert[nums[i]] = i;
            }
            throw new ArgumentException("No Two sum solution");
        }
    }
}
