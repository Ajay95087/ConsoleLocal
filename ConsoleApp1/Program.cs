using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace consoleapp
{
    internal class Program
    {
        private static string a;

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

            /* int[] numbers = { 1, 2, 3, 4, 7, 8, 9 };

             foreach (int each in numbers)
             {
                 Console.WriteLine(each);
             }
             Console.ReadLine();*/




            //data types Example



            /*int a = 50;
            float b = 30.5F;
            double c = 20.995D;
            bool isGreat = true;
            char d = 'A';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a + b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();*/

            //type casting

            // there are two types of casting
            // 1.Implicit casting (automatically size to bigger types)
            // char to int to long to float to double

            /*int x = 6;
            double f = x;
            int z = 'f';
            Console.WriteLine(x);
            Console.WriteLine(f);
            Console.WriteLine(z);
            Console.ReadLine();*/


            // 2.Explicit casting (manually size to smaller types)

            //double x = (double)3.5;
            //Console.WriteLine(x);
            /*int x = 6;
            double f = x;
            float b = 'f';
            float var = Convert.ToInt16(4.55);
            string sx = "Random string";
            Console.WriteLine(x + f);
            Console.ReadLine();*/

            /*onsole.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello" + name);


            Console.WriteLine("How many candies doyou want");
            string can = Console.ReadLine();
            Console.WriteLine("You will get 4 candies" + 
                (Convert.ToInt32(can)+4));
             */

            // Arithmetic Operators


            /*int a = 4;
            int b = 2;

            Console.WriteLine("The value of a + b is : " + (a + b));
            Console.WriteLine("The value of a - b is : " + (a - b));
            Console.WriteLine("The value of a * b is : " + (a * b));

            Console.ReadLine();*/


            // AssignmentOperator


            /*int a = 4;
            int b = a;
            //b += 4;
            //b -= 4;
            b *= 4;
            Console.WriteLine(b);
            Console.ReadLine();*/


            //Logical Operator

            /*
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && true);



            Console.WriteLine(true ||false);
            Console.WriteLine(false|| false);
            Console.WriteLine(true ||true);
            Console.WriteLine(false|| true);
            Console.ReadLine(); */


            // Comparison Operator

            /* Console.WriteLine(324 > 555);
             Console.WriteLine(324 < 555);
             Console.WriteLine(324 <= 555);
             Console.WriteLine(324 >= 555);
             Console.WriteLine(324 != 555);

             Console.ReadLine();*/



            /*string hello = "Hello world this is Ajay";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello + "you are Nice");

            Console.ReadLine();*/


            /*string name = Console.ReadLine();
            string candies = Console.ReadLine();
            Console.WriteLine($"your name is {name}.you will get{candies}candies");
            Console.ReadLine();*/


            /*Console.WriteLine("Enter your age");
            string strage = Console.ReadLine();
            int age = Convert.ToInt32(strage);

            //int age = 59;
            if (age < 6)
            {
                Console.WriteLine("you are just born or banned");
            }
            else if (age<12)
            {
                Console.WriteLine("Plese finish your high school or maybe you are banned");
            }
            else if (age<18)
            {
                Console.WriteLine("you are below 18 ");
            }
            else if (age <75)
            {
                Console.WriteLine("you can Drive");
            }
            else 
            {
                Console.WriteLine("you cannot Drive");
            }


            Console.ReadLine();*/


            /*Console.WriteLine("Enter a number");

            string input = Console.ReadLine();
            //a Console.ReadLine();
            int a = Convert.ToInt32(input) * 2;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(input + " * " + i.ToString()+" =" + a.ToString());
            }
            //Console.WriteLine(input + " * " + "1 =" + a.ToString());
            //Console.WriteLine(input+" * "+ "2 ="+ a.ToString());
            //Console.WriteLine(input + " *" + "3 =" + a.ToString());
            //Console.WriteLine(input + " * " + "4 =" + a.ToString());
            //Console.WriteLine(input + " * " + "5 =" + a.ToString());
            //Console.WriteLine(input + " * " + "6 =" + a.ToString());
            //Console.WriteLine(input + " * " + "7 =" + a.ToString());
            //Console.WriteLine(input + " * " + "8 =" + a.ToString());
            //Console.WriteLine(input + " * " + "10 =" + a.ToString());
            Console.ReadLine();*/



            /*int a = 45;
            int b = 21;
            
            Console.WriteLine("The value is:" + (a + b));
            Console.WriteLine("The value is:" + (a - b));
            Console.WriteLine("The value is:" + (a * b));

            Console.ReadLine();*/


            /*Console.WriteLine("Press 1 for add");
            Console.WriteLine("Press 2 for sub");
            Console.WriteLine("Press 0 for exit");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Console.WriteLine("Enter First no");
                int firstno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second no");
                int secondno = Convert.ToInt32(Console.ReadLine());
                int result = firstno + secondno;
                Console.WriteLine("Result is " + result);
                Console.ReadLine();
            }

            */
            /*
            for (int i =1;i<=10;++i)
            {
                if (i == 5 || i== 6)
                {
                    continue;
                }
                Console.WriteLine(i + "");
                //if(i==5)
                //{
                //    break;
                //}
            }
            Console.ReadLine();
            */

            /*
            int i = 1;
            if(i==1)
            {
                Console.WriteLine("Hello codeing..");
                goto down;
            }

            Console.WriteLine("Ajay Kumar..");
        down:
            Console.WriteLine("Manshi ..");
            Console.ReadLine();
            */
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + "");
            }
            Console.ReadLine();
        }
    }
}
