//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp14
//{
//    public class Class3
//    {
//        static void Main(string[] args)
//        {
//            String name = "Test";
//            Char[] chars = new char[] { 'H', 'E', 'L', 'L', 'O' };
//            String msg = new string(chars);
//            Console.WriteLine(msg);
//            //single singlechar printuse below code
//            for (int i = 0; i < name.Length; i++)
//            {
//                Console.WriteLine(name[i] + "");
//            }
//            String Str1 = "Hello";
//            String Str4 = "hello";
//            String Str2 = "Good Afternoon";
//            //join 2 string using concatination
//            String Str3 = String.Concat(Str1, Str2);
//            Console.WriteLine(Str3);
//            //contains function
//            bool result = Str2.Contains("Afternoon");
//            Console.WriteLine(result);
//            //equal chk value use equal function
//            if (Str1.Equals(Str4))
//            {
//                Console.WriteLine("Both Strings are same");
//            }
//            else
//            {
//                Console.WriteLine("Both strings are different");
//            }
//            //GetHashcodefunction use to print address location of particular string
//            Console.WriteLine(Str1.GetHashCode());
//            Console.WriteLine(Str2.GetHashCode());
//            //ToCharArray function converts string to char
//            Char[] ch = Str2.ToCharArray();
//            for (int i = 0; i < ch.Length; i++)
//            {
//                Console.WriteLine(ch[i]);
//            }
//            //IsNullorEmpty function is used to chk string is null or empty or having value
//            if (String.IsNullOrEmpty(Str4))
//            {
//                Console.WriteLine("Str4 is empty or null");
//            }
//            else
//            {
//                Console.WriteLine($"Ste4={Str4}");
//            }

//            //conert into upper case use function ToUpper
//            Console.WriteLine(Str2.ToUpper());
//            //for lower case use function ToLower
//            Console.WriteLine(Str2.ToLower());

//            //Trim function is used to removerspace from both left andright side
//            Str2.Trim();
//            //to remoestarting space use TrimStart()
//            Str2.TrimStart();
//            //to remoer end space use TrimEnd()
//            Str2.TrimEnd();

//            //Substring function is used to seperate words from string
//            String newString = Str2.Substring(5, 5);
//            Console.WriteLine(newString);

//        }
//    }
//}
