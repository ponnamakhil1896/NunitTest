using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment2;


namespace Assignment2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testingGetLength_areequal()
        {
            Rectangle rectangle = new Rectangle(3, 3, 3);
            int res = rectangle.GetLength();
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void testingGetLength_arenotequal()
        {
            Rectangle rectangle = new Rectangle(4, 4, 4);
            int res = rectangle.GetLength();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingGetLength_isTrue()
        {
            Rectangle rectangle = new Rectangle(5, 5, 5);
            int res = rectangle.GetLength();
            Assert.IsTrue(res == 5);
        }
        [TestMethod]
        public void testingSetLength_areequal()
        {
            Rectangle rectangle = new Rectangle();
            int len = 5;
            rectangle.SetLength(len);
            int res = rectangle.GetLength();
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void testingSetLength_arenotequal()
        {
            Rectangle rectangle = new Rectangle();
            int len = 5;
            rectangle.SetLength(len);
            int res = rectangle.GetLength();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingSetLength_istrue()
        {
            Rectangle rectangle = new Rectangle();
            int len = 5;
            rectangle.SetLength(len);
            int res = rectangle.GetLength();
            Assert.IsTrue(res == 5);
        }
        [TestMethod]

        public void testingGetWidth_areequal()
        {
            Rectangle rectangle = new Rectangle(3, 3, 3);
            int res = rectangle.GetWidth();
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void testingGetWidth_arenotequal()
        {
            Rectangle rectangle = new Rectangle(4, 4, 4);
            int res = rectangle.GetWidth();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingGetWidth_istrue()
        {
            Rectangle rectangle = new Rectangle(5, 5, 5);
            int res = rectangle.GetWidth();
            Assert.IsTrue(res == 5);
        }
        [TestMethod]
        public void testingSetWidth_areequal()
        {
            Rectangle rectangle = new Rectangle();
            int wid = 5;
            rectangle.SetWidth(wid);
            int res = rectangle.GetWidth();
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void testingSetWidth_arenotequal()
        {
            Rectangle rectangle = new Rectangle();
            int wid = 5;
            rectangle.SetWidth(wid);
            int res = rectangle.GetWidth();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingSetWidth_istrue()
        {
            Rectangle rectangle = new Rectangle();
            int wid = 5;
            rectangle.SetWidth(wid);
            int res = rectangle.GetWidth();
            Assert.IsTrue(res == 5);
        }
        [TestMethod]
        public void testingGetHeight_areequal()
        {
            Rectangle rectangle = new Rectangle(3, 3, 3);
            int res = rectangle.GetHeight();
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void testingGetHeight_arenotequal()
        {
            Rectangle rectangle = new Rectangle(4, 4, 4);
            int res = rectangle.GetHeight();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingGetHeight_istrue()
        {
            Rectangle rectangle = new Rectangle(5, 5, 5);
            int res = rectangle.GetHeight();
            Assert.IsTrue(res == 5);
        }
        [TestMethod]

        public void testingSetHeight_areequal()
        {
            Rectangle rectangle = new Rectangle();
            int hgt = 5;
            rectangle.SetHeight(hgt);
            int res = rectangle.GetHeight();
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void testingSetHeight_arenotequal()
        {
            Rectangle rectangle = new Rectangle();
            int hgt = 5;
            rectangle.SetHeight(hgt);
            int res = rectangle.GetHeight();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingSetHeight_istrue()
        {
            Rectangle rectangle = new Rectangle();
            int hgt = 5;
            rectangle.SetHeight(hgt);
            int res = rectangle.GetHeight();
            Assert.IsTrue(res == 5);
        }
        [TestMethod]

        public void testingGetVolume_areequal()
        {
            Rectangle rectangle = new Rectangle(3, 3, 3);
            int res = rectangle.GetVolume();
            Assert.AreEqual(27, res);
        }
        [TestMethod]
        public void testingGetVolume_arenotequal()
        {
            Rectangle rectangle = new Rectangle(4, 4, 4);
            int res = rectangle.GetVolume();
            Assert.AreNotEqual(3, res);
        }
        [TestMethod]
        public void testingGetVolume_istrue()
        {
            Rectangle rectangle = new Rectangle(5, 5, 5);
            int res = rectangle.GetVolume();
            Assert.IsTrue(res == 125);
        }
    }
}
