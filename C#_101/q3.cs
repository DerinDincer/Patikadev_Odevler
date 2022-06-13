/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

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
        
        for (int i = n-1; i >= 0; i--)
        {
            Console.WriteLine(y[i]);
        }
    }
}