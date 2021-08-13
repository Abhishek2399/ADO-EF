using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    partial class PartialProduct
    {
        public string ShowProducts()
        {
            return string.Format($"Product name = {Name} , Cost = {Cost} ");
        }
    }
}
