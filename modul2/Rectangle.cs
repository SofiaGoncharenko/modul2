using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2
{
    class Rectangle: IFigure
    {
        private string name;
        private double a;
        private double b;

        public Rectangle()
        {
            name = "--";
            a = 0;
            b = 0;
        }

        public Rectangle(string name, double a, double b)
        {
            this.name = name;

            if (a > 0) this.a = a;
            else this.a = 0;

            if (b > 0) this.b = b;
            else this.b = 0;
        }

        public double A
        {
            get { return a; }
            set
            {
                if(value > 0)
                {
                    a = value;
                }
                else
                {
                    a = 0;
                }
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    b = 0;
                }
            }
        }

        public string Name
        {
            get { return name; }
        }

        public double Perimetr()
        {
            return (a + b) * 2;
        }

        public double Square()
        {
            return a * b;
        }

        public override string ToString()
        {
            return "Name is " + name + ", a = " + a + ", b = " + b;
        }
    }
}
