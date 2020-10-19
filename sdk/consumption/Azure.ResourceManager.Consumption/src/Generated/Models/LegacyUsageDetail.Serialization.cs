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
    public partial class LegacyUsageDetail
    {
        internal static LegacyUsageDetail DeserializeLegacyUsageDetail(JsonElement element)
        {
            UsageDetailsKind kind = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<string> billingAccountId = default;
            Optional<string> billingAccountName = default;
            Optional<DateTimeOffset> billingPeriodStartDate = default;
            Optional<DateTimeOffset> billingPeriodEndDate = default;
            Optional<string> billingProfileId = default;
            Optional<string> billingProfileName = default;
            Optional<string> accountOwnerId = default;
            Optional<string> accountName = default;
            Optional<string> subscriptionId = default;
            Optional<string> subscriptionName = default;
            Optional<DateTimeOffset> date = default;
            Optional<string> product = default;
            Optional<string> partNumber = default;
            Optional<Guid> meterId = default;
            Optional<MeterDetailsResponse> meterDetails = default;
            Optional<decimal> quantity = default;
            Optional<decimal> effectivePrice = default;
            Optional<decimal> cost = default;
            Optional<decimal> unitPrice = default;
            Optional<string> billingCurrency = default;
            Optional<string> resourceLocation = default;
            Optional<string> consumedService = default;
            Optional<string> resourceId = default;
            Optional<string> resourceName = default;
            Optional<string> serviceInfo1 = default;
            Optional<string> serviceInfo2 = default;
            Optional<string> additionalInfo = default;
            Optional<string> invoiceSection = default;
            Optional<string> costCenter = default;
            Optional<string> resourceGroup = default;
            Optional<string> reservationId = default;
            Optional<string> reservationName = default;
            Optional<string> productOrderId = default;
            Optional<string> productOrderName = default;
            Optional<string> offerId = default;
            Optional<bool> isAzureCreditEligible = default;
            Optional<string> term = default;
            Optional<string> publisherName = default;
            Optional<string> publisherType = default;
            Optional<string> planName = default;
            Optional<string> chargeType = default;
            Optional<string> frequency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new UsageDetailsKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("billingAccountId"))
                        {
                            billingAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingAccountName"))
                        {
                            billingAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodStartDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingPeriodStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodEndDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingPeriodEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"))
                        {
                            billingProfileId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountOwnerId"))
                        {
                            accountOwnerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionName"))
                        {
                            subscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("date"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            date = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("product"))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partNumber"))
                        {
                            partNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            meterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("meterDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            meterDetails = MeterDetailsResponse.DeserializeMeterDetailsResponse(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("quantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("effectivePrice"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            effectivePrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("cost"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cost = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("unitPrice"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            unitPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceLocation"))
                        {
                            resourceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumedService"))
                        {
                            consumedService = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceName"))
                        {
                            resourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo1"))
                        {
                            serviceInfo1 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo2"))
                        {
                            serviceInfo2 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalInfo"))
                        {
                            additionalInfo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSection"))
                        {
                            invoiceSection = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationId"))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationName"))
                        {
                            reservationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderId"))
                        {
                            productOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderName"))
                        {
                            productOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerId"))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAzureCreditEligible"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isAzureCreditEligible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("term"))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherName"))
                        {
                            publisherName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherType"))
                        {
                            publisherType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("planName"))
                        {
                            planName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("chargeType"))
                        {
                            chargeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("frequency"))
                        {
                            frequency = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LegacyUsageDetail(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), kind, billingAccountId.Value, billingAccountName.Value, Optional.ToNullable(billingPeriodStartDate), Optional.ToNullable(billingPeriodEndDate), billingProfileId.Value, billingProfileName.Value, accountOwnerId.Value, accountName.Value, subscriptionId.Value, subscriptionName.Value, Optional.ToNullable(date), product.Value, partNumber.Value, Optional.ToNullable(meterId), meterDetails.Value, Optional.ToNullable(quantity), Optional.ToNullable(effectivePrice), Optional.ToNullable(cost), Optional.ToNullable(unitPrice), billingCurrency.Value, resourceLocation.Value, consumedService.Value, resourceId.Value, resourceName.Value, serviceInfo1.Value, serviceInfo2.Value, additionalInfo.Value, invoiceSection.Value, costCenter.Value, resourceGroup.Value, reservationId.Value, reservationName.Value, productOrderId.Value, productOrderName.Value, offerId.Value, Optional.ToNullable(isAzureCreditEligible), term.Value, publisherName.Value, publisherType.Value, planName.Value, chargeType.Value, frequency.Value);
        }
    }
}
