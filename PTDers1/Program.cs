using System;
using System.Collections;
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

            #region Sözlük ÖDEVİ.
            //Hastable içerisine ENG - TR olarak data eklemeniz.
            /*
             * Yeni Kayıt eklemek istiyormusunuz : E/H
             * E: Yeni kayıt ekleme işlemi devam etsin,
             * H: Tüm listeyi yazdırın.
             * 
             * Var olan bir key değeri ekliyor ise kullanıcıya bu değer daha 
             * önceden ... şeklinde sistemimizde bulunmaktadır.
             */
            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {

                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz sözlük değerini Yazınız : ");
                Console.Write("EN : ");
                string eng = Console.ReadLine();

                bool kontrol = sozlukVeriTabani.ContainsKey(eng);
                if (kontrol)
                {
                    Console.WriteLine("Eklemek İstdiğiniz değer {0} sözlük içerisinde bulunmaktadır. {1} değerin Türkçe karşılığıdır.", eng, sozlukVeriTabani[eng].ToString());

                }
                else
                {
                    Console.WriteLine("{0} ingilizce değerin Türkçe karşılığını yazınız.", eng);
                    string tr = Console.ReadLine();
                    sozlukVeriTabani.Add(eng, tr);
                    Console.WriteLine("Değer ekleme işlemi başarılı");
                }
                Console.WriteLine("Yeni Değer eklemek istiyor musunuz ? (E/H) ");

            } while (Console.ReadLine().ToUpper() != "H");
            //1. Yöntem :
            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("ENG : {0} = {1} : TR", item, sozlukVeriTabani[item]);
            }
            //2.Yöntem
            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                //Console.WriteLine(item.GetType().Name); 
                Console.WriteLine("ENG : {0} = {1} : TR", item.Key, item.Value);
            }

            #endregion

        }
    }
}
