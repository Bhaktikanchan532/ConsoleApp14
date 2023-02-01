//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp14
//{
//    public class Book
//    {
//////////////////make book class =id,name,price,author print list
//        private int id, price;
//        private string name, author;
//        public Book(int id, int price, string name, string author)
//        {
//            this.id = id;
//            this.price = price;
//            this.name = name;
//            this.author = author;
//        }
//        public override string ToString()
//        {
//            return $"id={id}, name={name}, price={price},author={author}";
//        }
//    }
//    public class Program1
//    {
//        static void Main(string[] args)
//        {
//            int[] arr1 = new int[3] { 1, 2, 3 };
//            Book[] booklist = new Book[3]
//            {
//                new Book(101,899,"ravan","xyz"),
//                new Book(101,500,"yayati","abc"),
//                new Book(101,1000,"blackwater","pqr")

//            };
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
//            foreach (Book bok in booklist)
//            {
//                Console.WriteLine(bok);
//            }


//        }
//    }
//}
