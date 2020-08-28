using System;

namespace beratIdeal_09_BagasSurahman
{
    public class beratPriaWanita
    {
        public virtual void beratIdealWanita()
        {
            Console.WriteLine("Masukkan Tinggi Badan Anda : ");
            double a = double.Parse(Console.ReadLine());

            double w = (a - 100) - (a - 100) * 0.15;
            Console.WriteLine("Beran Tubuh Ideal Anda : " + w);

        }

        public virtual void beratIdealPria()
        {
            Console.WriteLine("Masukkan Tinggi Badan Anda : ");
            double a = double.Parse(Console.ReadLine());

            double p = (a - 100) - (a - 100) * 0.10;
            Console.WriteLine("Berat Tubuh Ideal Anda : " + p);

        }
    }
}
