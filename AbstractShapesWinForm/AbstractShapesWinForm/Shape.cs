using System;
using System.Collections.Generic;
using System.Drawing;
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

        public abstract void Draw(Graphics g, int x, int y);

    }

    public class Circle : Shape
    {
        public double Radius { private set; get; }

        public Circle(double r) : base(0)
        {
            Radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }


        public override void Draw(Graphics g, int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    public class Square : Shape
    {
        public double Side { private set; get; }  // length of the side

        public Square(double side) : base(4)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override void Draw(Graphics g, int x, int y)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.Clear(Color.White);
            g.DrawRectangle(pen, x, y, (int)Side, (int)Side);

        }
    }


    public class Rectangle : Shape
    {
        public double Base { private set; get; }
        public double Height { private set; get; }

        public Rectangle(double b, double h) : base(3)
        {
            Base = b;
            Height = h;
        }

        public override double CalculateArea()
        {
            return Base * Height / 2;
        }

        public override void Draw(Graphics g, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
