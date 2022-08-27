using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                int a = 1;
                int b = 2;
                Console.WriteLine("{0} - {1} - {2}", a, b);
                Console.ReadLine();
            } catch(Exception e){
                System.Console.WriteLine($"Error: {e.Message}");
            }
            
        }
    }
}