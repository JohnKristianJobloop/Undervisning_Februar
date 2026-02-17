using System;
using app.Models;

namespace app.Interfaces;

public interface IPersonService
{
    List<Person> People {get;set;}
    Person? Find(Func<Person, bool> comparison);
}
