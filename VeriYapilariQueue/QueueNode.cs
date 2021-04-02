using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariQueue
{
    public class QueueNode
    {
        public Musteri musteri;//Datayı tutar.
        public QueueNode next;//Link bir sonraki elemanı işaret eder.
        public QueueNode(Musteri musteri) { this.musteri = musteri; next = null; }//Next herhangi bir değer verilmez ise null olarak işlem görücek.
    }
}
