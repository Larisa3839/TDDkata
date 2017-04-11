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
        class StringCalculatorExceptionMessage
        {

            public string Add(string s)
            {
                string str = "//";
                str += s;
                return str;
            }

            public int Summa(string numbers)
            {
                string regex = @"[0-9, -]+";
                int sum = 0;
                int i = 0;

                foreach (Match match in Regex.Matches(numbers, regex))
                {
                    if (Convert.ToInt32(match.Value) > 0) sum += Convert.ToInt32(match.Value);
                    else
                    {
                        Console.WriteLine("{0} - is neegativ value.", Convert.ToInt32(match.Value));
                        i++;
                    }                 
                }

                if (i != 0) Console.WriteLine("Negatives not allowed!");
                else return sum;

                return 0;
                
            }



        }

        static void Main(string[] args)
        {


            var calculator = new StringCalculatorExceptionMessage();
            var str = calculator.Add("\n-1:-2");
            var sum = calculator.Summa(str);
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
