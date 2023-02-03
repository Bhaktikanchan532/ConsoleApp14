using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Class8
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
        List<int> ilist = new List<int>();
        ilist.Add(1);
            ilist.Add(2);
            ilist.Add(3);
            List<string> slist = new List<string>();
            slist.Add("Pune");
            slist.Add( "Mumbai");
            ilist.Insert(2, 0);
            slist.Insert(2, "Nagpur");
            ilist.AddRange(arr1);
            ilist.Remove(1);
            ilist.RemoveAt(4);
            ilist.RemoveRange(0, 3);
           // ilist.Clear();
            List<double> dlist = new List<double>();
            dlist.Add(45222.787);
            foreach(string item in slist)
            {
                Console.WriteLine(item);
            }
            foreach(int i in ilist)
            {
                Console.WriteLine(i);
            }
            List<Class8> productlist=new List<Class8>();
            productlist.Add(new Class8 { id = 1, name = "mouse", price = 850 });
            foreach(Class8 p in productlist)
            {
                Console.WriteLine(p);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
           // stack.Pop();
            //stack.Pop();
            foreach(var s in stack)
            {
                Console.WriteLine(s);
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("aaa");
            queue.Enqueue("bbb");
           // queue.Dequeue();
            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }
            Dictionary<int,string>dictionary=new Dictionary<int,string>();
            dictionary.Add(91,   "IND");
            dictionary.Add(65,   "AUS");
            foreach(KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine(item.Key+""+item.Value);
            }
        }
    }
}
