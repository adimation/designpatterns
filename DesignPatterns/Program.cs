using DesignPatterns._01_Creational.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiSingleton.SetLimit(4);
            
            for(int i = 0; i < 12; i++)
            {
                MultiSingleton ins = MultiSingleton.GetInstance();
                Console.WriteLine($"{i}: {ins.Id} - {ins.GetHashCode()}");
            }

            Console.ReadKey();
        }
    }
}
