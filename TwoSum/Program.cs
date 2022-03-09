//TwoSum Function
static int[] TwoSum(int[] nums, int target)
{
    for(var i = 0 ; i < nums.Length - 1 ; i++)
    {
        for(var j = i + 1 ; j < nums.Length ; j++)
        {
            if (nums[i] + nums[j] == target)
                return new[] { i, j };
        }
    }
    return Array.Empty<int>();
}

int target = 9;
int[] nums = { 2, 7, 11, 15 };
int[] result = TwoSum(nums, target);

//Display Result
Console.Write("Numbers: ");
foreach(int number in nums){
    //prints the number
    Console.Write(number + ", ");
}

Console.WriteLine("\nTarget: " + target);

Console.Write("==============\nOutput: ");
foreach(int number in result){
    //prints the number
    Console.Write(number + ", ");
}
