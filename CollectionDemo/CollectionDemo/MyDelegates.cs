using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class MyDelegates
    {
        public delegate void CalcDelegate(int x, int y);
        public delegate void ToppingDelegate(string name);
        public delegate bool SortDelegate<T>(T x, T y); //bool as if conditions work on true and generic list as it can be any data type or object type also.
        public void MakePizza(ToppingDelegate td,string name)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Make Pizza sauce");
            Console.WriteLine("spread the sauce");
            Console.WriteLine("put the veggies");
            Console.WriteLine("**********************************");
            td(name); //associaitng the deligate object with what we want to do. combining what user wants and what is already there.like user wants toppigs type.we just define the signature and the op will be based on what user wants + already there code. this is FUNCTION CALLBACKS.

            Console.WriteLine("====================================");
            Console.WriteLine("put pizza in oven and bake");
            Console.WriteLine("pizza is ready");
        }

        public void MySort<T>(List<T> data, SortDelegate<T> sd)
        {
            for(int i=0;i<data.Count;i++)
            {
                for(int j = i + 1; j < data.Count; j++)
                {
                    if(sd(data[i],data[j]))
                    {
                        T temp = data[i]; //swapping.
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
}
