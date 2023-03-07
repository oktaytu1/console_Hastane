using System;

namespace Hastane
{
    public class Hemsire : Calisan
    {
        //ilacı alma methodu
        public void ilacAlindi()
        {
            int ilacNo;
            Console.WriteLine("alınacak ilacın numarasını girin:");

            
            ilacNo=Convert.ToInt16(Console.ReadLine());
            ilacAlList.Add(ilacStok[ilacNo-1]);
            Console.WriteLine( ilacStok[ilacNo-1]+" isimli ilaç stoktan alındı!");

            ilacStok.RemoveAt(ilacNo-1);


        }

    }
}