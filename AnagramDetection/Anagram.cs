//a. Desc ­> One string is an anagram of another if the second is simply a
//rearrangement of the first. For example, 'heart' and 'earth' are anagrams...
//b. I/P ­> Take 2 Strings as Input such abcd and dcba and Check for Anagrams
//c. O/P ­> The Two Strings are Anagram or not....
using System;
using System.Collections;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramDetection
{
     class Anagram
    {
        public bool Display(string val1,string val2)
        {
            if (val1.Length != val2.Length) 
            { 
                return false;
            }
            char[] a = val1.ToLower().ToCharArray();
            char[] b = val2.ToLower().ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i].ToString()!= b[i].ToString())
                {
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
