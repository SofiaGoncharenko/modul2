using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Sklad
    {
        protected int number;
        protected Tovar[] tovar;

        public Sklad()
        {
            number = 0;
            tovar = new Tovar[number];
        }

        public void Add(Tovar obj)
        {
            int temp = number;
            temp++;
            Tovar[] new_tovar = new Tovar[temp];

            for (int i = 0; i < number; i++)
            {
                new_tovar[i] = tovar[i];
            }

            new_tovar[temp - 1] = obj;

            tovar = new Tovar[temp];
            number++;

            for (int i = 0; i < number; i++)
            {
                tovar[i] = new_tovar[i];
            }
        }

        public void Output()
        {
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(tovar[i]);
            }
        }

        public void NameSort(bool k)
        {
            Array.Sort(tovar, 0, number, new CompareName1());
            if (k)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
            else
            {
                for (int i = number-1; i >= 0; i--)
                {
                    Console.WriteLine(tovar[i]);
                }
            }

        }

        public void PriceSort(bool k)
        {
            Array.Sort(tovar, 0, number, new ComparePrice());

            if (k)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
            else
            {
                for (int i = number - 1; i >= 0; i--)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
        }

        public void NumberSort(bool k)
        {
            Array.Sort(tovar, 0, number, new CompareNumber());

            if (k)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
            else
            {
                for (int i = number - 1; i >= 0; i--)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
        }

        public void TerminSort(bool k)
        {
            Array.Sort(tovar, 0, number, new CompareTermin());

            if (k)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
            else
            {
                for (int i = number - 1; i >= 0; i--)
                {
                    Console.WriteLine(tovar[i]);
                }
            }
        }
    }
}
