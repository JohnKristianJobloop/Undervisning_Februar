using System;

namespace Generics101.Interfaces;

public interface IGenericStorage<T>
{
    public T Get();
    public void Set(T value);
    public void Display();
}
