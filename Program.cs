internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive number: ");

        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter " + number + " positive numbers: ");

        string numbers = Convert.ToString(Console.ReadLine());

        numbers = numbers.Replace(" ", "");

        Console.WriteLine(numbers);

        foreach (char i in numbers)
        {
            if (i % 2 == 0) Console.WriteLine(i);
            else continue;
        }
    }
}