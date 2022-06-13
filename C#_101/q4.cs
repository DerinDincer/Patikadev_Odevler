/*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a sentence: ");

        string sentence = Console.ReadLine();

        string[] words = sentence.Split(" ");

        int wordCount = 0;

        int letterCount = 0;

        foreach (string i in words)
        {
            wordCount++;
            letterCount += i.Length;
        }

        Console.WriteLine("You wrote " + wordCount + " words.");
        Console.WriteLine("There were " + letterCount + " letters in those words.");
    }
}