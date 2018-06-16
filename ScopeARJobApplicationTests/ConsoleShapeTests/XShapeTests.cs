using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScopeARJobApplication.ConsoleShape;
using System;

namespace ScopeARJobApplicationTests
{
    [TestClass]
    public class XShapeTests
    {
        [TestMethod]
        public void TestCreation()
        {
            var testShape = new XShape(2);
            Assert.IsNotNull(testShape);
        }

        [TestMethod]
        public void TestDrawSize0()
        {
            var testShape = new XShape(0);
            Assert.AreEqual("", testShape.GetShape());
        }

        [TestMethod]
        public void TestDrawSize1()
        {
            var testShape = new XShape(1);
            Assert.AreEqual("x", testShape.GetShape());
        }


        [TestMethod]
        public void TestDrawSize2()
        {
            var testShape = new XShape(2);
            Assert.AreEqual("xx\nxx", testShape.GetShape());
        }
        [TestMethod]
        public void TestDrawSize3()
        {
            var testShape = new XShape(3);
            Assert.AreEqual("x x\n x \nx x", testShape.GetShape());
        }
        [TestMethod]
        public void TestDrawSize4()
        {
            var testShape = new XShape(4);
            Assert.AreEqual("x  x\n xx \n xx \nx  x", testShape.GetShape());
        }

        [TestMethod]
        public void TestDrawSize5()
        {
            var testShape = new XShape(5);
            Assert.AreEqual("x   x\n x x \n  x  \n x x \nx   x", testShape.GetShape());
        }

        [TestMethod]
        public void TesScaling()
        {
            var testShape = new XShape(100);

            var splitShape = testShape.GetShape().Split("\n");
            var actualLastLine = splitShape[splitShape.Length - 1];

            var expectedLastLine = "x" + new String(' ', 98) + "x";
            Assert.AreEqual(expectedLastLine, actualLastLine);
        }

        [TestMethod]
        public void DrawShape3Times()
        {
            var testShape = new XShape(3);
            Assert.AreEqual("x x\n x \nx x", testShape.GetShape());
            Assert.AreEqual("x x\n x \nx x", testShape.GetShape());
            Assert.AreEqual("x x\n x \nx x", testShape.GetShape());
        }
    }
}
