using System.Diagnostics.CodeAnalysis;

namespace tekrar_çalışmam_07._12._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kosullar

            //Bir üniversitede öğrencilerin ortalamaları 50 ve üzerinde ise dersten başarılı sayılmaktadırlar. Öğrencinin vize notu ortalamaya % 40, final notu % 60 etki ettiği bildiğine göre öğrencilerin ders başarı durumlarını hesaplayan programı yapalım.

            int vize;
            int final;
            double ortalama;
            Console.WriteLine("lütfen vize notunuzu giriniz");
            vize = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen final notunuzu giriniz");
            final = int.Parse(Console.ReadLine());
            ortalama = (vize * 40 / 100) + (final * 60 / 100);
            if (ortalama >= 0)
            {
                Console.WriteLine("tebrikler,ortalamanız {0} dersten geçtiniz.", ortalama);
            }
            else
            {
                Console.WriteLine("ortalamanız {0} dersten kaldınız.", ortalama);
            }
            Console.ReadLine();




            //DİZİLER

            //Eleman sayısını kullanıcının belirlediği bir dizi oluşturarak içine kullanıcının eleman girmesini sağlayın.
            //int mevcut;
            //Console.WriteLine("sınıf mevcutu giriniz.");
            //mevcut = int.Parse(Console.ReadLine());
            //string[] ogrenci = new string[mevcut];
            //for (int i = 0; mevcut > 0; i++)
            //{
            //    Console.WriteLine("lütfen öğrenci adı giriniz.");
            //    ogrenci[i] = Console.ReadLine();
            //}
            //Console.ReadLine();    


            //20 elemanlı diziye rasgele -100 ile +100 arası sayılar atan ve daha sonra dizinin elemanlarını, pozitif sayı adetini,negatif sayı adetini ve işaretsiz sayı adetini ekranda gösteriniz.
            int pozitif = 0;
            int negatif = 0;
            int notr = 0;
            Random rnd = new Random();
            int[]sayilar=new int[20];
            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = rnd.Next(-100, 100);
            }
            foreach (int sayi in sayilar)
            {
             if (sayi > pozitif)
                {
                    pozitif++;
                }
             else if (sayi < negatif)
                {
                    negatif++;  
                }
             else
                {
                    notr++;
                }
                Console.WriteLine("pozitif sayı adeti"+pozitif);
                Console.WriteLine("negatif sayı adeti"+negatif);
                Console.WriteLine("nötr sayı adeti"+notr);
                Console.ReadLine();
            }

        }
    }
}