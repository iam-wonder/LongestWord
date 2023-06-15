using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace LongestWord
{
    internal class Program
    {
        /*static List<string> test = new List<string>();
        static int testNumber;*/
        public static string LongestWords(string sen)
        {
            int length = 0;
            List<string> words = sen.Split(' ').ToList();
            List<string> withoutSpecial = new List<string>();

            foreach (var temp in words)
            {
                withoutSpecial.Add(Regex.Replace(temp, @"[^0-9a-zA-Z\._]",""));
            }
           // withoutSpecial.FirstOrDefault(x=> x.Length >= x.CompareTo(withoutSpecial));
            foreach(var temp in withoutSpecial)
            {
                if(temp.Length >= length) { length = temp.Length;}
            }
            /*test = withoutSpecial;
            testNumber = length;  */
            sen = withoutSpecial.FirstOrDefault(x=>x.Length == length);
            return sen;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestWords(Console.ReadLine()));
         /*   Console.WriteLine("Number of Character:" + testNumber );
            foreach (var z in test)
            {
                Console.WriteLine(z);
            }*/
            
        }
    }
}
