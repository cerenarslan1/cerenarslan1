using System;
using System.Reflection;

namespace DiziSonn_22._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////kullanıcının girdiğinın faktöriyelini hesaplayıp ekranda yazdırınız.

            //int sayi;
            //Console.WriteLine("faktöriyel hesaplanacak sayıyı yazınız");
            //sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}

            //Console.WriteLine(sonuc);
            //Console.ReadLine();





            //bir tane hayvan dizisi oluşturalım ve kullanıcı beş adet hayvan ismi girsin. 
            //Daha sonra dizi ekrana index sayısıyla beraber listelensin. Listelendikten sonra kullanıcıya silmek istediğiniz
            //hayvanın index numarasını giriniz diye soralım. girdiği index numarasındaki veriyi temizleyelim. Daha sonra console
            ////temizleyşp son hal ekranda gösterelim.
            /// index numaralı hayvan:maymun
            /// index numaralı hayvan:lemur
            /// index numaralı hayvan:fil
            /// index numaralı hayvan:akrep
            /// index numaralı hayvan:balık

            //Kullanıcıya silmesini istediği hayvanın index numarasını sordun 3 girdiğini varsayalım.

            //consolu temizledin ve ekranda yeni listeyi gösterdin.

            // 0 index numaralı hayvan:maymun
            //1 index numaralı hayvan:lemur
            // 2 index numaralı hayvan:fil
            //3 index numaralı hayvan:
            // 4 index numaralı hayvan:
            // 5 index numaralı hayvan:balık

               string[] hayvan = new string[5];
               Console.WriteLine(" 5 tane hayvan ismini giriniz");
               for (int i = 0; i < hayvan.Length; i++)
                {
                 Console.WriteLine("{0}. hayvanı giriniz:", (i + 1));
                 hayvan[i] = Console.ReadLine();
                }
                Console.Clear();
                for (int i = 0; i < hayvan.Length; i++)
                {
                    Console.WriteLine("{0}. index numaralı hayvan : {1} ", i, hayvan[i]);
                }

              Console.WriteLine("Silmek istediğiniz hayvanın numarasını giriniz:", hayvan);
              int index = int.Parse(Console.ReadLine());

               Array.Clear(hayvan, index, 1);
               Console.Clear();
                for (int i = 0; i < hayvan.Length; i++)
               {
                Console.WriteLine("{0}");
               }

            }
        }
    }