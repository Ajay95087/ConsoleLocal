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



            /*string data = "apple, banana, mango";

            //data.ToUpper();
            //data.ToLower();


            string[] fruits = data.Split('-');

            // foreach

            foreach (var item in fruits) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(data.ToUpper());
            //Console.WriteLine(data.ToLower());

            Console.ReadLine();*/



            //Math

            /* int a = 5;

             Console.WriteLine(Math.Abs(a));
             Console.WriteLine(Math.Pow(3, 2));
             Console.WriteLine(Math.Sqrt(16));
             Console.WriteLine(Math.Max(10, 5));

             Console.ReadLine();*/




            //break    



            /*for (int i = 1; i <= 5; i++) 
            {
                if (i == 3)
                    break;

                Console.WriteLine(i);
            }

            Console.ReadLine();*/



            //continue




            /*for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            };

            Console.ReadLine();*/




            //Array + Loop



            /*string a = "";
            do
            {
                Console.WriteLine("Press 1 for add");
                Console.WriteLine("Press 2 for sub");
                Console.WriteLine("Press 0 for exit");
                a=Console.ReadLine();
                if (a == "1")
                {
                    Console.WriteLine("Enter First no");
                    int firstno =Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Enter second no");
                    int secondno = Convert.ToInt32(Console.ReadLine());
                    int result = firstno + secondno;
                    Console.WriteLine("Result is "+result);
                }
            } while (a != "0");*/




            //05-01-2025



            //String Length cheak


            /*
            string text = "hello World";
            Console.WriteLine("The length of text :" + text.Length);
            Console.ReadLine();*/

            // string to variable

            /*string msg = "hello";
            Console.WriteLine(msg);
            Console.ReadLine();*/

            //two string add

            /*string a = "Ajay";
            string b = "kumar";
            string result = a + " " + b;

            Console.WriteLine(result);
            Console.ReadLine();*/
            //hhhh



            //Array


            /*string fullname = "Ajay kumar singh";


            String[] part = fullname.Split(' ');

            String firstname = part[0];
            String middlename = part[1];
            String lastname = part[2];

            Console.WriteLine("Your first name is;" + firstname);
            Console.WriteLine("Your middle name is;" + middlename);
            Console.WriteLine("Your last name is;" + lastname);

            Console.ReadLine();*/




            /*string str = "Ajay,Kumar,Maurya";
            string[] a = str.Split(',');

            foreach(string ss in a)
            {
                System.Console.WriteLine(ss);
            }

            Console.ReadLine();*/


            /*string[]car = { "Bmw", "Volvo", "Mazda" } ;
            //Console.WriteLine(car.Length);
            for (int i = 0;i < car.Length; i++) 
            {
                Console.WriteLine(car[i]);
            }
            
            Console.ReadLine();*/

            /*int[] Number = {9, 20, 50, 8 } ;
            Console.WriteLine(Number.Max());
            Console.WriteLine(Number.Min());
            Console.WriteLine(Number.Sum());
            Console.WriteLine(Number.Sum (- Number.Min));

            Console.ReadLine();*/



            //one dimensional array with random numbers

            /*int[] numbers = { 1, 2, 3, 4, 5, };

            Random r = new ();

            for ( int i =0; i< numbers.Length; i++)

                {
                numbers[i] = r.Next();
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();*/

            //var

            /*{
                object thing = "string";

                var numbers = new int[5];

            }*/

            // foreach loop

            int[] numbers = { 1, 2, 3, 4, 7, 8, 9 };

            foreach (int each in numbers)
            {
                Console.WriteLine(each);
            }
            Console.ReadLine();

        }
    }
}
