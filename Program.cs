using System;

namespace ConsoleAppAbstractCodeByParamsKeyword
{
    abstract class Shape
    {
        public int r, l, b, a;
        public abstract void accept(params int[] lst);
        public abstract void area();
        public void display()
        {
            Console.WriteLine("Hello Shape!!!");
        }

        public abstract void closing();

    }

    class Rectangle : Shape
    {
        public override void accept(params int[] lst)
        {
            l=2;
            foreach ( int num in lst)
            {
                Console.WriteLine("Enter the rectangle sides  :  " + "\n Length : " + l + "  Breadth : " + num);
                a = l*num;
            }
            //Console.WriteLine("Enter lenght and breadth");
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());

        }
        public override void area()
        {
        Console.WriteLine("The area of the rectangle is {0}", this.a);

        }

        public override void closing() { }

     }


    class Square : Shape
    {
        public override void accept(params int[] lst)
        {
            
           
            //l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(l);
            foreach (int num in lst)
            {
                Console.WriteLine("Enter the side for square :  " + num);
                a = num*num;
            }


        }

        public override void area()
        {
            
            Console.WriteLine("Area of the Square {0}", this.a);
        }

        public override void closing()
        {
            Console.WriteLine("Created Square");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Constructor Demo!");
            Rectangle rect = new Rectangle();
            Console.WriteLine("Working with Rectangle");
            //rect.display();
            rect.accept(4);
            rect.area();
           
            Console.WriteLine("Working with Square");

            Square sq = new Square();
            sq.accept(5);
            sq.area();
            sq.closing();
        }
    }
    
}

