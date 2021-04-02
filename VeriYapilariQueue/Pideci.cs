using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariQueue
{
    public class Pideci
    {
        Queue kuyruk = new Queue();
        public void PideSat()
        {
            if (kuyruk.isEmpty())
            {
                Console.WriteLine("Pide almayi bekleyen müşteri yok.");
            }
            else
            {
                Console.WriteLine(kuyruk.front() + "'in pidesi verildi.Ücret peşin alındı.");
                kuyruk.dequeue();
            }
        }

        public void KuyrugaGir(Musteri musteri)
        {
            if (musteri != null)//Böyle bir müşteri varmı kontrol ediyoruz.
            {
                kuyruk.enqueue(musteri);
            }
        }

        public void KuyruguYaz()
        {
            if (kuyruk.isEmpty())
            {
                Console.WriteLine("Kuyrukta bekleyen müşteri yok");
            }
            else
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine("Kuyrukta Bekleyen Müşteriler:");
                kuyruk.print();
                Console.WriteLine("****************************************************************");
            }
        }

        public void KuyruktakiKisiSayisi()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Kuyrukta "+kuyruk.size()+" kisi vardır.");
            Console.WriteLine("---------------------------------------");
        }
    }
}
