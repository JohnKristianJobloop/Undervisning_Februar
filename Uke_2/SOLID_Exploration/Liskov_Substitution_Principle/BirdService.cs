using System;

namespace SOLID_Exploration.Liskov_Substitution_Principle;

public static class BirdService
{
    public static void MakeBirdsFly(BirdsWithFlight bird) => bird.Fly();
}
