using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToArrayConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // перетворення рядка в масив слів
            string str = "hi I am a superman";
            // поділ рядка по символу пробілу
             string[] strArray = str.Split(' ');
            foreach (var words in strArray)
                Console.WriteLine(words);
        }
    }
}
