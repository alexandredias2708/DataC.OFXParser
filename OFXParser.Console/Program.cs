using OFXParser.Entities;
using System;
using System.IO;

namespace OFXParser.ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filePath = @"C:\Users\thiag\Downloads\MEGA PACK 082021.OFX";
            var filePath = @"C:\Users\thiag\Downloads\Sicoob mes 08.ofx";
            
            var file = File.OpenText(filePath);
            Extract extraxt = OFXParser.Parser.GenerateExtract(file);

            Console.WriteLine("Total: " + extraxt.Transactions?.Count);
            Console.ReadLine();
        }
    }
}
