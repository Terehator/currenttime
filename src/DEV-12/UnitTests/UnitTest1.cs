using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_12;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ColorParser_UppercaseInput_Test()
        {
            ColorParser cp = new ColorParser();
            Assert.AreEqual('b', cp.Parse("Black"));
        }

        [TestMethod]
        public void ColorParser_whiteLowercaseInput_Test()
        {
            ColorParser cp = new ColorParser();
            Assert.AreEqual('w', cp.Parse("white"));
        }

        [TestMethod]
        public void ColorParser_blackLowercaseInput_Test()
        {
            ColorParser cp = new ColorParser();
            Assert.AreEqual('b', cp.Parse("black"));
        }

        [TestMethod]
        public void ColorParser_whiteOneSymbolInput_Test()
        {
            ColorParser cp = new ColorParser();
            Assert.AreEqual('w', cp.Parse("w"));
        }
        
        [TestMethod]
        public void ColorParser_blackOneSymbolInput_Test()
        {
            ColorParser cp = new ColorParser();
            Assert.AreEqual('b', cp.Parse("b"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of color")]
        public void ColorParser_InvalidInput_Test()
        {
            ColorParser cp = new ColorParser();
            cp.Parse("sax");
        }

        [TestMethod]
        public void CoordinateParser_InputWithSpaces_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            Assert.AreEqual(new Tuple<int, int>(1,1), cp.Parse("    a    1    "));
        }

        [TestMethod]
        public void CoordinateParser_InputWithOutSpaces_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            Assert.AreEqual(new Tuple<int, int>(1, 1), cp.Parse("a1"));
        }
        
        [TestMethod]
        public void CoordinateParser_InputUppercase_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            Assert.AreEqual(new Tuple<int, int>(1, 1), cp.Parse("A1"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Only black fields are allowed")]
        public void CoordinateParser_InputWhiteField_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            cp.Parse("a2");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputNotLetter_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            cp.Parse("22");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputLaterLetter_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            cp.Parse("i2");
        }
        
        [TestMethod]
        public void CoordinateParser_InputH_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            Assert.AreEqual(new Tuple<int, int>(8,2), cp.Parse("h2"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputLetterExceptDigit_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            cp.Parse("aa");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputLaterDigit_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            cp.Parse("i9");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputEarlierDigit_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            cp.Parse("i0");
        }
        
        [TestMethod]
        public void CoordinateParser_Input8_Test()
        {
            CoordinateParser cp = new CoordinateParser();
            Assert.AreEqual(new Tuple<int, int>(8, 8), cp.Parse("h8"));
        }

        [TestMethod]
        public void StepsCounter_BlackReachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            Assert.AreEqual(5, sc.Count('b', new Tuple<int,int>(5, 7), new Tuple<int,int>(6, 2)));
        }

        [TestMethod]
        public void StepsCounter_WhiteReachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            Assert.AreEqual(5, sc.Count('w', new Tuple<int, int>(6, 2), new Tuple<int, int>(5, 7)));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_BlackFieldIsOnTheBack_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('b', new Tuple<int, int>(6, 2), new Tuple<int, int>(5, 7));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_WhiteFieldIsOnTheBack_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('w', new Tuple<int,int>(5, 7), new Tuple<int,int>(6, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_BlackUnreachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('b', new Tuple<int, int>(5, 7), new Tuple<int, int>(8, 6));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_WhiteUnreachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('w', new Tuple<int,int>(6, 2), new Tuple<int,int>(2, 4));
        }
    }
}
