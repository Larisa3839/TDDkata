using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Program
    {
        class StringCalculatorReturnZerro
        {

            public string Add(string s)
            {
                string str = "//";
                str += s;
                return str;
            }

            public string NewStr(string s)
            {
                string[] words = s.Split(new char[] { s[3], '\n', s[0], s[1] });
                
                string mas = "";
                foreach(string a in words)
                {
                    mas += a;
                }

                return mas;
            }

            public int Sum(string s)
            {
                
                int b = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    string sum = "";
                    sum += s[i];
                    b += Convert.ToInt32(sum);
                }
                
                //sum = Convert.ToInt16(s[1]);
                return Convert.ToInt32(b);
            }

        }

            static void Main(string[] args)
            {
            var calculator = new StringCalculatorReturnZerro();
            var str = calculator.Add("\n:1:2:7:6");
            var num = calculator.NewStr(str);
            var sum = calculator.Sum(num);
            Console.WriteLine(sum);
            Console.Read();
            }
     }   
 }   
