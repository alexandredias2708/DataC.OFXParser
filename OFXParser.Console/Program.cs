using OFXParser.Entities;
using System;
using System.IO;
using System.Text;

namespace OFXParser.ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filePath = @"C:\Users\thiag\Downloads\MEGA PACK 082021.OFX";
            //var filePath = @"C:\Users\thiag\Downloads\extrato_Sicred_08_2023.ofx";
            var filePath = @"C:\Users\thiag\Downloads\extrato (10).ofx";

            var file = File.OpenText(filePath);
            var fi = new FileInfo(filePath);


            Extract extraxt = OFXParser.Parser.GenerateExtract(file);

            Console.WriteLine("Total: " + extraxt.Transactions?.Count);
            Console.ReadKey();
        }
    }
}
