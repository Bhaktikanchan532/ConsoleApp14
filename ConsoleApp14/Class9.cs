using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Class9
    {
        public string name { get; set; }
        public int Price { get; set; }
        static void Main(string[] args)
        {

            // HashSet<string> set1 = new HashSet<string>();
            // set1.Add("C");
            // set1.Add("C++");
            // set1.Add("java");
            // set1.Add("C#");
            // set1.Add("Ruby");

            // HashSet<string> set2 = new HashSet<string>();
            // set2.Add("php");
            // set2.Add("C++");
            // set2.Add("java");
            // set2.Add("Perl");
            // set2.Add("sql");
            ////////// //union on hashset

            //// set1.UnionWith(set2);

            ///////////Intersect on hashset

            //// set1.IntersectWith(set2);

            // //////////Except on hashset
            // set1.ExceptWith(set2);
            // foreach(string s in set1)
            // {
            //     Console.WriteLine(s);
            // }


            // WAP create generic list of product display it and also print product price greater than 2000
            List<Class9> productlist = new List<Class9>();
            productlist.Add(new Class9 { name = "mouse", Price = 899 });
            productlist.Add(new Class9 { name = "laptop", Price = 8199 });
            productlist.Add(new Class9 { name = "keyboard", Price = 999 });
            productlist.Add(new Class9 { name = "pen", Price = 199 });
            foreach(Class9 item in productlist)
            {
                if(item.Price>2000)
                {
                    Console.WriteLine($"{item.name} ,{item.Price}");
                }
            }    
        }
    }
}
