using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace OnyxGenerator
{
    class Program
    {
        internal static void OnNitroGenerate()
        {
            _codes++;
            Thread.Sleep(50);
            Console.Title = $"{_title} | Codes Generated: {_codes.ToString()}";
        }
        internal static void OnWriteCodes()
        {
            _write++;
            Thread.Sleep(50);
            Console.Title = $"{_title} | Codes Wrote To File: {_write.ToString()}";
        }
        static void Main(string[] args)
        {
            Console.Title = "Onyx Generator | Made By Clxqz#0001";
            int startcount = 0;
            Console.ForegroundColor = ConsoleColor.Magenta;
            string ascii = @"
 ██████╗ ███╗   ██╗██╗██╗  ██╗     ██████╗ ███████╗███╗   ██╗
██╔═══██╗████╗  ██║██║╚██╗██╔╝    ██╔════╝ ██╔════╝████╗  ██║
██║   ██║██╔██╗ ██║██║ ╚███╔╝     ██║  ███╗█████╗  ██╔██╗ ██║
██║   ██║██║╚██╗██║██║ ██╔██╗     ██║   ██║██╔══╝  ██║╚██╗██║
╚██████╔╝██║ ╚████║██║██╔╝ ██╗    ╚██████╔╝███████╗██║ ╚████║
 ╚═════╝ ╚═╝  ╚═══╝╚═╝╚═╝  ╚═╝     ╚═════╝ ╚══════╝╚═╝  ╚═══╝
                                                             
";
            Console.WriteLine(ascii);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome To Onyx Generator");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\r\nhow much nitro you want?: ");
            int codes = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(""); 
            Console.WriteLine("\r\nGenerating.....");
            Thread.Sleep(1000);
            Console.Clear();
            while(true)
            {
                startcount += 1;

                OnNitroGenerate();
                Console.ForegroundColor = ConsoleColor.Yellow;
                string nitroCodes = $"https://discord.gift/{GenerateCodes(24)}";
                Console.WriteLine(nitroCodes);
                using (StreamWriter sw = File.AppendText("nitro.txt"))
                {
                    sw.WriteLine(nitroCodes);
                }
                if (startcount == codes)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Generated {startcount} Codes...");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.Write("\r\nWould You Like To Exit (y/n): ");
                    string choice = Console.ReadLine();
                    if(choice == "y")
                    {
                        Environment.Exit(-1);
                    }
                    else if (choice == "n")
                    {
                        Console.Clear();
                        Console.ReadKey();
                    }
                    break;
                }
            }

            Console.ReadKey();
        }
        
        private static Random random = new Random();
        public static string GenerateCodes(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        internal const string _title = "Generated";
        private static int _codes;
        private static int _write;
    }
}
