using System;
using Generics101.Interfaces;

namespace Generics101.Models;

public class GenericStorage<T> : IGenericStorage<T>
{
    private T _value = default!;
    public void Display() => Console.WriteLine(_value);

    public T Get() => _value;

    public void Set(T value) => _value = value;
}

//La oss si du lager en generic storage av typen int.
//Compileren lager så følgende klasse for deg. 

public class GenericStorageInt
{
    private int _value;
    public void Set(int val) => _value = val;
    public int Get() => _value;
    
}
