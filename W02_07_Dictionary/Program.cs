using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_07_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dictionary - 1

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "een");
            dictionary.Add(2, "twee");
            //dictionary.Add(2, "een"); // error
            dictionary.Add(4, "drie");
            dictionary.Add(3, "vier");

            dictionary.Remove(3);

            //value of key: dictionary[key]
            Console.WriteLine(dictionary[4]);

            bool exist = dictionary.ContainsKey(3);
            exist = dictionary.ContainsValue("vier");

            #endregion

            #region Dictionary - 2

            Dictionary<string, string> trenDictionary = new Dictionary<string, string>();

            trenDictionary.Add("araba", "car");
            trenDictionary.Add("ev", "house");
            trenDictionary.Add("elma", "apple");

            string english = trenDictionary["elma"];

            foreach (var item in trenDictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            #endregion

            Console.ReadLine();
        }
    }
}