﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptFinal
{
    abstract class Shape //Abstraction
    {
        public abstract int area();
    }

    class Rectangle1 : Shape //single inheritence
    {
        private int length;
        private int width;

        public Rectangle1(int a = 0, int b = 0) //polymorphism
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
}



