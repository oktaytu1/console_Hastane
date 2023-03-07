using System;
namespace Hastane
{
    public class Eczaci : Calisan
    {
        //ilacın stokta olduğunu söyleme methodu
        public void ilacVar()
        {
            int ilacNo;
            Console.WriteLine("stokta olan ilaç numarasını girin:");

            ilacNo=Convert.ToInt16(Console.ReadLine());
            ilacStok.Add(ilacList[ilacNo-1]);
            Console.WriteLine( ilacList[ilacNo-1]+" isimli ilaç istek listesinden kaldırıldı ve stokta olduğu söylendi!");

            ilacList.RemoveAt(ilacNo-1);
        }
    }
}