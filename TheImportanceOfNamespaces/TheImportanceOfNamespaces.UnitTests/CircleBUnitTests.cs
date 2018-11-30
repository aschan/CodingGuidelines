namespace TheImportanceOfNamespaces.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Outer.Inner;

    [TestClass]
    public class CircleBUnitTests
    {
        [TestMethod]
        public void CircumferenceTest()
        {
            var radius = 17;
            var expectedCircumference = 2 * System.Math.PI * radius;
            ICircle circle = new CircleB(radius);
            Assert.AreEqual(expectedCircumference, circle.Circumference);
        }

        [TestMethod]
        public void AreaTest()
        {
            var radius = 17;
            var expectedArea = System.Math.PI * radius * radius;
            ICircle circle = new CircleB(radius);
            Assert.AreEqual(expectedArea, circle.Area);
        }
    }
}