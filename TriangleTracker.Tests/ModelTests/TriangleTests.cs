using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void Triangle_MakesInstanceOfTriangleWithThreeSideLengths_True()
    {
      Triangle testTriangle = new Triangle(2,3,5);
      Assert.AreEqual(2, testTriangle.Side1);
      Assert.AreEqual(3, testTriangle.Side2);
      Assert.AreEqual(5, testTriangle.Side3);
    }

    [TestMethod]
    public void IsTriangle_ReturnsTrueWhenAnySumOfTwoSidesIsGreaterThanThird_True()
    {
      Triangle testTriangle = new Triangle(2,3,2);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_ReturnsFalseWhenAnySumOfTwoSidesIsGreaterThanThird_False()
    {
      Triangle testTriangle2 = new Triangle(2,3,8);
      Assert.AreEqual(false, testTriangle2.IsTriangle());
    }

  }
}

// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }