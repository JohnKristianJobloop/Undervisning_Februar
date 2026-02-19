using System;
using System.Numerics;

namespace Generics101.Models;

public static class GenericCalculator<T> where T : INumber<T>
{
    public static T Add(T num1, T num2) => num1 + num2;
}
