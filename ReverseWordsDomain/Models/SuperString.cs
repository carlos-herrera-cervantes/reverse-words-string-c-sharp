using System.Collections.Generic;
using System.Text;

namespace ReverseWordsDomain.Models
{
    public class SuperString
    {
        /// <summary>Change the order of words of a given string</summary>
        /// <param name="str">String</param>
        /// <returns>String</returns>
        public static string ReverseString(string str)
        {
            str.Trim();

            var splited = str.Split(" ");
            var stack = new Stack<string>();

            foreach (var item in splited)
            {
                stack.Push(item);
            }

            var result = new StringBuilder();
            result.Append(stack.Pop());

            while (stack.Count != 0)
            {
                result.Append(" ");
                result.Append(stack.Pop());
            }

            return result.ToString();
        }
    }
}