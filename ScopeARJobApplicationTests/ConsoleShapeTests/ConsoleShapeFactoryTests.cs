using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScopeARJobApplication.ConsoleShape;


namespace ScopeARJobApplicationTests
{
    [TestClass]
    public class ConsoleShapeFactoryTests
    {
        [TestMethod]
        public void TestConsoleShapeFactoryCreation()
        {
            var factory = new ConsoleShapeFactory();
            Assert.IsNotNull(factory);
        }
        [TestMethod]
        public void TestChristmasTreeCreation()
        {
            var factory = new ConsoleShapeFactory();
            var testShape = factory.GetConsoleShape(ConsoleShapeEnum.ChistmasTreeShape, 2);
            Assert.IsNotNull(testShape);
        }

        [TestMethod]
        public void TestXShapeCreation()
        {
            var factory = new ConsoleShapeFactory();
            var testShape = factory.GetConsoleShape(ConsoleShapeEnum.XShape, 2);
            Assert.IsNotNull(testShape);
        }
    }
}