using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariQueue
{
    public class Queue
    {
        QueueNode root;//Zaten root oluşturulurken biz null'a eşitledik.
        public Queue()//Eger root zaten null 'e eşit geliyorsa zaten eleman yoktur demek.
        {
            root = null;
        }

        public bool isEmpty()
        {
            return root == null;//Null 'a eşitmi degil mi diye soruyor.Null'a eşitse eleman yoktur demek.Biz Eleman ekleyince root başka bir yeri işaret 
                                //edince sorgu false gelicek.
        }

        public void enqueue(Musteri musteri)
        {
            if (isEmpty())
            {
                root = new QueueNode(musteri);//Eleman yoksa kuyrukta eklenen eleman direk root'a veriliyor.
            }
            else//Birden fazla eleman varsa son elemanı arıyacaz eklemek için sona.
            {
                QueueNode tmp = root;//Temp degişkenimizde başlangiçta root u gösterecek.
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }
                tmp.next = new QueueNode(musteri);
            }
        }

        public void dequeue()
        {
            if (isEmpty())
            {
                throw new Exception("Error : Queue::dequeue() for queue is empty");//Kuyruk boşken eleman çıkarırsak hata fırlatıcak.
            }
            else
            {
                QueueNode tmp = root;//Garbage collector tarafından siliniyor bu degişken;
                root = root.next;//Sildikten sonra yeni root eski root un nexti oluyor.
            }
        }

        public void print()
        {
            QueueNode tmp = root;//Current degişkeni gibi geçici bir degişkendir.
            int i = 1;
            while (tmp != null)
            {
                tmp.musteri.EkranaYaz(i);
                tmp = tmp.next;
                i++;
            }
            Console.WriteLine();
        }

        public string front()//Kuyrugun başındaki elemanı getirir bize.
        {
            if (isEmpty())
            {
                throw new Exception("Error : Queue::front() for queue is empty");
            }
            else
            {
                return root.musteri.ad; //Root zaten en baştaki elemanı gösterir her zaman.
            }
        }

        public int size()
        {
            QueueNode tmp = root;
            int counter = 0;
            while (tmp != null)
            {
                counter++;
                tmp = tmp.next;
            }
            return counter;
        }
    }
}
