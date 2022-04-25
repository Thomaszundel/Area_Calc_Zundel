using Area_Calc_Zundel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareAreaTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(25,ac.getSquareArea(5));
        }
        [TestMethod]
        public void SquareAreaOverloadTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(25, ac.getSquareArea("Five"));
        }
        [TestMethod]
        public void SquareAreaOverloadWrongInputTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(0, ac.getSquareArea("blah"));
        }
      
        [TestMethod]
        public void SquareAreaOverloadAllCapsTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(49, ac.getSquareArea("SEVEN"));
        }
        [TestMethod]
        public void SquareAreaOverloadAllLowersTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(1, ac.getSquareArea("one"));
        }
        [TestMethod]
        public void RectangleAreaTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(30, ac.getRectangleArea(5,6));
        }
        [TestMethod]
        public void TriangleAreaTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(15, ac.getTriangleArea(5,6));
        }
        [TestMethod]
        public void ParallelogramAreaTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(30, ac.getParallelogramArea(5,6));
        }
        [TestMethod]
        public void CircleRadiusTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(0.80, ac.getCircleRadius(5));
        }
        [TestMethod]
        public void CircleDiameterTest()
        {
            AreaCalculator ac = new AreaCalculator();

            Assert.AreEqual(10, ac.CircleDiameter(5));
        }
    }
}