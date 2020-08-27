using System;
using beratIdeal_09_BagasSurahman;

namespace hitungBerat_09_BagasSurahman
{
    class Program
    {
        static void Main(string[] args)
        {
            beratPriaWanita bpw = new beratPriaWanita();
            Console.WriteLine("================================");
            Console.WriteLine("1. Berat Ideal Pria");
            Console.WriteLine("2. Berat Ideal Wanita");
            Console.WriteLine("Masukkan Menu Berat Ideal [1/2] = ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            if (input == 1)
            {
                Console.WriteLine("======Berat Ideal Pria======");
                bpw.beratIdealPria();
                Console.WriteLine("============================");
            }
            else if (input == 2)
            {
                Console.WriteLine("======Berat Ideal Wanita======");
                bpw.beratIdealWanita();
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Menu Not Defined");
            }
        }
    }
}
