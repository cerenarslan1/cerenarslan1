namespace _06._12._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 ila 100 arasında rastgele olarak verilen 10 sayıdan tek ve çift olanların sayısını bulan program yazınız.


            int[] sayilar = new int[10];
            int cift = 0, tek = 0;

            Random random = new Random();
            random.Next(1, 100);
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cift++;
                    continue;
                }
                else
                {
                    tek++;
                }

            }
            Console.WriteLine($"çift sayıların adeti:{cift} tek sayıların adeti:, {tek}");
            Console.ReadLine();


            ////bir alışveriş mağazasında 100 liraya kadar alışverişe yüzde 20, 100-200 arası alışverişlere yüzde 30, 200 liradan fazla alışverişlere yüzde 40 indirim yapılmaktadır. Girilen alışveriş fiyatına göre indirimli fiyatı bulan program yazınız.
            ////Console.WriteLine("kaç liralık alışveriş yaptınız?");
            Console.WriteLine("Alışveriş yapılacak tutarı giriniz");
            double fiyat =Convert.ToInt32(Console.ReadLine());
            double yuzde = 0;
            double sonfiyat = 0;
            if (fiyat <= 100)
           {
              sonfiyat = (fiyat * 0.8);
               Console.WriteLine("100 liraya kadar olan alışverişlerinizde fiyat yüzde 20 düşüyor. Fiyat:"+sonfiyat);

           }
           else if (fiyat > 100 && fiyat < 200)
           {
           sonfiyat = (fiyat * 0.3);
           Console.WriteLine("100-200 liralık alışverişlerinizde fiyat yüzde 30 düşüyor. Fiyat:"+sonfiyat );
            }   
            else if(fiyat > 200)
            {
                sonfiyat = (fiyat * 0.4);
                Console.WriteLine("200 liradan fazla olan alışverişlerde fiyat yüzde 40 düşüyor.Fiyat:"+sonfiyat);
            }
            Console.ReadLine();


            //elemanları rastgele verilen bir dizideki en büyük ve en küçük elemanı ekrana yazdırınız. Dizinin alabileceği eleman sayısını kullanıcı belirlesin 
            //Console.WriteLine("lütfen sayı giriniz");
            //int elemanlar = Convert.ToInt32(Console.ReadLine());
            //int[]dizi=new int[elemanlar]; 

            for (int i = 0; i < elemanlar; i++)
            {
                Console.WriteLine("{0}. sayı indexini giriniz:", (i + 1));
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(dizi);
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //kullanıcıya kaç tane sayıyı toplayacağını sorup, kullanıcının toplayacağı kadar sayıyı kullanıcıya TEK TEK SORAN VE KULLANICININ yazdığı bu sayıların toplamını ekrana yazan uygulama yazınız.
            Console.WriteLine("Kaç adet sayı girmek istersiniz");
            int adet = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz",(i+1));
                toplam += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("girilen sayıların toplamı:"+toplam);


            //bir dizi oluşturun içine 20 tane rastgele eleman alsın. Daha sonra bu listenin ortalamasını alın . Her bir dizi elemanı için ortalamadan büyük..
            int[] sayilar = new int[20];
            Random rnd = new Random();
            int buyuk = 0;
            int kucuk = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(300);
            }
            double ortalama =sayilar.Average();
           for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < ortalama)
                {
                    kucuk++;
                }
                if (sayilar[i] > ortalama)
                {
                    buyuk++;
                }
            }
           Console.WriteLine($"Dizinin ortalamasından büyük olan değerlerin adedi {buyuk} küçük olanların adedi {kucuk}");




        }

    }


}


        

            
  