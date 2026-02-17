using System;

namespace GenericsExploration.Models;

public class DictionaryEntry<TKey, TValue>
{
    public TKey Key {get;set;}
    public TValue Value {get;set;}
}
