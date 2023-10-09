using System.Collections;
namespace Queues
{
    class Queues
    {
        public static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }
            qu.Dequeue();
            qu.Dequeue();
            Console.WriteLine();
            Console.WriteLine("after Dequeue: ");
            foreach(var item in qu)
            {
                Console.WriteLine(item);
            }
        }
    }
}