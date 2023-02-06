//Initializing and displaying the array.
Console.Write("Here are the numbers in the array: ");
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
foreach (int num in nums)
{
    Console.Write(num + ", ");
}
//Creating variables and storing variables.
int minValue = nums.Min();
int maxValue = nums.Max();
int maxMinusValue = maxValue - 10000;
IEnumerable<int> smallValuesBetween = nums.Where(x => x > 10 && x < 100);
IEnumerable<int> largeValuesBetween = nums.Where(x => x >= 100000 && x <= 999999);
int evenCount = nums.Where(x => x % 2 == 0).Count();

//Dispalying values for each question. 
Console.WriteLine("\n");

Console.Write("Minimum value in the array: " + minValue);
Console.WriteLine("\n");

Console.Write("Maximum value in the array: " + maxValue);
Console.WriteLine("\n");

Console.Write("The value of the Maximum - 10,000: " + maxMinusValue);
Console.WriteLine("\n");

Console.Write("Numbers in the array between 10 and 100: ");
foreach (int num in smallValuesBetween)
{
    Console.Write(num + ", ");
}
Console.WriteLine("\n");

Console.Write("Numbers in the array between 100,000 and 999,999 (inclusive): ");
foreach (int num in largeValuesBetween)
{

    Console.Write(num + ", ");
}
Console.WriteLine("\n");

Console.Write("Count of all even numbers in the array: " + evenCount);
Console.WriteLine("\n");