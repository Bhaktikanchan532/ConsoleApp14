using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Class9
    {
        static void Main(string[] args)
        {

            HashSet<string> set1 = new HashSet<string>();
            set1.Add("C");
            set1.Add("C++");
            set1.Add("java");
            set1.Add("C#");
            set1.Add("Ruby");

            HashSet<string> set2 = new HashSet<string>();
            set2.Add("php");
            set2.Add("C++");
            set2.Add("java");
            set2.Add("Perl");
            set2.Add("sql");
           //////// //union on hashset
           
           // set1.UnionWith(set2);

           /////////Intersect on hashset
           
           // set1.IntersectWith(set2);

            //////////Except on hashset
            set1.ExceptWith(set2);
            foreach(string s in set1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
