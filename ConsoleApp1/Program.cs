using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("For loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("while loop");
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine(a.ToString());
                a--;
            }
            Console.ReadLine();*/



            //variables

            /*string name = "Ajay";
            int age = 25;
            float height = 5.11f;

            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("Height" + height);
            Console.ReadLine(); */


            //Operator
            /*int x = 20;
            {
                Console.WriteLine(x > 3 && x < 30);
            }
            Console.ReadLine();*/


            //String

            /*string txt = "hello world";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            Console.ReadLine();*/


            string data = "apple, banana, mango";

            //data.ToUpper();
            //data.ToLower();


            string[] fruits = data.Split('-');

            foreach (var item in fruits) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(data.ToUpper());
            //Console.WriteLine(data.ToLower());

            Console.ReadLine();


        }
    }
}
