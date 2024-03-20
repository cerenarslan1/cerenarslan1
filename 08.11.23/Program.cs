using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace _08._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan kaç adet sayı girmek istediğini soralım.
            //Cevap verdiği sayı kadar sayı girdirip daha sonra ekranda girilen sayıların toplamını ve ortalamasını gösterelim. 

            Console.WriteLine("Kaç adet sayı girmek istersiniz?");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];
            int toplam = 0;
            int ortalama = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0} adet sayı giriniz:", (i + 1));
                sayilar[i] = int.Parse(Console.ReadLine());

                toplam = toplam + sayilar[i];
            }
            Console.WriteLine("Girilen sayıların toplamı:" + toplam);
            Console.WriteLine("girilerin sayıların ortalaması:" + sayilar.Average());
            Console.ReadLine();

            //for ile adınızı 10 kere ekrana yazdırın

            Console.WriteLine("Adınız Nedir?");
            string ad = Console.ReadLine();

            //for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ad);
            }
            while döngüsü
            int s = 0;
            while (s < 10)
            {
                Console.WriteLine(ad);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ad);

            }

            //    //Kullanıcıdan bir sayı isteyelim ve girdiği sıra çift ise tekrar sayı isteyelim girdiği sayı tek olana kadar yeni sayı isteyelim. 
            Console.WriteLine("Lütfen bir sayı giriniz?");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 0; sayi % 2 == 0; i++)
            {
                Console.WriteLine("Lütfen tek sayı giriniz?");
                sayi = int.Parse(Console.ReadLine());
            }


            while (sayi % 2 == 0)
            {
                Console.WriteLine("Çift sayı girdiniz lütfen tekrar deneyiniz");
                sayi = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tebrikler tek sayı girdiniz");

            //Kullanıcının girdiği sayıyı 1 er saniye arayla 0 a kadar azaltan uygulama yapalım.
            Console.WriteLine("Lütfen bir sayı giriniz?");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 0; sayi >= 0; sayi--)

            {
                Console.WriteLine(sayi);
                Thread.Sleep(1000);
                sayi--;
            }


            //kullanıcıdan başlangıç ve bitiş sayıları alallım ekrana başlangıç sayısından başlatıp bitiş
            //sayısına kadar 2 şer saniye arayla yazdıralım.
            //Örnek kullanıcı başlangıç için 10 girdi bitiş için 20 girdiyse ekranda 10.11...,20 ye kadar 2 şer saniye arayla görecek.
            Console.WriteLine("Lütfen başlangıç sayısı giriniz");
            int baslangic;
            baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş sayısı giriniz");
            int bitis;
            bitis = Convert.ToInt32(Console.ReadLine());

            for (baslangic <= bitis; baslangic++)
            {
                Console.WriteLine(baslangic);
                Thread.Sleep(2000);
                //}
                Console.ReadKey();

            //    //15.11.2023 (Çarşamba)
            //    //5 tane çocuğun doğum yıllarını girelim ve ardından konsolu temizleyip ekranda doğum yıllarını
            //    //küçükten büyüğe göre sıralanmış halde gösterelim.

            int[] dogumTarihleri = new int[5];

            for (int i = 0; i < dogumTarihleri.Length; i++)
            {
                Console.WriteLine("{0} çocuğun dogum tarihini giriniz:", (i + 1));
                dogumTarihleri[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();

            Array.Sort(dogumTarihleri);
            //(Array.Sort yazınca tarihleri küçükten büyüğe doğru sıralıyor.!!!!!!!)
            Console.WriteLine("Girilen Yılların Küçükten Büyüğe Doğru Sıralanmış Halleri");

            for (int i = 0; i < dogumTarihleri.Length; i++)
            {


            }
            Console.ReadLine();


            ////10 adet not girilsin ve bu notlardan 50 den düşük olanlar dersten kalsın 50 ye eşit ve büyük olanlar
            ////dersten geçsin ekranda ise şu şekil çıktı olsun 
            //Örnek: Geçen kişi sayısı 7
            //         Kalan kişi sayısı = 3 gibi
            int[] notlar = new int[10];
            int kalanKisi = 0, gecenKisi = 0;
            Console.WriteLine("Lütfen sınav puanınızı giriniz.");
            for (int i = 0; i < notlar.Length; i++)
            {
                notlar[i] = int.Parse(Console.ReadLine());

                if (notlar[i] >= 50)
                {
                    gecenKisi++;
                }
                else if (notlar[i] < 50)
                {
                    kalanKisi++;
                }
            }

            Console.WriteLine("Kalan kişi sayısı : {0}   Geçen kişi sayısı {0} ", kalanKisi, gecenKisi);

            Console.ReadLine();

            //    //20 elemanlı diziye rastgele -100 ile +100 arası sayılar atan ve daha sonra dizinin elemanlarının pozitif ve negatif sayı
            //adetini gösteren uygulama yapalım.
            int[] sayilar = new int[20];
            int pozitifadet = 0;
            int negatifadet = 0;
            Random rastgele = new Random();


            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(-100, 100);


                if (sayilar[i] > 0)
                {
                    pozitifadet++;

                }
                else if (sayilar[i] < 0)
                {
                    negatifadet++;
                }

            }

            Console.WriteLine("Dizideki ssayıların değerleri: Pozitif sayı adeti: {0}  ve Negatif sayı adeti {1}", pozitifadet, negatifadet);
            Console.ReadLine();





            //    //Kullanıcıdan alınan metnin içinde bulunan sesli harflerin sayısını bulan uygulama yapalım.
            //    //Örnek: kullanıcının girdiği metin: Ceren Arslan 
            //    //Ekranda: Girilen metin sesli harf sayısı: 4

            Console.WriteLine("Metin giriniz");
            string metin = Console.ReadLine();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int adet = 0;
            for (int i = 0; i < sesliHarfler.Length; i++)
            {
                for (int j = 0; j < metin.Length; j++)
                {
                    if (sesliHarfler[i] == metin[j])
                    {
                        adet++;

                    }
                }

            }
            Console.WriteLine("Girilen metinde sesli harf sayısı:" + sesliHarfler);
            Console.ReadLine();

            //10 öğrenciye ait öğrenci numarası, isim, telefon ve mail, adreslerinizi ayrı ayrı tutan ve aranan
            //öğrenci numarasına göre öğrencinin bilgilerini gösterelim.
            //=>öğrenci bilgilerini kullanıcı değil biz girelim.
            //örnek isim dizisinini ilk elemanı Ahmet olsun ahmetin diğer bilgileri diğer dizilerin ilk elemanıymış gibi kabul edelim. 


            //  Array.IndexOf(); = Dizi içinde harf ya da kelime aramamıza yarar.Eğer harf ya da kelimeyi bulursa bulduğu ilk indexi gönderir.

            //1.çözüm

            string[] ogrno = { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" };
            string[] isim = { "Kaan", "Berat", "Efe", "Zehra", "Nehir", "İlayda", "Mehmet", "Enis", "Bilal", "Burak" };
            string[] telefon = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "1000" };
            string[] mail = { "aaaa@gmail", "bbbb@gmail", "cccc@gmail", "dddd@gmail", "eeee@gmail", "ffff@gmail", "gggg@gmail", "hhhh@gmail", "iiii@gmaile", "jjjj@gmail" };

            Console.Write("Kişi No'yu girin: ");
            string aranan = Console.ReadLine();
            int no = Array.IndexOf(ogrno, aranan.ToString());

            Console.WriteLine("----------------");
            Console.WriteLine("Aranan Kişi : {0} Telefon:  {1}email: {2}", isim[no], telefon[no], mail[no]);

            //2. çözüm

            string[] ogrenciler = { "ali", "ayşe", "berat", "burak", "beyza", "ceren", "can", "deniz", "derya" };
            string[] okulNo = { "11", "22", "33", "44", "55", "66", "77", "88", "99", "100" };
            string[] telefNo = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[] mail = { "aa@gmail.com", "bb@gmail.com", "@ccgmail.com", "dd@gmail.com", "ee@gmail.com", "ff@gmail.com",
           "gg@gmail.com", "hh@gmail.com","jj@gmail.com","kk@gmail.com" };
            Console.WriteLine("Öğrenci No Giriniz:");
            
            foreach (string ogrenci in ogrenciler)
            {
            Console.WriteLine(ogrenci);
            }
            Console.ReadLine();    


















            Console.ReadKey();














        }


    }
}