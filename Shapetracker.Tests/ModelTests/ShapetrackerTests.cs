using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class ShapeTrackerTests
  {
    [TestMethod]
    public void IsTriangle_AllSidesEqual_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(4, 4, 4));
    }
  }
}  