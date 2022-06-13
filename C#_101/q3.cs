internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive number: ");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter " + n + " words: ");

        string[] y = new string[n];

        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            y[i] = x;
        }

        Console.WriteLine("Your words are below!");
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(y[i]);
        }
    }
}