//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp14
//{
//    public class Book1
//    {
//        ////////////////make book class =id,name,price,author print list
//       public int id { get; set; }
//        public string name { get; set; }
//        public string author{ get; set; }
//        public int price { get; set; }
//        public override string ToString()
//        {
//            return $"id={id}, name={name}, price={price},author={author}";
//        }
//    }
//    public class Class1
//    {
//        static void Main(string[] args)
//        {
//            int[] arr1 = new int[3] { 1, 2, 3 };
//            Book1[] booklist = new Book1[3]
//            {
//                new Book1{id=101,price=899,name="ravan",author="xxx" },
//                 new Book1{id=101,price=899,name="ravn",author="aaa" },
//                 new Book1{id=101,price=899,name="ra",author="ppp" }

//                };
//            ///////////using for loop
//            for (int i = 0; i < booklist.Length; i++)
//            {
//                Console.WriteLine(booklist[i]);
//            }

//            ///////////using for each loop
//            foreach (int item in arr1)
//            {
//                Console.WriteLine(item);
//            }
//            foreach (Book1 bok in booklist)
//            {
//                Console.WriteLine(bok);
//            }


//        }
//    }
//}
