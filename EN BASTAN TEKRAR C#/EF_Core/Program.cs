using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Scaffold-DbContext
            
            #region DatabaseFirst
            #region Veri Tabanı Ekleme

            #endregion
            #endregion

            #region CodeFirst
            #region Migration Oluşturmak
            //PMC veya Dotnet CLI migration oluturmadan önce 
            //Microsoft.EntityFrameworkCore.Tools kütüphanesini eklemeniz gerekmektedir
            //PMC=> add.Migration [Migration Name]

            #endregion

            #endregion

            #region veriekleme
            Musteri musteri = new Musteri();
            Urun urun = new Urun();
            Personel personel = new Personel();
            ETradeContext context = new ETradeContext();



            // ekleme, döngü ve silme 

            Console.WriteLine("Müşteri Adı Giriniz");
            string ad = Console.ReadLine();
            musteri.Adi = ad;
            Console.WriteLine("Müşteri Soyadı Giriniz");
            musteri.Soyadi = Console.ReadLine();
            context.Add(musteri);
            Console.WriteLine("Tüm Müşteriler");

            Console.WriteLine("silmek istediğiniz müşterinin adını giriniz");
            string? silinecekAd = Console.ReadLine();


          
            Console.WriteLine("Personel girişi için adınızı giriniz");
            string Pname;
            personel.Adi = Console.ReadLine();
            Console.WriteLine("Personel girişi için soyadınızı giriniz");
            string Psurname;
            personel.Soyadi = Console.ReadLine();
            context.Add(personel);
            List<Personel> personeller = context.Personeller.ToList();

            foreach (Personel p in personeller)
            {
                Console.WriteLine( p.ID+" "+p.Adi);
            }

            Console.WriteLine("Silmek istediğiniz personelin ID no giriniz");
            int? silinecekID=int.Parse(Console.ReadLine());

            Personel? silinecekPersonel = context.Personeller.FirstOrDefault(p => p.ID == silinecekID);
            context.Remove(silinecekPersonel);

            //=>
            //Personel? silinecekPersonel2 = context.Personeller.Find(silinecekID);
            //context.Remove(silinecekPersonel2);


            Console.WriteLine("Eklemek İstediğiniz Ürünün Adını Giriniz?");
            string urunAdi;
            urun.UrunAdi = Console.ReadLine();
            Console.WriteLine("Fiyatı belirtiniz");
            int fiyat;
            urun.Fiyat = int.Parse(Console.ReadLine());

            context.Add(urun);

            Musteri? silinecekMusteri = context.Musteriler.FirstOrDefault(m => m.Adi == silinecekAd);

            context.Remove(silinecekAd);

            List<Urun> urunler = context.Urunler.ToList();
            foreach (Urun urun2 in urunler)
            {
                Console.WriteLine(urun2.UrunAdi);
            }
            Console.WriteLine("silmek istediğiniz ürünlerin adını giriniz");
            string? silinecekUrun = Console.ReadLine();

            Urun? silinecekUrunAdi = context.Urunler?.FirstOrDefault(m => m.UrunAdi == silinecekUrun);

            context.Remove(silinecekUrunAdi);
            context.SaveChanges();
            //bu islem veri tabanına kaydetme işlemi yapıyor

            // Tool => Nuget => PMC  add-migration mig_isim
            //update-database

            #endregion
        }
    }
    public class ETradeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Localhost;Database=ETrade2;trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
    public class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
    }
    public class Personel
    {
        public int ID { get; set; }
        public int Maas { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}

