namespace z_LeetCode.Question;

using static z_LeetCode.Question.Q1475_Final_Prices_With_a_Special_Discount_in_a_Shop;

[TestClass]
public class Q1475Test
{

    [TestMethod]
    public void TestCase1()
    {
        var testcase = new[] { 8, 4, 6, 2, 3 };
        var expect = new[] { 4, 2, 4, 2, 3 };
        var result = FinalPrices(testcase);
        CollectionAssert.AreEqual(result, expect);
    }

    [TestMethod]
    public void TestCase2()
    {
        var testcase = new[] { 1, 2, 3, 4, 5 };
        var expect = new[] { 1, 2, 3, 4, 5 };
        var result = FinalPrices(testcase);
        CollectionAssert.AreEqual(result, expect);
    }

    [TestMethod]
    public void TestCase3()
    {
        var testcase = new[] { 10, 1, 1, 6 };
        var expect = new[] { 9, 0, 1, 6 };
        var result = FinalPrices(testcase);
        CollectionAssert.AreEqual(result, expect);
    }

}
