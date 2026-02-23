using System;
using System.Numerics;

namespace GenericCalculator.Interfaces;

public interface ICalculator<T> where T : INumber<T>
{
    public T Add(T num1, T num2);
    public T Add(params T[] nums);

    public T Subtract(T num1, T num2);
    public T Subtract(params T[] nums);

    public T Multiply(T num1, T num2);
    public T Multiply(params T[] nums);
}
