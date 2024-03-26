using System;

namespace EN_BASTAN_TEKRAR_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 25;
            int sayi2 = 5;
            int toplam = sayi1 + sayi2;
            int cikarma = sayi1 - sayi2;
            int bolum = sayi1 / sayi2;

            Console.WriteLine(toplam);
            Console.WriteLine(bolum);
            Console.WriteLine(cikarma);

            Console.WriteLine("Lütfen Bir İl Seçiniz. A. Adana B. Balıkesir C. Rize D.İzmir");
            string secim = Console.ReadLine();
            if (secim == "A")
            {
                Console.WriteLine("Atakuleye gitmeyi unutma");
            }
            else if (secim == "B")
            {
                Console.WriteLine("Altınoluk plajlarına gitmeyi unutma");
            }
            else if (secim == "C")
            {
                Console.WriteLine();
            }
            else if (secim == "D")
            {
                Console.WriteLine("İzmirde saat kulesini gezmeyi unutma");
            }
            else
            {
                Console.WriteLine("lütfen Düzgün Giriş Yap");
                Console.ReadLine();
            }
            //kullanıcıdan haftanın gününü alıp hava tahminini gösteren programı yazınız.

            Console.WriteLine("Lütfen gün giriniz");
            string gun = Console.ReadLine();
            switch (gun)
            {
                case "pazartesi":
                    Console.WriteLine("0 derece");
                    break;
                case "salı":
                    Console.WriteLine("1 derece");
                    break;
                case "çarşamba":
                    break;
                    Console.WriteLine("2 derece");
                case "perşembe":
                    Console.WriteLine("3 derece");
                    break;
                case "cuma":
                    Console.WriteLine("4 derece");
                    break;
                default:
                    Console.WriteLine("Bugün için bir tahmin bulunamamaktadır");
                    break;
            }
            //Kullanıcıdan 2 sayı alalım 
            //swich case ile bir hesap makinesi yapacağız.
            int sayi3, sayi4;
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem yapmak istediğiniz işareti seçiniz");
            string isaret = Console.ReadLine();
            switch (isaret)
            {
                case "+":
                    Console.WriteLine(sayi3 + sayi4);
                    break;
                case "-":
                    Console.WriteLine(sayi3 - sayi4);
                    break;
                case "/":
                    Console.WriteLine(sayi3 / sayi4);
                    break;
                case "*":
                    Console.WriteLine(sayi3* sayi4);
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir işaret giriniz.");
                    break;
            }
                    Console.ReadLine();

            
                    ////1-x arasındaki sayıları ekrana yazdıralım.
                    Console.WriteLine("Lütfen bir sayı giriniz");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= sayi; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                    //1000 - 1 arasındaki sayıları ekrana yazdıralım
                    for (int i = 1000; i >= 1; i--)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                    /// 1000 - 1 arasındaki sayıları arasında 3 e bölünen sayıları yazdıralım.
                    for (int i = 1; i <= 1000; i++)
                    {

                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadLine();

                        int sayac = 0;
                        for (int i= 1; i < 1000; i++)
                        {
                            if (i % 5 == 0)
                            {
                                sayac++;
                                if (sayac == 11)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                        }
                        Console.ReadLine();

                        int sayi21 = 9;
                        while (sayi21 > 5)
                        {
                            Console.WriteLine("Sayı 5 ten büyüktür.");
                            sayi21--;
                        }
                        Console.ReadLine();
                    }
            }
        }
    }
}


