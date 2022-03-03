using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        protected int numberOfSides;

        public int Sides
        {
            get
            {
                return numberOfSides;
            }
        }

        public Shape(int sides)
        {
            numberOfSides = sides;
        }

        public abstract double CalculateArea();

        public abstract void Draw();

    }

    public class Circle : Shape
    {
        public double Circle_radius { private set; get; }
        public Circle(double r) : base(0)
        {
            Circle_radius = r;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Circle_radius, 2) * 3.141596;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    public class Square : Shape
    {
        public double Side_length { private set; get; }

        public Square(double Side_length) : base(4)
        {
            this.Side_length = Side_length;
        }

        public override double CalculateArea()
        {
            return Side_length * Side_length;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing square");
        }
    }

    public class Rectangle : Shape
    {
        public double width { private set; get; }
        public double height { private set; get; }

        public Rectangle(double width, double height) : base(4)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }

    }

}
