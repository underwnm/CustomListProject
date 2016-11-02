using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Item : IComparable<Item>
    {
        private string name;
        public Item(string name)
        {
            this.name = name;
        }
        public int CompareTo(Item other)
        {
            return name.CompareTo(other.name);
        }
    }
}
