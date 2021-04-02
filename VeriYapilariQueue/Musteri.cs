using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariQueue
{
    public class Musteri
    {
        public string ad;
        public int adet;

        public Musteri(string ad, int adet)
        {
            this.ad = ad;
            this.adet = adet;
        }

        public void EkranaYaz(int i)//Buradaki i sırayı göstermek için yazdım.
        {
            Console.WriteLine(i + "-> " + ad + " " + adet + " adet pide almak istiyor.Ödemesi gereken tutar: " + adet * 5);
        }
    }
}
