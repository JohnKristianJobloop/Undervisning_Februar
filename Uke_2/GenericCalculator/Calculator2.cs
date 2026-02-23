using System;
using System.Numerics;
using GenericCalculator.Interfaces;

namespace GenericCalculator;

public class Calculator2<T> : ICalculator<T> where T : INumber<T>
{
    public T Add(T num1, T num2)
    {
        throw new NotImplementedException();
    }

    public T Add(params T[] nums)
    {
        throw new NotImplementedException();
    }

    public T Multiply(T num1, T num2)
    {
        throw new NotImplementedException();
    }

    public T Multiply(params T[] nums)
    {
        throw new NotImplementedException();
    }

    public T Subtract(T num1, T num2)
    {
        throw new NotImplementedException();
    }

    public T Subtract(params T[] nums)
    {
        throw new NotImplementedException();
    }
}
