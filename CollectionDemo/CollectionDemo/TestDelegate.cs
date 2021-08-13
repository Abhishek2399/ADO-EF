using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class TestDelegate
    {

        static void Main()
        {
            #region MultiCast delegates(this part is only for syntax and understanding purpose)
            //1.create instance of pen class
            Pen p = new Pen();
            //2. create instance of my delegate class
            MyDelegates delegates = new MyDelegates();
            MyDelegates.CalcDelegate calc = new MyDelegates.CalcDelegate(p.Add);
            //delegate is inner class so reference of parent class is rqd that is y we call CalDelegate method with Mydelegates as calcDelegate is inside mydelegate class.
            calc(70, 80);
            calc = p.Multi;
            calc(5, 7);

            //multicast delegate
            MyDelegates.CalcDelegate calc1 = new MyDelegates.CalcDelegate(p.Add);
            calc1 += p.Multi;
            calc1(9, 5);
            calc1 -= p.Add;
            calc1 += p.Subs;
            calc1(20, 4); //multiply n subs is done with 20 & 4.

            //multicast is done only on methods which donot have return values.
            #endregion

            //Function Callbacks.
            #region Function callbacks(this part is how actually used for doing codes.)
            MyDelegates md = new MyDelegates();
            MyDelegates.ToppingDelegate td = CheeseToppings;
            md.MakePizza(td, "Dominos");
            Console.WriteLine("========================");
            td = FruitToppings;
            md.MakePizza(td, "PizzaHut");
            MyDelegates.ToppingDelegate td1 = CheeseToppings;
            MyDelegates.ToppingDelegate td2 = FruitToppings;
            td = td1 + td2;
            md.MakePizza(td, "HomePizza");
            #endregion

            #region Sorting using Delegates.
            List<Pen> pens = new List<Pen>()
            {
                new Pen{Rate=10,Color="green" }, //collection initializers.similarly we have object initializers.collection of pens
            new Pen { Rate = 20, Color = "blue" },
            new Pen { Rate = 30, Color = "grey" },
            new Pen { Rate = 40, Color = "black" },
            new Pen { Rate = 50, Color = "red" },

            };
            MyDelegates.SortDelegate<Pen> sd = ColorSort; //if you want to create sort by rate then follow similar process.
            MyDelegates md1 = new MyDelegates();
            md1.MySort<Pen>(pens, sd);
            Console.WriteLine("=====================================");
            foreach(Pen pen in pens)
            {
                Console.WriteLine(pen);
            }
            #endregion
        }

        private static bool ColorSort(Pen x, Pen y)
        {
            return string.Compare(x.Color, y.Color) > 0; //for descending order <0.
        }

        private static void FruitToppings(string name)
        {
            Console.WriteLine("toppings is fruits");
            Console.WriteLine("no cheze used");
        }

        private static void CheeseToppings(string name)
        {
            Console.WriteLine($"pizza is made from {name}");
            Console.WriteLine("Cheese used is Mozarella");
            Console.WriteLine("Amul Cheese also used");
        }


    
    }
}
