using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sklad sklad_product = new Sklad();

            Dictionary<string, Action<bool>> dictionary = new Dictionary<string, Action<bool>>(4);
            dictionary.Add("CompareName", sklad_product.NameSort);
            dictionary.Add("ComparePrice", sklad_product.PriceSort);
            dictionary.Add("CompareNumber", sklad_product.NumberSort);
            dictionary.Add("CompareTermin", sklad_product.TerminSort);


            Tovar tov1 = new Tovar("Apple", 34.5, 200, new DateTime(2020, 05,11));
            sklad_product.Add(tov1);
            Tovar tov2 = new Tovar("Pear", 69.7, 70, new DateTime(2020, 04, 20));
            sklad_product.Add(tov2);
            Tovar tov3 = new Tovar("Potato", 23.8, 690, new DateTime(2020, 03, 24));
            sklad_product.Add(tov3);
            Tovar tov4 = new Tovar("Tomato", 57.4, 234, new DateTime(2020, 04, 10));
            sklad_product.Add(tov4);
            Tovar tov5 = new Tovar("Cherry", 34.12, 534, new DateTime(2020, 05, 13));
            sklad_product.Add(tov5);

            sklad_product.Output();

            Console.WriteLine("\nSorting\n");

            Console.WriteLine("\nSort by name in direct order");
            dictionary["CompareName"](true);
            Console.WriteLine("\nSort by name in reverse order");
            dictionary["CompareName"](false);

            Console.WriteLine("\nSort by price in direct order");
            dictionary["ComparePrice"](true);
            Console.WriteLine("\nSort by price in reverse order");
            dictionary["ComparePrice"](false);

            Console.WriteLine("\nSort by number in direct order");
            dictionary["CompareNumber"](true);
            Console.WriteLine("\nSort by number in reverse order");
            dictionary["CompareNumber"](false);

            Console.WriteLine("\nSort by termin in direct order");
            dictionary["CompareTermin"](true);
            Console.WriteLine("\nSort by termin in reverse order");
            dictionary["CompareTermin"](false);

            Console.ReadKey();
        }
    }
}
