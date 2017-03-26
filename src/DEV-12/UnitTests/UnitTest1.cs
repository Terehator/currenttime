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
            Parser cp = new Parser();
            Assert.AreEqual('b', cp.ParseColor("Black"));
        }

        [TestMethod]
        public void ColorParser_whiteLowercaseInput_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual('w', cp.ParseColor("white"));
        }

        [TestMethod]
        public void ColorParser_blackLowercaseInput_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual('b', cp.ParseColor("black"));
        }

        [TestMethod]
        public void ColorParser_whiteOneSymbolInput_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual('w', cp.ParseColor("w"));
        }
        
        [TestMethod]
        public void ColorParser_blackOneSymbolInput_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual('b', cp.ParseColor("b"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of color")]
        public void ColorParser_InvalidInput_Test()
        {
            Parser cp = new Parser();
            cp.ParseColor("sax");
        }

        [TestMethod]
        public void CoordinateParser_InputWithSpaces_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual(new Coordinate(1, 1), cp.ParseCheckerCoordinate("    a    1    "));
        }

        [TestMethod]
        public void CoordinateParser_InputWithOutSpaces_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual(new Coordinate(1, 1), cp.ParseCheckerCoordinate("a1"));
        }
        
        [TestMethod]
        public void CoordinateParser_InputUppercase_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual(new Coordinate(1, 1), cp.ParseCheckerCoordinate("A1"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Only black fields are allowed")]
        public void CoordinateParser_InputWhiteField_Test()
        {
            Parser cp = new Parser();
            cp.ParseCheckerCoordinate("a2");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputNotLetter_Test()
        {
            Parser cp = new Parser();
            cp.ParseCheckerCoordinate("22");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputLaterLetter_Test()
        {
            Parser cp = new Parser();
            cp.ParseCheckerCoordinate("i2");
        }
        
        [TestMethod]
        public void CoordinateParser_InputH_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual(new Coordinate(8,2), cp.ParseCheckerCoordinate("h2"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputLetterExceptDigit_Test()
        {
            Parser cp = new Parser();
            cp.ParseCheckerCoordinate("aa");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputLaterDigit_Test()
        {
            Parser cp = new Parser();
            cp.ParseCheckerCoordinate("i9");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException),
            "Wrong format of coordinate")]
        public void CoordinateParser_InputEarlierDigit_Test()
        {
            Parser cp = new Parser();
            cp.ParseCheckerCoordinate("i0");
        }
        
        [TestMethod]
        public void CoordinateParser_Input8_Test()
        {
            Parser cp = new Parser();
            Assert.AreEqual(new Coordinate(8, 8), cp.ParseCheckerCoordinate("h8"));
        }

        [TestMethod]
        public void StepsCounter_BlackReachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            Assert.AreEqual(5, sc.Count('b', new Coordinate(5, 7), new Coordinate(6, 2)));
        }

        [TestMethod]
        public void StepsCounter_WhiteReachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            Assert.AreEqual(5, sc.Count('w', new Coordinate(6, 2), new Coordinate(5, 7)));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_BlackFieldIsOnTheBack_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('b', new Coordinate(6, 2), new Coordinate(5, 7));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_WhiteFieldIsOnTheBack_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('w', new Coordinate(5, 7), new Coordinate(6, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_BlackUnreachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('b', new Coordinate(5, 7), new Coordinate(8, 6));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Not reachable field")]
        public void StepsCounter_WhiteUnreachableField_Test()
        {
            StepsCounter sc = new StepsCounter();
            sc.Count('w', new Coordinate(6, 2), new Coordinate(2, 4));
        }
    }
}
