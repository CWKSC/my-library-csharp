namespace MyLibCsharp.General;

public static class PrintExtension
{

    public static T Print<T>(this T value)
    {
        Console.Write(value);
        return value;
    }

    public static T Ln<T>(this T value, int times = 1)
    {
        new string('\n', times).Print();
        return value;
    }

    public static T[] Print<T>(this T[] array)
    {
        $"[{string.Join(", ", array)}]".Print();
        return array;
    }


    public static List<T> Print<T>(this List<T> list)
    {
        $"[{string.Join(", ", list)}]".Print();
        return list;
    }

    public static Dictionary<K, V> Print<K, V>(this Dictionary<K, V> dict)
        where K : notnull
    {
        foreach (var (key, value) in dict)
        {
            $"{key}: {value}".Print().Ln();
        }
        return dict;
    }

}
