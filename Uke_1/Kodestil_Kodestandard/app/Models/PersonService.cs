using System;
using app.Interfaces;

namespace app.Models;

public class PersonService(List<Person> people) : IPersonService
{
    public List<Person> People { get; set;} = people;

    public Person? Find(Func<Person, bool> comparison) => People.FirstOrDefault(comparison);
}
