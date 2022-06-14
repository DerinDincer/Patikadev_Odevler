/*Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        string vowels = "aeiouAEIOU";

        Console.WriteLine("Please enter a sentence: ");

        string sentence = Console.ReadLine();

        char[] input = sentence.ToCharArray();

        var found = new ArrayList();

        foreach(char i in input)
        {
            foreach(char j in vowels)
            {
                if (i == j) 
                {
                    if (found.Contains(i)) continue;
                    else found.Add(i);
                }
                else continue;
            }
        }

        foreach(char i in found)
        {
            Console.WriteLine(i);
        }
    }
}