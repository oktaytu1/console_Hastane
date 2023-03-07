using System;

namespace Hastane{

class Ana{



    static void Main(string[] args)
    {
        //nesneler
        Calisan calisan=new Calisan();
        Doktor doktor=new Doktor();
        Eczaci eczaci = new Eczaci();
        Hemsire hemsire=new Hemsire();
        bool kullan=false;

        eczaci.ilacList=doktor.ilacList;
        hemsire.ilacStok=eczaci.ilacStok;


        //kodun çalışacağı kısım
        do{
            calisan.giris();

            switch (calisan.girisBilgi)
            {
                //doktor girişi
                case "doktor":

                    do{
                        doktor.ilacGir();
                        doktor.islemDevam();
                    }
                    while(doktor.devam==true);

                    doktor.ilacIstenenListele();

                break;

                //eczaci girişi
                case "eczaci":

                    do{

                        eczaci.ilacIstenenListele();
                        eczaci.ilacVar();
                        eczaci.islemDevam();

                    }while(eczaci.devam==true);

                    eczaci.ilacStokListele();                

                break;

                //hemşire girişi
                case "hemsire":
                    
                    do{

                        hemsire.ilacStokListele();
                        hemsire.ilacAlindi();
                        hemsire.islemDevam();

                    }while(eczaci.devam==true);

                    hemsire.ilacAlinanListele();                

                break;
            }
            
            //uygulamaya devam edilip edilmeyeceği
            Console.WriteLine("yeni kullanıcı ile giriş yap(e/h)");
            string cevap=Console.ReadLine();
            if(cevap=="e")
            {
                kullan=true;
            }
            else if(cevap=="h")
            {
                kullan=false;
            }

        }while(kullan==true);

    }
    
}

}