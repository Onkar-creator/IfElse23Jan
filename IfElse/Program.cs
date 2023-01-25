using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // 1.WAP in C sharp which can display given number is even or odd?
            Console.WriteLine("Q.1) WAP in C sharp which can display given number is even or odd?\n");
            int num;
            Console.WriteLine("Please Enter Any Number : ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
              Console.WriteLine("Given Number Is Even");
            }
            else
            {
                Console.WriteLine("Given Number Is Odd");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            // 2.WAP in C sharp which can display given number positive or negative?

            Console.WriteLine("Q.2) WAP in C sharp which can display given number positive or negative?\n");
            int num1;
            Console.WriteLine("Please Enter Any Positive or Negative Number : ");
            num1=Convert.ToInt32(Console.ReadLine());

            if (num1>=0)
            {
                Console.WriteLine(num1+ " is Positive Number");
            }
            else
            {
                Console.WriteLine(num1 + " is Negative Number");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            // 3.WAP in C sharp which can display largest number among two numbers ?

            Console.WriteLine("Q.3) WAP in C sharp which can display largest number among two numbers ?\n");
            Console.WriteLine("Please Enter 1st Number : ");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter 2nd Number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num2>num3)
            {
                Console.WriteLine(num2+ " Is larger than "+ num3);
            }
            else if(num2<num3)
            {
                Console.WriteLine(num3 + " Is larger than " + num2);
            }
            else
            {
                Console.WriteLine("Both Numbers Are Equal");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            // 4.WAP in C sharp which can display given character is vowel or consonents ?

            Console.WriteLine("Q.4) WAP in C sharp which can display given character is vowel or consonents ?\n");
            Console.WriteLine("Please Enter Any character : ");
            Char V = Convert.ToChar(Console.ReadLine());
            if ( V=='a' || V=='e' || V=='i' || V=='o' || V=='u' || V=='A' || V=='E' || V=='I' || V=='O' ||V=='U') 
            {
                Console.WriteLine(V+ " is Vowel");
            }
            else
            {
                Console.WriteLine(V+ " is Consonent");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            // 5.WAP in C sharp which can display given number is div by 5 and 10 ?

            Console.WriteLine("Q.5) WAP in C sharp which can display given number is div by 5 and 10 ?\r\n");
            Console.WriteLine("Please Enter Any Number : ");
            int num4=Convert.ToInt32(Console.ReadLine());

            if (num4%5==0 && num4%10==0)
            {
                Console.WriteLine(num4+" Is Divisible 5 And 10");    
            }
            else
            {
                Console.WriteLine(num4+ " Is Not Divisible By 5 And 10");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            // 6.WAP in C sharp which can display given year is leap or not leap?
            Console.WriteLine("Q.6) WAP in C sharp which can display given year is leap or not leap?\n");
            Console.WriteLine("Please Enter Year : ");
            int year=Convert.ToInt32(Console.ReadLine());

            if((year%4==0 && year%100!=0 ) || (year%400==0))
            {
                Console.WriteLine( $"{year} Is Leap Year");
            }
            else
            {
                Console.WriteLine(year+" Is Not Leap Year");
            }
            Console.ReadKey();
        }

    }
}
