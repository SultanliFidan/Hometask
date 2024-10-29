using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
     class Meat : Food
    {
        public MeatType Type { get; set; }
    }

    public enum MeatType
    {
        Beef,
        Chicken,
        Fish
    }
}
