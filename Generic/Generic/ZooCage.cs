using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
     class ZooCage<T,U> where T  : Animal, new() where U : Food, new()
    {
        public T Animal { get; set; }
        public U Food { get; set; }

        public ZooCage()
        {
               Animal = new T();
               Food = new U();
        }
    }
}
