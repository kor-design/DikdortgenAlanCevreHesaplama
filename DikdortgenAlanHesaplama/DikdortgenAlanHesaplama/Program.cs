using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenAlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kısa kenarın uzunluğunu giriniz");
            double kk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("uzun kenarın uzunluğunu giriniz");
            double uk = Convert.ToDouble(Console.ReadLine());
            double dikdortgenalan = alanvecevrehesaplama.alanhesapla(kk, uk);
            double dikdortgencevre = alanvecevrehesaplama.cevrehesapla(kk, uk);
            Console.Write("Dikdörtgenin alanı: {0}  Dikdörtgenin çevresi: {1}", dikdortgenalan, dikdortgencevre);
            Console.ReadKey();
        }
        class alanvecevrehesaplama
        {
            public static double alanhesapla(double kisakenar, double uzunkenar)
            {
                double alan = kisakenar * uzunkenar;
                return (alan);
            }
            public static double cevrehesapla(double kisakenar, double uzunkenar)
            {
                double cevre = 2 * (kisakenar + uzunkenar);
                return (cevre);
            }
        }
    }
}