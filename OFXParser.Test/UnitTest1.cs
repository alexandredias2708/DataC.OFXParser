using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFXParser.Core;
using OFXParser.Entities;

namespace OFXParser.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var filePath = @"C:\Users\thiag\Downloads\MEGA PACK 082021.OFX";
            var file = File.OpenText(filePath);
            Extract extraxt = OFXParser.Parser.GenerateExtract(file);


//            Extract extraxt = OFXParser.Parser.GenerateExtract("E:\\extract.ofx", new ParserSettings());
        }
    }
}
