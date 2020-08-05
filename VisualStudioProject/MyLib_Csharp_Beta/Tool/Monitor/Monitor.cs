namespace MyLib_Csharp_Beta.Tool
{

    public class Monitor<T>
    {
        public T target;
        public Monitor(T init) => target = init;
        public bool IsChange(T input)
        {
            bool result = !target.Equals(input);
            target = input;
            return result;
        }
    }

}
