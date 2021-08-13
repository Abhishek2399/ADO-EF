using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Pen : IComparable //to implement sort in testList.cs
    {
        #region EVENT
        //1.creating delegates for event. i.e CREATING DEFN OF EVENT.
        public delegate void RateHandler(string msg);
        public event RateHandler RateChange; //ratehchange is event name depends on ratehandler.

        //2.RAISING OF EVENT.
        public void NewRate(int rate)
        {
            int oldrate = this.Rate;
            this.Rate = rate; //assigning current rate to the new rate.
            if (RateChange != null) //safety to write if before raising the event whether event has been handled or not in both cases it is fine.
                RateChange($"Rates of pen has been changed from {oldrate} to {this.Rate}");  //call the event.we wont get the msg if the event has not been hanlded by client. this is y we are not getting this line printed in our case. but it is fine.
        }

        //3. Handling in TestEvent part.
        #endregion
        public string Color { get; set; }
        public int Rate { get; set; }

        public int CompareTo(object obj)
        //this method is due to Icomparable, obj is the object coming into that and we have to compare it with current object.
        {
            Pen p = obj as Pen; //local pen object
            if (this.Rate > p.Rate) //descending order //sorting in order of rate.
                return -1;
            else if (p.Rate > this.Rate)
                return 1;
            else return 0;
            //return string.Compare(p.Color, this.Color); //want to sort in order of colors. //descending order.
            //return string.Compare(this.Color, p.Color); //for ascending order.
        }

        public override string ToString()
        //will return string as required so that in testarraylist class it shows the string and not op as collections.pen.
        {
            return $"{Color}, {Rate}";
        }
        public void Multi(int x, int y)
        {
            Console.WriteLine($"Multiply = {x * y}");
        }
        public void Subs(int x, int y)
        {
            Console.WriteLine($"Substract = {x - y}");
        }
        public void Add(int x, int y)
        {
            Console.WriteLine($"Add = {x + y}");
        }

        //EVENT is raised whenever rate/color of pen is changed.

    }
}
