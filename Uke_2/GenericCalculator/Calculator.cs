using System.Numerics;
using GenericCalculator.Interfaces;

namespace GenericCalculator;

public class Calculator<T> : ICalculator<T> where T : INumber<T>
{
    public T Add(T num1, T num2) => num1 + num2;

    public T Add(params T[] nums) => nums.Aggregate((total, value) => value + total);

    public T Multiply(T num1, T num2) => num1 * num2;

    public T Multiply(params T[] nums) => nums.Aggregate((total, value) => total * value);

    public T Subtract(T num1, T num2) => num1 - num2;

    public T Subtract(params T[] nums) => nums.Aggregate((total, value) => total - value);
}
