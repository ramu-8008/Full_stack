using System.Collections;
namespace HashTable
{
    class hashTable
    {
        public static void Main(string[] args)
        {
            Hashtable has = new Hashtable();
            has.Add("name", "ram");
            has.Add("age", 20);
            has.Add("clg", "presidency");
            foreach(DictionaryEntry item in has)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}