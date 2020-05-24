using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2
{
    class Circle: IFigure
    {
        string name;
        double r;

        public Circle()
        {
            name = "--";
            r = 0;
        }

        public Circle(string name, double r)
        {
            this.name = name;
            if (r > 0) this.r = r;
            else this.r = 0;
        }

        public string Name
        {
            get { return name; }
        }

        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    r = 0;
                }
            }
        }

        public double Perimetr()
        {
            return 2 * Math.PI * r;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override string ToString()
        {
            return "Name is " + name + ", r = " + r;
        }
    }
}
