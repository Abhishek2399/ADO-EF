using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class TestPolymorphism
    {
        static void Main()
        {
            //normal oop calling by objects.
            /*Shapes ss = new Shapes();
            ss.CalcArea();
            Circle c = new Circle { Radius = 5};
            c.CalcArea();
            Rectangle r = new Rectangle { Length = 30, Breadth= 20};
            r.CalcArea();*/

            // Runtime polymorphism way
            Shapes ss;
            ss = new Circle { Radius = 5 };
            Show(ss);
            ss = new Rectangle { Breadth = 20, Length = 30 };
            Show(ss);
            
        }
        public static void Show(Shapes shapes)
        {
            shapes.CalcArea();
        }
    }
}
