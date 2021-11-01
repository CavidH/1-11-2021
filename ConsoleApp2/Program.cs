using System;
using System.Text;
using System.Xml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            try
            {
                input = Console.ReadLine();
                int lenth = input.Length;
                Console.WriteLine(lenth);
                Console.WriteLine(Trim(input).Length);
                 
            }
            catch (Exception)
            {
                Console.WriteLine("duzgun format daxil edin");
            }
        }

        static string Trim(String text)
        {
            int front = start(text);
            int Back = End(text);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = front; i < text.Length - Back; i++)
            {
                stringBuilder.Append(text[i]);
            }
            return stringBuilder.ToString();
        }

        static int start(String str)
        {
            int start = 0;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    start++;
                }
                else
                {
                    break;
                }
            }
            return start;
        }

        static int End(String str)
        {
            int End = 0;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    End++;
                }
                else
                {
                    break;
                }
            }
            return End;
        }
    }
}