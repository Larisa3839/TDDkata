using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test4
{
    class Program
    {
        class StringCalculatorSupportDelimiters
        {

            public string Add(string s)
            {
                string str = "//";
                str += s;
                return str;
            }

            public int Summa(string numbers)
            {
                string regex = @"[0-9]+";
                int sum = 0;
                foreach (Match match in Regex.Matches(numbers, regex))
                {
                    sum += Convert.ToInt32(match.Value);
                    //Console.WriteLine(match.Value);
                }
                return sum;
            }

           

        }

            static void Main(string[] args)
            {


            var calculator = new StringCalculatorSupportDelimiters();
            var str = calculator.Add("\n1:2");
            var sum = calculator.Summa(str);
            Console.WriteLine(sum);
            Console.Read();
        }
     }   
 }   
