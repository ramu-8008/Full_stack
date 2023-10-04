namespace properties
{

    class Program
    {
        class Person
        {
            private String name ;



            public String Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            private int rollNo;
            public int RollNo
            {
                get { return rollNo; }
                set { rollNo = value; }
            }




        }
        static void Main()
        {
            Person myObj = new Person();
            myObj.Name = "ram";
            Console.WriteLine("name: "+myObj.Name+" roll no: "+ myObj.RollNo);
        }
    }
}