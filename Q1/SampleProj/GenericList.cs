class GenericList : IGenericList
{
    public void DoSomething<T>(T input)
    {
        if (typeof(T) == typeof(double))
        {
            System.Console.WriteLine($"Foo Number");
        }
        else
        {
            System.Console.WriteLine($"Foo {typeof(T)}");
        }
    }
}