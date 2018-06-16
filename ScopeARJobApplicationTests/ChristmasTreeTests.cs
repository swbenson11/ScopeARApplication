using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScopeARJobApplication.ConsoleShape;

namespace ScopeARJobApplicationTests
{
    [TestClass]
    public class ChristmasTreeTests
    {
        [TestMethod]
        public void TestCreation()
        {
            var testShape = new ChristmasTreeShape(2);
            Assert.IsNotNull(testShape);
        }
        [TestMethod]
        public void TestDrawSize0()
        {
            var testShape = new ChristmasTreeShape(0);
            Assert.AreEqual("", testShape.GetShape());
        }

        [TestMethod]
        public void TestDrawSize1()
        {
            var testShape = new ChristmasTreeShape(1);
            Assert.AreEqual("x", testShape.GetShape());
        }


        [TestMethod]
        public void TestDrawSize2()
        {
            var testShape = new ChristmasTreeShape(2);
            Assert.AreEqual(" x \nxxx", testShape.GetShape());
        }

        [TestMethod]
        public void TestDrawSize3()
        {
            var testShape = new ChristmasTreeShape(3);
            Assert.AreEqual("  x  \n xxx \nxxxxx", testShape.GetShape());
        }

        [TestMethod]
        public void TestDrawSize5()
        {
            var testShape = new ChristmasTreeShape(5);
            Assert.AreEqual("    x    \n   xxx   \n  xxxxx  \n xxxxxxx \nxxxxxxxxx", testShape.GetShape());
        }

        [TestMethod]
        public void TestScaling()
        {
            var testShape = new ChristmasTreeShape(100);
            var expectedLastLine = new string('x', (100 * 2) - 1);
            var splitShape = testShape.GetShape().Split("\n");
            var actualLastLine = splitShape[splitShape.Length-1];

            Assert.AreEqual(expectedLastLine, actualLastLine);
        }
        [TestMethod]
        public void DrawShape3Times()
        {
            var testShape = new ChristmasTreeShape(3);
            Assert.AreEqual("  x  \n xxx \nxxxxx", testShape.GetShape());
            Assert.AreEqual("  x  \n xxx \nxxxxx", testShape.GetShape());
            Assert.AreEqual("  x  \n xxx \nxxxxx", testShape.GetShape());
        }
    }
}
