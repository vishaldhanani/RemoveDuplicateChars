using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    class Program
    {
        public static void Main(string[] args)
        {           
            RemoveDuplicateChars("Methodology");         
        }

        // A Linq approach:
        //public static string RemoveDuplicateChars(string input)
        //{
        //    return new string(input.ToCharArray().Distinct().ToArray());
        //}

        public static string RemoveDuplicateChars(string key)
        {
            // Remove duplicate chars using string concats.
            // ... Store encountered letters in this string.
            
            string result = "";

            foreach (char value in key)
            {
                // See if character is in the result already.
                if (result.IndexOf(value) == -1)
                {
                    // Append to the result.
                    result += value;
                }
            }
            return result;
      

        }

        //public static string RemoveDuplicateChars(string s)
        //{
        //    string newString = string.Empty;
        //    List<char> found = new List<char>();
        //    foreach (char c in s)
        //    {
        //        if (found.Contains(c))
        //            continue;

        //        newString += c.ToString();
        //        found.Add(c);
        //    }
        //    return newString;
        //}
    }
}
