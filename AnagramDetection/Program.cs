using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramDetection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            Console.WriteLine("Enter the Value1:");
            string val1 = Console.ReadLine();
            Console.WriteLine("Enter the Value2:");
            string val2 = Console.ReadLine();
            if(anagram.Display(val1,val2))
            {
                Console.WriteLine("It is Anagram");
            }
            else
            {
                Console.WriteLine("Its not a Anagram");
            }
            Console.ReadKey();
        }
    }
}
