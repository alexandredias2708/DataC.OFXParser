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
            var filePath = @"C:\Users\thiag\Downloads\extrato_Sicred_08_2023.ofx";
            
            var file = File.OpenText(filePath);
            var fi = new FileInfo(filePath);



            //var reader = new StreamReader(fi.FullName, Encoding.GetEncoding("iso-8859-1"));
            //fileText = reader.ReadToEnd();

            Extract extraxt = OFXParser.Parser.GenerateExtract(file);

            Console.WriteLine("Total: " + extraxt.Transactions?.Count);
            Console.ReadKey();
        }
    }
}
