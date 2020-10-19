// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ReservationSummary
    {
        internal static ReservationSummary DeserializeReservationSummary(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<string> reservationOrderId = default;
            Optional<string> reservationId = default;
            Optional<string> skuName = default;
            Optional<decimal> reservedHours = default;
            Optional<DateTimeOffset> usageDate = default;
            Optional<decimal> usedHours = default;
            Optional<decimal> minUtilizationPercentage = default;
            Optional<decimal> avgUtilizationPercentage = default;
            Optional<decimal> maxUtilizationPercentage = default;
            Optional<string> kind = default;
            Optional<decimal> purchasedQuantity = default;
            Optional<decimal> remainingQuantity = default;
            Optional<decimal> totalReservedQuantity = default;
            Optional<decimal> usedQuantity = default;
            Optional<decimal> utilizedPercentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("reservationOrderId"))
                        {
                            reservationOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationId"))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("skuName"))
                        {
                            skuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservedHours"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reservedHours = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("usageDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usageDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("usedHours"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usedHours = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("minUtilizationPercentage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("avgUtilizationPercentage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            avgUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("maxUtilizationPercentage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("kind"))
                        {
                            kind = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasedQuantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            purchasedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("remainingQuantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remainingQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("totalReservedQuantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalReservedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("usedQuantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("utilizedPercentage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            utilizedPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ReservationSummary(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), reservationOrderId.Value, reservationId.Value, skuName.Value, Optional.ToNullable(reservedHours), Optional.ToNullable(usageDate), Optional.ToNullable(usedHours), Optional.ToNullable(minUtilizationPercentage), Optional.ToNullable(avgUtilizationPercentage), Optional.ToNullable(maxUtilizationPercentage), kind.Value, Optional.ToNullable(purchasedQuantity), Optional.ToNullable(remainingQuantity), Optional.ToNullable(totalReservedQuantity), Optional.ToNullable(usedQuantity), Optional.ToNullable(utilizedPercentage));
        }
    }
}
