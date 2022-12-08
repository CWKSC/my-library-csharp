using MyLibCsharp.DataStructure.MonotonicStack;
using MyLibCsharp.General;

var monotonicStack = new MonotonicStackWithIndex<int>(false, true);
var nums1 = new int[] { 4, 1, 2 };
var nums2 = new int[] { 1, 3, 4, 2 };

var popsList = monotonicStack.PushRange(nums2);

var dict = new Dictionary<int, int>();
popsList.Loop((ele, index, listIndex) =>
{
    dict[nums2[index]] = nums2[listIndex];
});
dict.Print();



