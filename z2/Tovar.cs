using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Tovar
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Number { get; set; }
        public DateTime Termin { get; set; }

        public Tovar()
        {
            Name = String.Empty;
            Price = 0;
            Number = 0;
            Termin = DateTime.Now;
        }

        public Tovar(string name, double price, double number, DateTime termin)
        {
            Name = name;
            Price = price;
            Number = number;
            Termin = termin;
        }

        public override string ToString()
        {
            return "Name is " + Name + ", price = " + Price + ", number of elems = " + Number + ", termin is " + Termin.ToString("dd MMMM yyyy");
        }
    }
}
