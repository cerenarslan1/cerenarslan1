namespace C__IF_ELSE_27._10._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Kullanıcıdan 3 not alan ve bu notların ortalamasını bulan
            ////Eğer 80-100 arasındaysaa A+ yazdıran 
            ////60-80 arasındaysa A yazdıran 
            ////40-60 arasındaysa B+ yazdıran 
            ////40 dan küçükse F yazdıran örneğin kod kod parçalarını yazınız. 


            Console.WriteLine("Lütfen 1. notunuzu giriniz.");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());
            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("Not ortalamanız A+");

            }
            else if (sonuc > 60 && 80 < sonuc)
            {
                Console.WriteLine("Not ortalamanız A");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not ortalamanız B+");

            }
            else if (sonuc < 40)
            {
                Console.WriteLine("Not ortalamanız F ");

            }


            //BEDEN KİTLE ENDEKSİ=KİLO/boy*boy
            //BEDEN KİTLE İNDEKSİ 18 E EŞİT VEYA DÜŞÜKSE ZAYIF
            //18 İLE 25 ARASINDAYSA NORMAL
            //25'TEN BÜYÜKSE OBEZ YAZDIRAN PROGRAM PARÇASINI KODLAYINIZ. 

            Console.WriteLine("Kilonuzu Giriniz.");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız..");

            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Normalsiniz..");
                
            }
            else if (bke > 25)
            {
                Console.WriteLine("Obezsiniz....");


                Console.ReadLine();
            }

        }
    }
}
        
    
