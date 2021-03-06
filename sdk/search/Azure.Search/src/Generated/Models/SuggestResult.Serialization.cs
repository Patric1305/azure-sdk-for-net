// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class SuggestResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Text != null)
            {
                writer.WritePropertyName("@search.text");
                writer.WriteStringValue(Text);
            }
            foreach (var item in this)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
        internal static SuggestResult DeserializeSuggestResult(JsonElement element)
        {
            SuggestResult result = new SuggestResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Text = property.Value.GetString();
                    continue;
                }
                result.Add(property.Name, property.Value.GetObject());
            }
            return result;
        }
    }
}
