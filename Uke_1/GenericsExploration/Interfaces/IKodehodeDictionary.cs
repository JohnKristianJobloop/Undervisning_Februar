using System;

namespace GenericsExploration.Interfaces;

public interface IKodehodeDictionary<TKey, TValue>
{
    public void Add(TKey key, TValue value);

    public bool TryGetValue(TKey key, out TValue value);
}
