// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class Tag : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteStringValue(Key);
            }
            writer.WriteEndObject();
        }

        internal static Tag DeserializeTag(JsonElement element)
        {
            Optional<string> key = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
            }
            return new Tag(key.Value);
        }
    }
}
