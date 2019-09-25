using ConsoleApp.Config;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceProviderBuilder.GetInstance().GetServiceProvider();

            Console.ReadLine();
        }
    }
}
