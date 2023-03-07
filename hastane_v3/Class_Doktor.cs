using System;
namespace Hastane
{
    public class Doktor : Calisan
    {
        //ilaç isteme methodu
        public void ilacGir()
        {
            string ilacGirilen;
            Console.WriteLine("ilaç girin:");
            ilacGirilen=Console.ReadLine();
            ilacList.Add(ilacGirilen);
        }
    }
}