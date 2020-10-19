// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ReservationRecommendationsListResult
    {
        internal static ReservationRecommendationsListResult DeserializeReservationRecommendationsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ReservationRecommendation>> value = default;
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
                    List<ReservationRecommendation> array = new List<ReservationRecommendation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationRecommendation.DeserializeReservationRecommendation(item));
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
            return new ReservationRecommendationsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
