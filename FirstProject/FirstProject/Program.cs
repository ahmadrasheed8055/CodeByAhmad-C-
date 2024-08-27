using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Bismillah!");
             Console.WriteLine("Alhamdulil!");
             Console.WriteLine("AllahHuAkbar!");

             int a = 120229848;
             string name = "ALi";

             string s = "My name is " + name;
             string s1 = "My name is " + name;
             string s2 = "My name is " + name;
             string s3 = "My name is " + name;
             string s4 = "My name is " + name;

             Console.WriteLine(s);
             Console.WriteLine(s1);
             Console.WriteLine(s2);
             Console.WriteLine(s3);
             Console.WriteLine(s4);
             Console.WriteLine(a);*/

            /*Console.WriteLine("Rehman Rasheed");

            string name = Console.ReadLine();
            Console.WriteLine("My name is : " + name);*/

            string[] studentNames = { "ahmad", "ali", "asif" };

            /*Console.WriteLine();*/

            Console.WriteLine(greeting(studentNames[1]));

            /* if (greeting(studentNames[0]).Contains("ahmad"))
             {
                 Console.WriteLine("yes it contains ahmad");
             }
             else
             {
                 Console.WriteLine("No its not there");
             }*/

            switch (studentNames[0])
            {
                case "ahmad":
                    Console.WriteLine("Ahmad is a good student");
                    break;
                case "asif":
                    Console.WriteLine("Asif is a good student");
                    break;
                case "ali":
                    Console.WriteLine("Ali is a good student");
                    break;
                default: Console.WriteLine("None is good"); break;

            }

            int a = 0;

            while (a < 5)
            {
                /*We call it String interpolation*/
                Console.WriteLine($"Its {a}");
                a++;
            }



            /*2D Array*/
            int[,] _2d =
            {
                {12,45 },
                {55,90 }
            };

            Console.WriteLine(_2d[1, 0]);


            Console.WriteLine("=========OOP============");
            Room room1 = new Room("ADP", 23, "Best");

            Console.WriteLine(room1.Section);
            Console.WriteLine(room1.ClassFeedBack);
            Console.WriteLine(room1.TotalChairs);

            Console.WriteLine(Room.totalRooms);
        }

        public static string greeting(string studentName)
        {

            return "Hello " + studentName;
        }
    }
}
