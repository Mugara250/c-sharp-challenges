namespace c_sharp_challenges._18_11_2026;

#nullable enable

using System;
using System.Collections.Generic;

public static class CollectionSearch
{
    public static T? FindFirst<T>(
        IEnumerable<T>? items,
        Func<T, bool>? predicate)
    {
        if (items is null || predicate is null) throw new ArgumentNullException();
        foreach (var item in items)
        {
            if (predicate(item)) return item;
        }

        return default;
    }
}