using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        class StringCalculator
        {

            public string Add(string s)
            {
                string str = "";
                str += s;
                return str;
            }

            public int Summa(string numbers)
            {
                string regex = @"[0-9 -]+";
                int sum = 0;
                int i = 0;

                if (numbers.Length == 0) return 0;
                else
                {

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



        }

        [TestMethod]
        public void Test1()
        {
            var calculator = new StringCalculator();
            var str = calculator.Add("");
            var sum = calculator.Summa(str);
            Assert.AreEqual(0, sum);
        }
        [TestMethod]
        public void Test2()
        {
            var calculator = new StringCalculator();
            var str = calculator.Add("1,2,3");
            var sum = calculator.Summa(str);
            Assert.AreEqual(1 + 2 + 3, sum);
        }
        [TestMethod]
        public void Test3()
        {
            var calculator = new StringCalculator();
            var str = calculator.Add("1\n2,3");
            var sum = calculator.Summa(str);
            Assert.AreEqual(1 + 2 + 3, sum);
        }
        [TestMethod]
        public void Test4()
        {
            var calculator = new StringCalculator();
            var str = calculator.Add("//;\n1;2");
            var sum = calculator.Summa(str);
            Assert.AreEqual(1 + 2, sum);
        }
        [TestMethod]
        public void Test5()
        {
            var calculator = new StringCalculator();
            var str = calculator.Add("-1,2");
            var sum = calculator.Summa(str);
            Assert.AreEqual(0, sum);
        }
    }
}
