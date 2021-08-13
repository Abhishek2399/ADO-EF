using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace DemoReflection
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)] //allowmultiple-info attribute can be used in multiple class
    //AttributeTargets.Class means we can use this attribut only above classes. we cannot use them in properties or any other thing.
    class Info :Attribute
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
//this info class can also be done in .dll.