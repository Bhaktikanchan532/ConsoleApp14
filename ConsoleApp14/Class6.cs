using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Class5
    {
        static void Main(string[] args)
        {
            //using Stack
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();

            Console.WriteLine($"first element in the stack:{stack.Peek()}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }




            //using hashtable ex1
            //Hashtable ht = new Hashtable();
            //ht.Add(8551080100, "Pooja");
            //ht.Add(9549532532, "Arti");
            //ht.Add(8888532532, "nayan");
            //ht.Add("Test2", 67.77);
            //ht.Remove("Test2");
            //foreach(DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"{item.Key}-->{item.Value}");
            //}

            //hashtable ex2
            //Hashtable ht = new Hashtable();
            //ht.Add(100, "IND");
            //ht.Add(2, "USA");
            //ht.Add(8, "UK");
            //ht.Add("Test2", 67.77);
            //ht.Remove("Test2");
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"{item.Key}-->{item.Value}");
            //}


        }
    }
}
