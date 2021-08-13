using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    //POLYMORPHISM.
    class Shapes
    {
        public virtual void CalcArea() //virtual is used for run time polymorphism.
        {
            Console.WriteLine("Shape area is calculated");
        }
    }
    class Circle : Shapes
    {
        public int Radius { get; set; }
        public override void CalcArea()
        {
            float area = (float)Math.PI * Radius * Radius;
            Console.WriteLine($"Circle area {area}");
        }
    }
    class Rectangle:Shapes
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public override void CalcArea()
        {
            int area = Length * Breadth;
            Console.WriteLine($"Rectangle area = {area}");
        }
    }
}
