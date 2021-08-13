using System;
using System.Collections; //for ienumerable class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class MyCalender:IEnumerable
    {
        string[] Weekdays = { "Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat" };
        string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Weekdays.Length; i++)
            {
                yield return Weekdays[i];
            }
        }
        public IEnumerable GetMonths()                     // we have to write method explicitly to get Months in this cases. 
        {
            for(int i = 0; i < Months.Length; i++)
            {
                yield return Months[i];
            }
        }

    }
}
