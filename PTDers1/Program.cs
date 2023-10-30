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
            /*
            Console.Write("Sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi * sayi;
            Console.WriteLine(sayi+ " - Değerinin karesi : " + sonuc);
            Console.ReadKey();
            */
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
            /*
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
            */
            #endregion

            #region Memur maaş katsayısını tutan değişken
            /*
            double mmk2 = 0.509;
            byte not;
            not = 98;
            short s1, s2 = 90, s3;
            s1 = 50;
            not = 50;
            const double pi=0.314;
            //pi = 3.18; //sabitin değeri değiştirilemez

            string isim = "doğukan";
            double mks= 1.25;
            int sayım = 32;
            decimal kesirli = 10/2;
            short sayım2 = 2;
            byte yas = 23;
            const int boy = 175;

            int sayi1 = 613; //atama işlemi
            sayi1 = 25 + 15; //aritmetiksel işlem
            int sa1 = 12, sa2 = 10;
            sa2 += sa1;
            sa2 *= sa1;

            sa1++;
            sa2 = sa1++;//sa1 = 14, sa2=13
            sa2 = ++sa1; //sa1 = 15, sa2=15

            sa1--;
            sa1 = sa2--;
            sa1 = --sa2;
            */
            #endregion

            #region PT Ders Uygulama
            //SORU : Klavyeden girilen iki sayının ortalamasını ekrana yazdıran kodu yazınız.

            Console.Write("Sayı 1 : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2 : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            int toplam = s1 + s2;
            double bolum = toplam / 2;
            Console.WriteLine("Girilen değerler {0} ve {1}" ,s1 , s2 );
            Console.WriteLine("Ortalaması : " + bolum);
            Console.ReadLine();

            //2.Yöntem
            /*
            int sayıilk = Convert.ToInt32(Console.ReadLine());
            int sayıiki = Convert.ToInt32(Console.ReadLine());

            double ortalama = (sayıilk + sayıiki) / 2;
            Console.WriteLine(ortalama);
            */
            #endregion

        }
    }
}
