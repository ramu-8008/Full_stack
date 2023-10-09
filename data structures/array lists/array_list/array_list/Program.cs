using System.Collections;
namespace Array_list
{
    class array_list
    {
        static void Main(string[] args)
        {
            ArrayList ar_list = new ArrayList();
            ar_list.Add(1);
            ar_list.Add("santhosh");
            ar_list.Add(4.3);
            ar_list.Add(4.33F);
            for (int i = 0; i < ar_list.Count; i++)
            {
                Console.Write(ar_list[i]+", ");
            }
            Console.WriteLine();
            ar_list.Remove(4.3);
            foreach (var item in ar_list){
                Console.WriteLine(item + ", ");
            }
        }
    }
}
