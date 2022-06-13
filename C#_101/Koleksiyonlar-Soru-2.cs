/*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve 
bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
(Array sınıfını kullanarak yazınız.)*/

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[20];

        Console.WriteLine("Please enter 20 numbers: ");

        for(int i = 0; i < 20; i++)
        {
            int input = int.Parse(Console.ReadLine());

            numbers[i] = input;
        }

        int[] max3 = new int[3];
        int[] min3 = new int[3];

        int minCount = 0;
        int maxCount = 0;

        Array.Sort(numbers);

        for(int i = 0; i < 3; i++)
        {
            min3[i] = numbers[i];
            minCount += min3[i];
        }

        Array.Reverse(numbers);
        
        for(int i = 0; i < 3; i++)
        {
            max3[i] = numbers[i];
            maxCount += max3[i];
        }

        int minAvg = minCount / 3;
        int maxAvg = maxCount / 3;

        int avgSum = minAvg + maxAvg;

        Console.WriteLine("The avarage of lowest 3 numbers is: " + minAvg);

        Console.WriteLine("The avarage of highest 3 numbers is: " + maxAvg);

        Console.WriteLine("The sum of these avarages is: " + avgSum);
    }
}
