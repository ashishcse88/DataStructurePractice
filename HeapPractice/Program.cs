using System;

namespace HeapPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var BH = new BinaryHeapNode(10);
            BH.Insert(10);
            BH.Insert(11);
            BH.Insert(1);
            BH.Insert(13);
            BH.Insert(6);
            BH.Insert(4);
            BH.PrintHeap();
            var Maxval=BH.DeleteMax();
            Console.WriteLine("Maximum values is " + Maxval);
            BH.PrintHeap();
            Maxval=BH.DeleteMax();
            Console.WriteLine("Maximum values is " + Maxval);
        }
    }
}
