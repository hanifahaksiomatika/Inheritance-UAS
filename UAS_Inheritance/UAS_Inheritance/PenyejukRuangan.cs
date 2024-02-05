using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Inheritance
{
    public class PenyejukRuangan
    {
        // properties
        public string Merek { get; set; }
        public int Daya { get; set; }
        
        public PenyejukRuangan(string merek = "null", int daya = 0)     // class induk
        {
            Merek = merek;
            Daya = daya;
        }
        public void GetMerekAndDaya()
        {
            Console.WriteLine("Merek Penyejuk Ruangan ini: {0} dengan Daya: {1}", Merek, Daya);
        }
    }
    public class AC : PenyejukRuangan               // class anak
    {
        public int Suhu { get; set; }

        // constructor
        public AC (string merek = "null", int daya = 0, int suhu = 1)
        {
            Merek = merek;
            Daya = daya;
            Suhu = suhu;
        }
    }
    public class KipasAngin : PenyejukRuangan       // class anak
    {
        public int Kecepatan { get; set; }

        // constructor
        public KipasAngin(string merek = "null", int daya = 0, int kecepatan = 1)
        {
            Merek = merek;
            Daya = daya;
            Kecepatan = kecepatan;
        }
    }
}
