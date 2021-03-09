using System;

namespace ConsoleApp1
{ 
class Program
{
    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    static int Pengurangan(int a, int b)
    {
        return a - b;
    }

    static int Perkalian(int a, int b)
    {
        return a * b;
    }

    static int Pembagian(int a, int b)
    {
        return a / b;
    }
    static void Main(string[] args)

    {
        Console.Title = "Kalkulator";

        int Kontol;

        Console.WriteLine("Pilih Menu Kalkulator");
        Console.WriteLine("\n1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        Console.Write("Pilih Menu (1 - 4) = ");
        Kontol = int.Parse(Console.ReadLine());
        Console.WriteLine();



        Console.Write("Masukkan Nilai A = ");
        int a = int.Parse(Console.ReadLine()); //proses casting (ngubah string menjadi int)

        Console.Write("Masukkan Nilai B = ");
        int b = int.Parse(Console.ReadLine()); //proses casting (ngubah string menjadi int)

        Console.WriteLine(); //tambahkan baris kosong


        switch (Kontol)
        {
            case 1:
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                break;

            case 2:
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                break;

            case 3:
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                break;

            case 4:
                Console.WriteLine("Hasil Perkalian {0} / {1} = {2}", a, b, Pembagian(a, b));
                break;
        }

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey(); //mirip system("pause")
    }


}
}