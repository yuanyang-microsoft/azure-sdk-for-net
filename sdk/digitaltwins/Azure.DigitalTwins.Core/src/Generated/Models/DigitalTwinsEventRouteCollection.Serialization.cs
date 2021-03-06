// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    internal partial class DigitalTwinsEventRouteCollection
    {
        internal static DigitalTwinsEventRouteCollection DeserializeDigitalTwinsEventRouteCollection(JsonElement element)
        {
            Optional<IReadOnlyList<DigitalTwinsEventRoute>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DigitalTwinsEventRoute> array = new List<DigitalTwinsEventRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsEventRoute.DeserializeDigitalTwinsEventRoute(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DigitalTwinsEventRouteCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
