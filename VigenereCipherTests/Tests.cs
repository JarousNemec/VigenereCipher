using System;
using NUnit.Framework;
using VigenerCipher;

namespace VigenereCipherTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GeneratingSquare()
        {
            VigenereCipherProcessor processor = new VigenereCipherProcessor();
            var square = processor.GenerateVigenerSquare(65, 91);
             if(square[0,0] == 'A' && square[1,1] == 'C' &&square[2,2] == 'E' &&square[3,3] == 'G' &&square[4,4] == 'I')
                 Assert.Pass();
             Assert.Fail();
        }
        [Test]
        public void EncodingBySquare()
        {
            VigenereCipherProcessor processor = new VigenereCipherProcessor();
            var square = processor.GenerateVigenerSquare(65, 91);
            Assert.AreEqual("BBC",processor.EncodeFromSquare(square, "ABA", "BAC"));
        }
        
        [Test]
        public void DecodingBySquare()
        {
            VigenereCipherProcessor processor = new VigenereCipherProcessor();
            var square = processor.GenerateVigenerSquare(65, 91);
            Assert.AreEqual("ABA",processor.DecodeFromSquare(square, "BBC", "BAC"));
        }
        
        [Test]
        public void EncodingByMath()
        {
            VigenereCipherProcessor processor = new VigenereCipherProcessor();
            var square = processor.GenerateVigenerSquare(65, 91);
            Assert.AreEqual("BBC",processor.EncodeByMath("ABA","BAC",'A'));
        }
        [Test]
        public void DecodingByMath()
        {
            VigenereCipherProcessor processor = new VigenereCipherProcessor();
            var square = processor.GenerateVigenerSquare(65, 91);
            Assert.AreEqual("ABA",processor.DecodeByMath("BBC","BAC",'A'));
        }
    }
}