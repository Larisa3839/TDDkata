using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {


        class StringCalculatorReturnZerro
        {
            
            public string Add(string number)
            {
                string s1;
                s1 = "" + number;
                return s1;
            }

            public int Sum(string s)
            {
                string[] words = s.Split(new char[] { ',' });
                int sum = 0;
                if (s.Length == 0) return 0;
                else { 
                foreach (string a in words)
                {
                    sum += Convert.ToInt32(a);
                }
                return sum;
                }
            }
        }





        static void Main(string[] args)
        {
            var calculator = new StringCalculatorReturnZerro();
            var num = calculator.Add("2,1");
            var sum = calculator.Sum(num);
            Console.WriteLine(sum);
            //Console.Read();

        }
    }

}
