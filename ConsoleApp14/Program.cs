//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp14
//{
    //public class Product
    //{
    //    private int id, price;
    //    private string name;
    //    public Product(int id, int price, string name)
    //    {
    //        this.id = id;
    //        this.price = price;
    //        this.name = name;
    //    }
    //    public override string ToString()
    //    {
    //        return $"id={id}, name={name}, price={price}";
    //    }
    //}
    //    public class Program
    //    { 
    //    static void Main(string[] args)
    //    {
    //        int[] arr1 = new int[3] { 1, 2, 3 };
    //        Product[] productlist = new Product[3]
    //        {
    //            new Product(101,899,"Mouse"),
    //            new Product(102,45009,"DellLaptop"),
    //            new Product(103,8909,"keyboard"),
    //        };
    //        ////////////using for loop
    //        for(int i=0; i<productlist.Length;i++)
    //        {
    //            Console.WriteLine(productlist[i]);
    //        }
            
    //        /////////////using for each loop
    //        foreach(int item in arr1)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        foreach(Product prod in productlist)
    //        {
    //            Console.WriteLine(prod);
    //        }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
           

            ///////below all code direct write in main methode here i have change above main so chk kit when again want to run
            
            //////////////DISPLAY MAX NUMBER FROM  NUMBER ARRAY
            //int[] array = { 10, 20, 30, 40, 50, 60, 65, 75, 85, 100 };
            //int max = array[0];
            //for(int i=0;i<=array.Length-1;i++)
            //{
            //    if (array[i]>max)
            //    {
            //        max = array[i];
            //    }
            //}
            //Console.WriteLine(max);


            ///////////////PRINT ALTERNATE NUMBERS FROM ARRAY
            //    int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //    int i, j, temp;
            //    Console.WriteLine("Enter your array");
            //    for (i = 1; i < array.Length; i++)
            //    { 
            // 
            //    Console.WriteLine("Alternate numbers of an gien array");
            //    for (i = 0; i < array.Length; i += 2)
            //        Console.WriteLine(array[i]);
            //}





            //////////////////delete all elements of anarray
            //ArrayList myList = new ArrayList(10);
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);
            //myList.Add(6);
            //Console.WriteLine("number of elements in array:" + myList.Count);
            //myList.Clear();
            //Console.WriteLine("number of element in arry:" + myList.Count);



            ///////////////reverse array of 5 number
            //int[] arr = { 10,20,30,40,50};
            //Console.WriteLine("Array data is:");
            //for(int i=0;i<5;i++)
            //    Console.WriteLine(arr[i] +"");
            //Console.WriteLine("\nArray in reverse order:=");
            //for(int i=4;i>=0;i--)
            //    Console.WriteLine(arr[i] +"");



            ////////////////chk armstrong or not
            //int r, sum = 0;
            //Console.WriteLine("Enter number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int temp = n;
            //while(n>0)
            //{
            //    r = n % 10;
            //    sum = sum + r * r * r;
            //    n = n / 10;
            //}
            //Console.WriteLine(sum);
            //if(temp==sum)
            //{
            //    Console.WriteLine("it is Armstron number");
            //}
            //else
            //{
            //    Console.WriteLine("not Armstrong number");
            //}



            ///////////////generate fibonacci serioes of 0 1 1 2 3 5 8 ---k
            //int f1=0, f2=1, f3;
            //Console.WriteLine("Enter upper Limit:");
            //int no = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{f1}{f2}");
            //for(int i=2;i<no;i++)
            //{
            //    f3 = f1 + f2;
            //    Console.WriteLine($"{f3}");
            //    f1 = f2;
            //    f2 = f3;
            //}



            /////////////////////sort array of 5 interger
            //int[] arr = new int[] { 67, 34, 89, 122, 45 };
            //int max = arr[0];
            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=0;j<arr.Length;j++)
            //    {
            //        int temp;
            //        if (arr[i] < arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Sorted elements:");
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine($"{arr[i]}");
            //}



            ////////////////find repeated number count from array
            //int[] arr = new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
            //int count = 0;
            //Console.WriteLine("enter no that you want to count from array:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (a == arr[i])
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"count of {a} is {count}");


            ////////////////factorial of number calculate


            ////////////////accept 2 number a and b and find alue of ab



            ///////////////accept matrix from user
            //int[,] arr1 = new int[4, 3];
            //Console.WriteLine("Accept 12 numbers");

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; i < 3; j++)
            //    {
            //        Console.WriteLine("Element {0},{1}={2}", i, j, arr1[i, j]);
            //    }
            //}



            ////////////////jagged array
            //int[][] jaggedArray = new int[4][];
            //jaggedArray[0] = new int[3] { 1, 2, 3 };
            //jaggedArray[1] = new int[5] { 1, 2, 3, 5, 6 };
            //jaggedArray[2] = new int[4] { 1, 2, 3, 4 };
            //jaggedArray[3] = new int[2] { 1, 2 };
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine("Element at row{i+1}");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine($"{jaggedArray[i][j]}");
            //    }
            //    Console.WriteLine();
            //}









//        }
//    }
//}
