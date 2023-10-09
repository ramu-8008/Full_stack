using System.Collections;
namespace assessment9a
{
    class Assessment9a
    {
        public static void Main(string[] args)
        {
            ArrayList arl = new ArrayList();
            arl.Add(1);
            arl.Add(2);
            arl.Add(3);
            arl.Add(4);
            arl.Add(5);
            arl.Add(6);
            foreach (var item in arl)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after pop");
            arl.Remove(arl.Count);
            foreach (var item in arl)
            {
                Console.WriteLine(item);
            }
        }
    }
}