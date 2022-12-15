/*1. Create a method that accepts user input
line, and displays statistics on this line.
Statistics should include the total number of characters, the number
space, number of digits, number of punctuation characters, number
letters and number of spaces.
2. The user enters a string and a character. Find everything in a string
occurrences of this character and convert it to uppercase, and
also remove part of the string starting from the last occurrence
this symbol to the end.
3. Remove repeated words from the string.
4. Convert all words according to the rule: remove everything from the word
subsequent occurrences of the first character.
5. Convert all words according to the rule: delete in word only
last occurrences of each character.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
   
    class Program
    {
        //1

        static void Statistics(string str)
        {
            int count = 0; int count2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                }
                else
                    count2++;
            }
            Console.WriteLine("Кол-во символов: " + count);
            Console.WriteLine("Кол-во пробелов: " + count2);
            Console.WriteLine("Кол-во чисел: " + str.Count(char.IsDigit));
            Console.WriteLine("Кол-во символов пунктуации: " + str.Count(char.IsPunctuation));
            Console.WriteLine("Кол-во символов букв: " + str.Count(char.IsLetter));

        }
        
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Statistics(str);
            //2
            //string theCutRes;

            //Console.WriteLine("Введите строку и символ: ");

            //string str = Console.ReadLine();
            //string symbol = Console.ReadLine();

            //var result = Regex.Replace(str, symbol, symbol.ToUpper());
            //Console.WriteLine(result);

            //symbol = symbol.ToUpper();

            //theCutRes = result.Remove(result.LastIndexOf(symbol));
            //Console.WriteLine(theCutRes);
            //3
            string SetenceString = "Hello word word my";
            string[] data = SetenceString.Split(' ');
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < data.Length; i++)
            {
                set.Add(data[i]);
            }
            set.ToList<String>().ForEach(x => Console.Write(x + ' '));
            //4
            //string SetenceString = "hello my world, how are you?";
            //string symbol = SetenceString.Substring(0, 1);
            //var result = Regex.Replace(SetenceString, symbol, "");
            //result = result.Insert(0, symbol);
            //Console.WriteLine(result);
            //5
            char[] charsToTrim = { '*', ' ', '?', '!', '.', '\'' };
            string[] mass = (Console.ReadLine()).Split(charsToTrim, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(mass[mass.Length - 1]);





        }

    }
}
