using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" Fun With Async ===>");
            //Console.WriteLine(DoWork());
            string message = await DoWorkAsync();
            Console.WriteLine(message);
            Console.WriteLine("Completed");
            Console.ReadLine();
        }

        static string DoWork()
        {
            Thread.Sleep(5_000);
            return "Done with work!";
//
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Done with work!";
            });
        }
    }
}
