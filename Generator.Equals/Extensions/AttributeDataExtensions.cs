﻿using System;

using Microsoft.CodeAnalysis;

namespace Generator.Equals.Extensions;

internal static class AttributeDataExtensions
{
    public static object? GetNamedArgumentValue(this AttributeData attributeData, string name)
    {
        _ = name ?? throw new ArgumentNullException(nameof(name));
        _ = attributeData ?? throw new ArgumentNullException(nameof(attributeData));

        foreach (var pair in attributeData.NamedArguments)
        {
            if (pair.Key == name)
            {
                return pair.Value.Value;
            }
        }

        return null;
    }
}