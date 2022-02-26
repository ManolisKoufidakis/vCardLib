﻿using System.Collections.Generic;
using System.Linq;
using vCardLib.Deserialization.Interfaces;

namespace vCardLib.Deserialization.FieldDeserializers;

internal class CategoriesFieldDeserializer : IFieldDeserializer, IV2FieldDeserializer<List<string>>,
    IV3FieldDeserializer<List<string>>, IV4FieldDeserializer<List<string>>
{
    public string FieldKey => "CATEGORIES";

    public List<string> Read(string input)
    {
        input = input.ToUpper().Replace(FieldKey, string.Empty);
        var value = input.TrimStart(':');
        return value.Split(',').ToList();
    }
}