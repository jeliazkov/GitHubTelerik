//Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_user
{
    class HelloUser
    {
        static void SayHello(string userName)
        {
            Console.WriteLine("Hello, {0}",userName);
        }
        4
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            SayHello(name);
        }
    }
}
