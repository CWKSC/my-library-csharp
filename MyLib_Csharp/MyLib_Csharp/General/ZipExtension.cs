namespace MyLibCsharp.General;

public static class ZipExtension
{


    public static (T value, int index)[] ZipIndex<T>(this T[] array, int startIndex = 0)
    {
        var indexing = Enumerable.Range(startIndex, startIndex + array.Length).ToArray();
        return array.Zip(indexing).ToArray();
    }

    public static (T value, int index)[] ZipIndex<T>(this List<T> list, int startIndex = 0)
    {
        var indexing = Enumerable.Range(startIndex, startIndex + list.Count).ToArray();
        return list.Zip(indexing).ToArray();
    }

}
