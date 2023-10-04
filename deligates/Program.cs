namespace deligates
{
    delegate double mydeligate(double x, double y);
    class deligates
    {
        public static double area_triangle(double x, double y)
        {
            return x * y * 0.5;
        }
        public static double area_rect(double x , double y)
        {
            return x * y;
        }
    }
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            mydeligate obj = deligates.area_triangle;
            mydeligate obj1 = deligates.area_rect;
            //Console.WriteLine(deligates.add(a,b));
            Console.WriteLine("area of triangle: side " + a + " height " + b + " is : " + obj(a, b));
            Console.WriteLine("area of rectangle sides "+a+","+b+" is : " +obj1(a, b));
        }
    }
}