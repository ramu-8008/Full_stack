using System.Collections;
namespace stack
{
    class Stacks
    {
        public static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            foreach(var item in st)
            {
                Console.WriteLine(item+", ");
            }
            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item + ", ");
            }
        }
    }
}