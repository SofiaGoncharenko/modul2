using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<IFigure> list = new List<IFigure>();

                Console.WriteLine("Creating list of IFigure");
                list.Add(new Rectangle());
                list.Add(new Rectangle("r1", 2, 3));
                list.Add(new Circle());
                list.Add(new Circle("c1", 2));

                Console.Write("\n");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }

                Console.WriteLine("\nChanging parametrs of 1st rectangle");

                ((Rectangle)list[0]).A = 1;
                ((Rectangle)list[0]).B = 4;

                Console.WriteLine(((Rectangle)list[0]).Name);
                Console.WriteLine("a = " + ((Rectangle)list[0]).A);
                Console.WriteLine("b = " + ((Rectangle)list[0]).B);

                Console.WriteLine("\nChanging parametrs of 3rd circle");
                ((Circle)list[2]).R = 3;
                Console.WriteLine(((Circle)list[2]).Name);
                Console.WriteLine("r = " + ((Circle)list[2]).R);

                Console.WriteLine("\nFileWriter");

                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i] + "\n" + "Square = " + list[i].Square() + "\nPerimetr = " + list[i].Perimetr() + "\n");
                        sw.WriteLine(list[i] + "\n" + "Square = " + list[i].Square() + "\nPerimetr = " + list[i].Perimetr() + "\n");
                    }
                    sw.Close();
                }
                Console.WriteLine("\nResult in file 'result.txt'");

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
