using System;

namespace SOLID_Exploration.Liskov_Substitution_Principle;

public class Birds
{
    
}

public class BirdsWithFlight : Birds
{
    public virtual void Fly() => Console.WriteLine("Flapping around");
}

public class Eagles : BirdsWithFlight
{
    public override void Fly() => Console.WriteLine("Soaring high!");
}

public class Penguins : Birds
{
    
}