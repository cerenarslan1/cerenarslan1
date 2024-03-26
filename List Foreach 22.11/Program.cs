using System.ComponentModel.DataAnnotations.Schema;

namespace List_Foreach_22._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listeler, bir koleksiyon olarak düşünülebilir  ve dinamik bir boyuta sahiptir, Yeni, liste elemanlarını
            //eklemek veya çıkarmak, boyutunu değiştirmek mümkündür. C# programında List<T> sınıfı, genel bir tip
            //(generic type) kullanılarak oluşturulur. Y kısmı, listenin hangi türde veri tutacağını belirler.

            //Foreach=> For döngüsüne benzetilebilir anca nir DÖNGÜ DEĞİLDİR İTERASYONDUR: Görevi 
            // verilen dizi, liste gibi içerisinde birden fazla veriyi tutabilecek yapıların  ilk elemanından
            // başlayarak son elemanına kadar gidecektir.
            //***önemli Kritik Bilgi => Foreach ile bir dizi, liste vb. içerisindeki elemanları itere ederek ulaşırken itere ettiğimiz 
            //şeyin eleman sayısı değişmemelidir.
            //Aksi halde uygulama elemanın değiştiği an hataya düşecektir.


            //LİST 
            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(7);
            sayilar.Add(2);
            sayilar.Add(1);

            sayilar.Remove(3); //Böyle yaparak dizinin içindeki 3'ü siliyoruz.
            sayilar.RemoveAt(0); // Removeat ise 0. index deki elemanı kaldırıyoruz.
            int uzunluk = sayilar.Count;
            sayilar.Clear();
            sayilar.Contains(1);
            (sayilar.Contains kullanım şekli)
            sayilar.Clear();
            if (sayilar.Contains(1))
            {

            }
            Console.WriteLine(sayilar[1]);
            Console.ReadLine();

            Foreach

            int[] sayilar = new int() { 1, 2, 3, 4, 5, 20, 232, 2, 4, 5, 62, 2 }
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();


            string tipinde bir liste oluşturma
            List<string> meyveler = new List<string>();

            //  meyveler.Add("muz");
            meyveler.Add("elma");
            meyveler.Add("çilek");
            //Listedeki elemanları for döngüsü ile ekrana yazdırma.

            for (int i = 0; i < meyveler.Count; i++)
            {
                Console.WriteLine(meyveler[i]);
            }


            // Listedeki elemanları foreach ile ekrana yazdıraşıö
            Console.WriteLine("----Foreach----");
            foreach (string item in meyveler)
            {
                Console.WriteLine(item);
            }

            //listedeki elemanlara index numarası ile erişme
            Console.WriteLine("İndex 0 daki meyve:"+ meyveler[0]);

            //Belirli bir indexteki elemanı değiştirme
            meyveler[0] = "üzüm";

            Console.WriteLine("Güncel 0 index meyve:"+ meyveler[0]);
            Console.WriteLine();


            //Belirli bir elemanı listeden çıkarma
            meyveler.Remove("elma");
            foreach (var item in meyveler)
            {
                Console.WriteLine(item);
            }
            //Belirli bir elemanı index numarası ile silmek 
            meyveler.RemoveAt(0);
            Console.WriteLine();
            foreach (var item in meyveler)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();



            //listenin uzunluğunu gösteren metot

            Console.WriteLine("Meyveler listesinin uzunluğu"+meyveler.Count);

            //Listenin içerşsşndeki elemanların hepsini silmek için 
            meyveler.Clear();
            Console.WriteLine("\nMeyveleer listesinin son halindeki uzunluğu:"+meyveler.Count)


            //Contain Metodu 
            List>string<telefonlar=new List</string>();
            telefonlar.Add("Samsung");
            telefonlar.Add("İphone");
            telefonlar.Add("Huawei");
            telefonlar.Add("Xiomi");

            Console.WriteLine("Lütfen aranacak telefon markasını giriniz.");
            string arananTel = Console.ReadLine();
            if (telefonlar.Contains(arananTel))
            {
                Console.WriteLine("Aranan r-telefon listede mevcut");
            }
            else
            {
                Console.WriteLine("Aradığınız {0} markalı telefon bulunamadı", arananTel);
            }




















        }
    }
}