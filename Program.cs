using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pollymorphism
{
    class shape
    {
        protected int width, height;
        public shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("parent class area : ");
            return 0;
        }
    }
    class Rectangel : shape
    {
        public Rectangel(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area : ");
            return (width * height);
        }
    }
    class Triangle : shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b) { }
        public override int area()
        {
            Console.WriteLine("Triangel Class area : ");
            return (width * height / 2);
        }
    }
    class Caller
    {
        public void CallArea(shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Caller c = new Caller();
                Rectangel r = new Rectangel(10,80);
                Triangle t = new Triangle(10,6);
                c.CallArea(r);
                c.CallArea(t);

            }
        }
    }
}

