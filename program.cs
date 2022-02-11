using System;

namespace OopsConceptFinal
{
    class program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();

            Rectangle1 rect = new Rectangle1(10, 7);
            double a = rect.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
            Caller c = new Caller();
            Rectangle2 area = new Rectangle2(10, 7);
            Triangle triangle = new Triangle(10, 5);

            c.CallArea(area);
            c.CallArea(triangle);
            Console.ReadKey();


        }
    }
}
