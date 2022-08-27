using System;

namespace Syntax_SyntaxSugarEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less then nine" : $"{answer}is greater the nine";
            Console.WriteLine(response);

            //or for interaction

            var typeMe = int.Parse(Console.ReadLine());
            var responcex = (typeMe < 9) ? $"{typeMe} is less then nine" : $"{typeMe} is greater then nine";
            Console.WriteLine(responcex);
            
        }
    }
}
