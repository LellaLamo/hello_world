// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System;
namespace ConsoleApp1{
    static class Program {  
        // Main function, execution entry point of the program  
        static void Main(string[] args) {  
            foreach(string arg in args) {  
               Console.WriteLine("Hello " + arg);  
            }  
            Console.ReadLine();  
        }   
    }
}
