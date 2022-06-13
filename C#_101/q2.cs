internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter a number: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Please enter " + n + " numbers: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine(" ");
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % m == 0) Console.WriteLine(numbers[i]);
            else continue;
        }
    }
}