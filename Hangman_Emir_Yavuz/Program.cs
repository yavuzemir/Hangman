string[] Words = { "", "Apple", "Peach", "Watermelon", "Lemon", "Melon", "Cherry"};
Random Random = new Random();
int pcChoice = Random.Next(1, Words.Length);
string lower_Case = Words[pcChoice].ToLower();
//Console.WriteLine("Pc Choice:" + Words[pcChoice]);
char[] Guessed_Word = new char[lower_Case.Length];
for (int i = 0; i < Guessed_Word.Length; i++) Guessed_Word[i] = '_';
List<char> tahminEdilenHarfler = new List<char>();
int kalanHak = 6;
bool kelimeTahminEdildi = false;

while (kalanHak > 0 && !kelimeTahminEdildi)
{
    Console.Clear();
    Console.WriteLine("\t\t\t\t----------Welcome To The Game Of Hangman----------");
    Console.WriteLine($"Kelime: {string.Join(" ", Guessed_Word)}");
    Console.WriteLine($"Kalan Hakkınız: {kalanHak}");
    Console.WriteLine($"Tahmin Edilen Harfler: {string.Join(", ", tahminEdilenHarfler)}");

    // Kullanıcıdan harf tahmini al
    Console.Write("Bir harf tahmin edin: ");
    char tahmin;
    try
    {
        tahmin = char.ToLower(Console.ReadLine()[0]); // Kullanıcının girdiği harfi al
    }
    catch
    {
        Console.WriteLine("Geçersiz giriş. Lütfen bir harf girin.");
        continue;
    }

    // Daha önce tahmin edilmiş mi?
    if (tahminEdilenHarfler.Contains(tahmin))
    {
        Console.WriteLine("Bu harfi daha önce tahmin ettiniz. Başka bir harf deneyin.");
        Console.ReadKey();
        continue;
    }

    tahminEdilenHarfler.Add(tahmin);

    // Tahmin doğru mu?
    if (lower_Case.Contains(tahmin))
    {
        for (int i = 0; i < lower_Case.Length; i++)
        {
            if (lower_Case[i] == tahmin)
            {
                Guessed_Word[i] = tahmin;
            }
        }
        Console.WriteLine("Doğru tahmin!");
    }
    else
    {
        kalanHak--;
        Console.WriteLine("Yanlış tahmin!");
    }

    // Kelime tamamen tahmin edildi mi?
    if (new string(Guessed_Word) == lower_Case)
    {
        kelimeTahminEdildi = true;
    }

    Console.ReadKey();
}

// Oyun bitti, sonucu göster
Console.Clear();
if (kelimeTahminEdildi)
{
    Console.WriteLine($"Tebrikler! Kelimeyi doğru tahmin ettiniz: {lower_Case}");
}
else
{
    Console.WriteLine($"Maalesef kaybettiniz. Doğru kelime: {lower_Case}");
}




//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Kelime ve diğer oyun değişkenleri
//        string kelime = "bilgisayar"; // Tahmin edilecek kelime
//        char[] tahminEdilenKelime = new char[kelime.Length];
//        for (int i = 0; i < tahminEdilenKelime.Length; i++) tahminEdilenKelime[i] = '_'; // Başlangıçta kelime "_ _ _" olarak gösterilir

//        List<char> tahminEdilenHarfler = new List<char>(); // Daha önce tahmin edilen harfler
//        int kalanHak = 6; // Oyuncunun toplam hakkı
//        bool kelimeTahminEdildi = false;

//        // Oyun döngüsü
//        while (kalanHak > 0 && !kelimeTahminEdildi)
//        {
//            Console.Clear();
//            Console.WriteLine("Adam Asmaca Oyunu");
//            Console.WriteLine("-----------------");
//            Console.WriteLine($"Kalan Hakkınız: {kalanHak}");
//            Console.WriteLine($"Kelime: {string.Join(" ", tahminEdilenKelime)}");
//            Console.WriteLine($"Tahmin Edilen Harfler: {string.Join(", ", tahminEdilenHarfler)}");

//            // Kullanıcıdan harf tahmini al
//            Console.Write("Bir harf tahmin edin: ");
//            char tahmin;
//            try
//            {
//                tahmin = char.ToLower(Console.ReadLine()[0]); // Kullanıcının girdiği harfi al
//            }
//            catch
//            {
//                Console.WriteLine("Geçersiz giriş. Lütfen bir harf girin.");
//                continue;
//            }

//            // Daha önce tahmin edilmiş mi?
//            if (tahminEdilenHarfler.Contains(tahmin))
//            {
//                Console.WriteLine("Bu harfi daha önce tahmin ettiniz. Başka bir harf deneyin.");
//                Console.ReadKey();
//                continue;
//            }

//            // Harfi tahmin edilenlere ekle
//            tahminEdilenHarfler.Add(tahmin);

//            // Tahmin doğru mu?
//            if (kelime.Contains(tahmin))
//            {
//                for (int i = 0; i < kelime.Length; i++)
//                {
//                    if (kelime[i] == tahmin)
//                    {
//                        tahminEdilenKelime[i] = tahmin; // Doğru tahmin edilen harfleri kelimeye yerleştir
//                    }
//                }
//                Console.WriteLine("Doğru tahmin!");
//            }
//            else
//            {
//                kalanHak--; // Yanlış tahminde hak azaltılır
//                Console.WriteLine("Yanlış tahmin!");
//            }

//            // Kelime tahmin edildi mi?
//            if (new string(tahminEdilenKelime) == kelime)
//            {
//                kelimeTahminEdildi = true;
//            }

//            Console.ReadKey();
//        }

//        // Oyun bitti, sonucu göster
//        Console.Clear();
//        if (kelimeTahminEdildi)
//        {
//            Console.WriteLine($"Tebrikler! Kelimeyi doğru tahmin ettiniz: {kelime}");
//        }
//        else
//        {
//            Console.WriteLine($"Maalesef kaybettiniz. Doğru kelime: {kelime}");
//        }
//    }
//}

