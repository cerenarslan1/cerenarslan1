namespace C__Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler içerisinde birden fazla aynı türde değer tutabilen yapılardır. Yazılımsal boyutta yzzılım
            //adına ram de birden fazla değeri tek bir değişkne altında bir veri kümesi halinde tutabilirler.
            //Dizi içerisine koyulan değerler İŞLEVSEL olarak aynı olmalıdır. Yani arabalar diye açtığım dizinin içerisine araba dışında veri girmemelidir.
            //


            //Diziler içersine eleman/değer eklendikçe sıralı bir şekilde depolanacaktır. Eklenen elemanlar index numarası ile ardışık bir şekilde depolanırlar.

            //index numarası= Her elemana verilen ardışık sayıdır. 0 dan başlar n-1 e kadar devam eder.

            //Dizi tanımlama
            //type[] isim=new type[eleman sayısı]  dizi tanımımınu şekildedir.
            //Eleman sayısı belirtmek zorundadır.
            //new => nesne oluşturmak için kullanıyoruz.
            //[] operatörünün adı indexer dır.
            //Diziler alan tahsisi yapıldığında ilgili alanlara türüne göre default değeri artar. int=> string=> null boll => false


            //İlerisi seviye bilgi-------
            //Yapısal olarak RAM'da Heap'te tutulur.
            //diziler REFERANS türlü değerlerdir. Nesnel yapılardır. Özlerinde classtırlar.

            //    //Bugüne kadar değer  türlü değişkenler ile çalıştık.

            //    //değer tipler: int,float,double,decimal,char,bool,enun
            //    //Referans tipler: string,object, class,interface,array.

            //    int[] deneme = new int[2];
            //    deneme[0] = 1;
            //    deneme[1] = 12;

            //    int[] rakamlar = { 1, 2, 3, 4, 5, 6, 7, };
            //    Console.WriteLine(rakamlar[3]);

            //    string[] aylar = { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran",
            //    "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };


            //    int index = 0;
            ////Eşit olmamasının sebebi dizide 12 eleman var ama son elemanın index numarası 11
            //don:
            //    if (index < aylar.Length)
            //    {
            //        Console.WriteLine(aylar[index]);
            //        index++;
            //        goto don;
            //    }
            //    Console.ReadLine();

            //Dizi tanımlayın içerisinde aylar döngüyle tüm ayları gösterelim.

            //string[] aylar = { "ocak", "subat", "mart", "nisan", "mayıs", "haziran", "temmuz", "agustos", "eylül", "ekim", "kasım", "aralık" };

            //for (int i = 0; i < aylar.Length; i++)
            //{

            //    Console.Write((i + 1) + ".ay:");
            //    Console.WriteLine(aylar[i]);

            //}
            //Console.ReadLine();
            //Kullanıcıya kaç adet sayı girmek istiyorsun diye sorup verdiği cevap kadar sayı girmesini sağlayalım.
            //Girilen sayıları küçükten büyüğe doğru sıralayalım.

            //Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");

            //int adet = int.Parse(Console.ReadLine());

            //int[] sayilar = new int[adet];
            //int toplam = 0;


            ////for (int i = 0; i < sayilar.Length; i++)
            ////{
            ////    Console.WriteLine("Kullanıcı sayı girebilir.");
            ////    sayilar[i] = int.Parse(Console.ReadLine());
            ////    Console.WriteLine("Girilen sayı:" + sayilar[i]);
            ////    toplam += sayilar[i];
            ////    Console.WriteLine(sayilar[i]);

            ////    //toplam=toplam+sayilar[i];
            ////    Console.WriteLine("Girilen sayıların toplamı:" + toplam);

            ////    //Bazı dizi özellikleri 
            ////    //Lenght=> bu metot, dizideki toplam eleman sayısını döndürür.
            ////    //Clear=>Bu metot, içine parametreler alarak dizinin belirtilen alanındaki değerleri temizler.
            //    //1. parametre dizinin kendisidir.2. parametre, silme işleminin dizinin hangi indeksinden
            //    //başlayarak gerçekleşeceğidir. 3. parametre toplamda kaç eleman silineceğinin belirtildiği alandır.
            //    //2. ve 3. parametreler tam sayı(int) olarak atanmalıdır.

            //    int[] clearDizi = { 10, 20, 30, 40, 50 };
            //    //1. elemandan itibaren 2 eleman siler 
            //    Array.Clear(clearDizi, 1, 2);
            //    //Dizideki tüm elemanları siler.
            //    Array.Clear(clearDizi, 0, clearDizi.Length);

            //    //reverse: Bu metot dizi elemanlarının sıralamasını indeks sırasına göre tersine çevirir.
            //    string[] reverseDizi = { "A", "B", "C", "D" };
            //    Array.Reverse(reverseDizi);
            //    Console.WriteLine(reverseDizi[3]);



            //    ////Sort:Bu metot dizi elemanlarını dizinin tipine bağlı olarak sıralar.
            //    ///
            //    //Dizini metinsel isealfabetik olaral, numerik ise rakamların büyüklüğüne göre sıralama yapar.
            //    string[] sortDizi = { "D", "C", "B", "A" };
            //    Array.Sort(sortDizi);
            //    Console.Write(sortDizi[2]);
            //    //IndexOf=> Bu metot, dizi içindeki bir elemanın indeksini döndürür;
            //    int[] indexDizi = { 0, 1, 30, 40, 99, };
            //    Console.WriteLine(Array.IndexOf(indexDizi, 99));



            //int[] sayilar1 = new int[5] { 3, 9, 12, 1, 7 };

            //Array.Sort(sayilar1);

            //for (int i = 0; i < sayilar1.Length; i++)
            //{
            //    Console.WriteLine(sayilar1[i]);
            //}
            //Console.WriteLine();

            //// Dizinin eleman sayısının ekranda gösterelim. 

            //foreach (var item in sayilar1)
            //{
            ////    Console.WriteLine(item);
            ////}


            ////Kullanıcıya önce kaç kişinin bilgisine gireceğini soralım.
            ////Verdiği cevaba göre ad ve yaş bilgisi girelim. sonra girilen ad ve yaş bilgilerini ekranda gösterelim

            //Console.WriteLine("Kaç adet kişinin bilgisini girmek istiyorsunuz?");

            //int adet = int.Parse(Console.ReadLine());
            //string[] kisi = new string[adet];


            //int[] yas = new int[adet];

            //for (int i = 0; i < kisi.Length; i++)
            //{
            //    Console.WriteLine("İsim giriniz");
            //    kisi[i] = Console.ReadLine();

            //}
            //Console.Clear();
            //for (int i = 0; i < kisi.Length; i++)
            //{

            //    Console.WriteLine("Yaş Bilgisini Giriniz.");
            //    yas[i] = int.Parse(Console.ReadLine());


            //    Console.ReadKey();  

            Console.WriteLine("Kaç kişi bilgisini gireceksiniz?");
            //int adet1= int.Parse(Console.ReadLine());
            //int[] yaslar = new int[adet1];
            //string[] isimler = new string[adet1];
            //for (int i = 0; i < yaslar.Length; i++)
            //{
            //    Console.WriteLine("{0}. kişinin ismini giriniz:", (i + 1));
            //    isimler[i] = Console.ReadLine();




        }
    }


}






}
}
