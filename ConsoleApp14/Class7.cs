//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp14
//{
//    public class Class7
//    {
//        public class Student
//        {
//            public int rollno { get; set; }
//            public string name { get; set; }
//            public double percentage { get; set; }
//            static void Main(string[] args)
//            {
                

//            ArrayList studentlist = new ArrayList();
//                studentlist.Add(new Student { rollno = 1, name = "Pooja", percentage = 68.55 });
//                studentlist.Add(new Student { rollno = 2, name = "Pooja", percentage = 88.55 });
//                studentlist.Add(new Student { rollno = 3, name = "Pooja", percentage = 81.55 });
//                studentlist.Add(new Student { rollno = 4, name = "Pooja", percentage = 32.55 });
//                studentlist.Add(new Student { rollno = 5, name = "Pooja", percentage = 35.55 });
//                Console.WriteLine("-------------------------");
//                foreach(Student item in studentlist)
//                {
//                    if(item.percentage<35)
//                    {
//                        Console.WriteLine($"{item.rollno}-{item.name}-{item.percentage}");
//                    }
                    
//                }
//            }
//        }
//    }
//}
