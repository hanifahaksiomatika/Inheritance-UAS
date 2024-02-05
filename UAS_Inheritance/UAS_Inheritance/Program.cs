using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PenyejukRuangan penyejukRuangan = new PenyejukRuangan("Panasonic", 200);
            penyejukRuangan.GetMerekAndDaya();

            AC ac = new AC("Sharp", 1000, 24);
            ac.GetMerekAndDaya();

            KipasAngin kipasAngin = new KipasAngin("National", 300, 3);
            kipasAngin.GetMerekAndDaya();

            /*PenyejukRuangan penyejukRuangan = new PenyejukRuangan();    //mengakses property
             penyejukRuangan.Merek = "Panasonic";
             penyejukRuangan.Daya = 200;
             penyejukRuangan.GetMerekAndDaya();

             AC ac = new AC();
             ac.Merek = "Sharp";
             ac.Daya = 1000;
             ac.Suhu = 24;
             ac.GetMerekAndDaya();

             KipasAngin kipasAngin = new KipasAngin();
             kipasAngin.Merek = "National";
             kipasAngin.Daya = 300;
             kipasAngin.Kecepatan = 3;
             kipasAngin.GetMerekAndDaya();
             */


            Console.ReadKey();
        }
    }
}
