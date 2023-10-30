using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDers1
{
    internal class Program
    {//  girelen sayının karesini alma.
        static void Main(string[] args)
        {
            #region Sayının Karesini Alma
            /*
            Console.Write("Lütfen karesini almak istediğniz Sayıyı girniz : ");
            string sayı = Console.ReadLine();
            int sayıint = Convert.ToInt32(sayı);
            int sayıkaresi = sayıint * sayıint;
            Console.WriteLine(sayıkaresi);
            Console.ReadLine();
            */
            
            Console.Write("Sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi * sayi;
            Console.WriteLine(sayi+ " - Değerinin karesi : " + sonuc);
            Console.ReadKey();
            
            #endregion

        }
    }
}
