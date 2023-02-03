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
            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Pop();

            //Console.WriteLine($"first element in the stack:{stack.Peek()}");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}




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



            ////using SortedList
            //SortedList sl = new SortedList();
            //sl.Add(10,"IND");
            //sl.Add(1,"AUS");
            //sl.Add(30, "USA"); 
            //sl.Add(80, "UK");

            //Console.WriteLine($"total elements:"+sl.Count);
            //foreach (DictionaryEntry item in sl)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            ////SortedList ex2 add contact and name in sorted list
            //SortedList sortedList = new SortedList();
            //sortedList.Add(8551080100, "xxx");
            //sortedList.Add(8888532532,"yyy");
            //sortedList.Add(8881532532, "zzz");
            //sortedList.Add(9549532532, "ppp");

            //Console.WriteLine($"total elements:" + sortedList.Count);
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}


            //create an arraylist add number into it and use sort() and Revere()
            ArrayList mylist= new ArrayList();  
            mylist.Add(10);
            mylist.Add(25);
            mylist.Add(85);
            mylist.Add(35);
            mylist.Add(70);
            mylist.Add(65);
            Console.WriteLine("ArrayList before sort:");
            foreach(int item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList after sort:");
           mylist.Sort();
            mylist.Reverse();
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
