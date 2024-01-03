namespace Programmers2024._01._03;
    using System;

    internal class Program
    {
        public string Solution(string my_string, string overwrite_string, int s)
        {
        my_string = "Program29b8UYP";
        overwrite_string = "merS123";
        s = 7;

            char[] c = overwrite_string.ToCharArray();
            string answer = my_string.Replace(my_string[s], c[0]);
            Console.WriteLine(answer);
            return answer;
        }
    }
    

