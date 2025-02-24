﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    private partial void Map(global::System.Collections.Generic.List<global::A>? source, global::RepeatedField<global::B> target)
    {
        if (source == null)
            return;
        foreach (var item in source)
        {
            target.Add(MapToB(item));
        }
    }

    private global::B MapToB(global::A source)
    {
        var target = new global::B();
        target.Value = source.Value;
        return target;
    }
}
