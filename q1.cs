internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive number: ");

        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter " + number + " positive numbers: ");

        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(" ");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) Console.WriteLine(numbers[i]);
            else continue;
        }
    }
}