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
            var filePath = @"C:\Cliente_Temp\Arquivos_ofx\stone\Extrato.ofx";

            var file = File.OpenText(filePath);
            var fi = new FileInfo(filePath);

            Extract extraxt = OFXParser.Parser.GenerateExtract(file);

            Console.WriteLine("Total de transações: " + extraxt.Transactions?.Count);
            Console.ReadKey();
        }
    }
}
