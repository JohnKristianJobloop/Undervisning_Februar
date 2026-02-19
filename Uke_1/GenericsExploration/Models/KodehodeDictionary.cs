using System;
using GenericsExploration.Interfaces;

namespace GenericsExploration.Models;

public class KodehodeDictionary<TKey, TValue> : IKodehodeDictionary<TKey, TValue>
{
    private LinkedList<DictionaryEntry<TKey, TValue>>[] _bucket {get;set;}

    public KodehodeDictionary(int capacity = 32)
    {
        _bucket = new LinkedList<DictionaryEntry<TKey, TValue>>[capacity];
    }
    public void Add(TKey key, TValue value)
    {
        var index = CreateBucketIndex(key);

        var entry = new DictionaryEntry<TKey, TValue>
        {
            Key = key,
            Value = value
        };

        var entryList = _bucket[index];
        entryList ??= new();

        entryList.AddFirst(entry);
        _bucket[index] = entryList;
    }
    private int _capacity => _bucket.Length;

    public bool TryGetValue(TKey key, out TValue value)
    {
        var result = false;

        var index = CreateBucketIndex(key);

        var entryList = _bucket[index];
        if (entryList is null)
        {
            value = default!;
        }
        else
        {
            value = entryList.FirstOrDefault(keyValuePair => keyValuePair.Key!.Equals(key))!.Value;
            result = true;
        }
        return result;
        
    }
    private int CreateBucketIndex(TKey key)
    {
        if (key is null) throw new ArgumentNullException(nameof(key));

        return Math.Abs(key.GetHashCode() % _capacity);
    }
}
