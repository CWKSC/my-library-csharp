namespace z_LeetCode.Question;
using static z_LeetCode.Question.Q496_Next_Greater_Element_I;


[TestClass]
public class Q496Test
{

    [TestMethod]
    public void TestCase1()
    {
        var testcase_num1 = new[] { 4, 1, 2 };
        var testcase_num2 = new[] { 1, 3, 4, 2 };
        var expect = new[] { -1, 3, -1 };
        var result = NextGreaterElement(testcase_num1, testcase_num2);
        CollectionAssert.AreEqual(result, expect);
    }

    [TestMethod]
    public void TestCase2()
    {
        var testcase_num1 = new[] { 2, 4 };
        var testcase_num2 = new[] { 1, 2, 3, 4 };
        var expect = new[] { 3, -1 };
        var result = NextGreaterElement(testcase_num1, testcase_num2);
        CollectionAssert.AreEqual(result, expect);
    }

}
