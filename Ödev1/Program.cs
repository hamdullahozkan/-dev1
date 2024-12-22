using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan sayı girişi alma
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan alınan değeri tamsayıya çeviriyoruz.

        // 10 ile karşılaştırma
        if (sayi == 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
        }

        // Tek veya çift kontrolü
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı tektir.");
        }
    }
}
