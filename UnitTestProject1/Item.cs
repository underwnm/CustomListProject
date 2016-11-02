using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
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
            return this.name.CompareTo(other.name);
        }
    }
}
