using System;

public class EnumSystem<T>
{
    public T Parse(string s)
    {
        return (T)Enum.Parse(typeof(T), s);
    }
}