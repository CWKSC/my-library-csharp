using MyLibCsharp.Algorithm;
using MyLibCsharp.DataStructure.MonotonicStack;
using MyLibCsharp.General;

var monotonicStack = new MonotonicStackWithIndex<int>(false, true);
var temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };

var distance = NextGreaterElement.NextGreaterElementRight(temperatures);
distance.Print();



//var popsList = monotonicStack.PushRange(temperatures);
//var distance = Enumerable.Repeat(0, temperatures.Length).ToArray();

//popsList.Loop((ele, index, listIndex) =>
//{
//    $"{ele} {index} {listIndex}".Print().Ln();
//    distance[index] = listIndex - index;
//});



