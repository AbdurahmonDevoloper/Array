using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        // 1. 1D Array asoslari
        int[] numbers = new int[10];
        Console.WriteLine("10 ta son kiriting:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1}-son: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Yig'indi: {numbers.Sum()}");

        // 2. Eng katta va eng kichik qiymat
        Console.WriteLine($"Max: {numbers.Max()}, Min: {numbers.Min()}");

        // 3. Juft va toq sonlar
        Console.Write("Juftlar: ");
        foreach (var n in numbers) if (n % 2 == 0) Console.Write(n + " ");
        Console.Write("\nToqlar: ");
        foreach (var n in numbers) if (n % 2 != 0) Console.Write(n + " ");
        Console.WriteLine();

        // 4. O'rtacha qiymat
        Console.WriteLine($"O'rtacha qiymat: {numbers.Average()}");

        // 5. String teskari aylantirish
        Console.Write("\nString kiriting: ");
        string text = Console.ReadLine();
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine("Teskari: " + new string(charArray));

        // 6. Unli va undosh harflar
        int vowels = text.Count(c => "aeuioo'aeuio".Contains(char.ToLower(c)));
        int consonants = text.Count(c => char.IsLetter(c)) - vowels;
        Console.WriteLine($"Unli: {vowels}, Undosh: {consonants}");

        // 7. Palindrom tekshirish
        string reversedText = new string(text.Reverse().ToArray());
        bool isPalindrome = text.Equals(reversedText, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("Palindrom: " + (isPalindrome ? "Ha" : "Yo'q"));

        // 8 & 10. StringBuilder bilan ismlarni birlashtirish
        Console.WriteLine("\n5 ta ism kiriting:");
        string[] names = new string[5];
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 5; i++)
        {
            names[i] = Console.ReadLine();
            sb.Append(names[i]);
            if (i < 4) sb.Append(", ");
        }
        string combined = sb.ToString();

        // 9. Bo'sh joylarni olib tashlash
        Console.WriteLine("Natija (vergul bilan): " + combined);
        Console.WriteLine("Bo'sh joysiz: " + combined.Replace(" ", ""));
    }
}