using System;
namespace Hastane
{
    public class Calisan
    {
        //ilaç bilgilerinin tutulduğu listeler
        public List<string> ilacList = new List<string>();
        public List<string> ilacStok = new List<string>();
        public List<string> ilacAlList = new List<string>();

    
        //değişkenler
        public bool girisDogru;
        public string girisBilgi;
        public string[] kullanicilar={"doktor","eczaci","hemsire"};
        public bool devam;

        //uygulama girişi
        public void giris()
        {
            girisDogru=false;
            Console.WriteLine("giriş yapın: ");
            girisBilgi=Console.ReadLine();
            foreach(string kullanici in kullanicilar)
            {
                if(girisBilgi==kullanici)
                {
                girisDogru=true;
                }
            }
            if(girisDogru==true)
            {
                Console.WriteLine("giriş başarılı!");
                Console.WriteLine("giriş tipi: " + girisBilgi );
            }
            else
            {
                Console.WriteLine("giriş başarısız!");
                Console.WriteLine("yeniden yönlendiriliyorsunuz!");
                giris();
            }
        }


        //işleme devam edilecek mi
        public void islemDevam()
        {
            Console.WriteLine("devam etmek istiyor musunuz(e/h): ");
            string cevap=Console.ReadLine();
            if(cevap=="e")
            {
                devam=true;
            }
            else if(cevap=="h")
            {
                devam=false;
            }  
            else
            {
                Console.WriteLine("geçersiz cevap!");
                islemDevam();
            }
        } 


        //doktorun istediği ilaçları listeleme
        public void ilacIstenenListele()
        {
            Console.WriteLine();
            Console.WriteLine("istenen ilaçlar:");
            int i=1;
            foreach(string ilaclar in ilacList)
            {
                Console.WriteLine(i + " : " + ilaclar);
             
                i++;
            }
        }









        
        //eczacının stokta olduğunu söylediği liste
        public void ilacStokListele()
        {
            Console.WriteLine();
            Console.WriteLine("stoktaki ilaçlar:");
            int i=1;
            foreach(string ilaclar in ilacStok)
            {
                Console.WriteLine(i + " : " + ilaclar);
             
                i++;
            }
        }

        //hemşirenin stoktan aldığı liste
        public void ilacAlinanListele()
        {
            Console.WriteLine();
            Console.WriteLine("alınan ilaçlar:");
            int i=1;
            foreach(string ilaclar in ilacAlList)
            {
                Console.WriteLine(i + " : " + ilaclar);
             
                i++;
            }
        }



    }
}