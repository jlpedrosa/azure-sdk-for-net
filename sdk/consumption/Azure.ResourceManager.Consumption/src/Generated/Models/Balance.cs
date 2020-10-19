// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> A balance resource. </summary>
    public partial class Balance : Resource
    {
        /// <summary> Initializes a new instance of Balance. </summary>
        internal Balance()
        {
            NewPurchasesDetails = new ChangeTrackingList<BalancePropertiesNewPurchasesDetailsItem>();
            AdjustmentDetails = new ChangeTrackingList<BalancePropertiesAdjustmentDetailsItem>();
        }

        /// <summary> Initializes a new instance of Balance. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="currency"> The ISO currency in which the meter is charged, for example, USD. </param>
        /// <param name="beginningBalance"> The beginning balance for the billing period. </param>
        /// <param name="endingBalance"> The ending balance for the billing period (for open periods this will be updated daily). </param>
        /// <param name="newPurchases"> Total new purchase amount. </param>
        /// <param name="adjustments"> Total adjustment amount. </param>
        /// <param name="utilized"> Total Commitment usage. </param>
        /// <param name="serviceOverage"> Overage for Azure services. </param>
        /// <param name="chargesBilledSeparately"> Charges Billed separately. </param>
        /// <param name="totalOverage"> serviceOverage + chargesBilledSeparately. </param>
        /// <param name="totalUsage"> Azure service commitment + total Overage. </param>
        /// <param name="azureMarketplaceServiceCharges"> Total charges for Azure Marketplace. </param>
        /// <param name="billingFrequency"> The billing frequency. </param>
        /// <param name="priceHidden"> Price is hidden or not. </param>
        /// <param name="newPurchasesDetails"> List of new purchases. </param>
        /// <param name="adjustmentDetails"> List of Adjustments (Promo credit, SIE credit etc.). </param>
        internal Balance(string id, string name, string type, IReadOnlyDictionary<string, string> tags, string currency, decimal? beginningBalance, decimal? endingBalance, decimal? newPurchases, decimal? adjustments, decimal? utilized, decimal? serviceOverage, decimal? chargesBilledSeparately, decimal? totalOverage, decimal? totalUsage, decimal? azureMarketplaceServiceCharges, BillingFrequency? billingFrequency, bool? priceHidden, IReadOnlyList<BalancePropertiesNewPurchasesDetailsItem> newPurchasesDetails, IReadOnlyList<BalancePropertiesAdjustmentDetailsItem> adjustmentDetails) : base(id, name, type, tags)
        {
            Currency = currency;
            BeginningBalance = beginningBalance;
            EndingBalance = endingBalance;
            NewPurchases = newPurchases;
            Adjustments = adjustments;
            Utilized = utilized;
            ServiceOverage = serviceOverage;
            ChargesBilledSeparately = chargesBilledSeparately;
            TotalOverage = totalOverage;
            TotalUsage = totalUsage;
            AzureMarketplaceServiceCharges = azureMarketplaceServiceCharges;
            BillingFrequency = billingFrequency;
            PriceHidden = priceHidden;
            NewPurchasesDetails = newPurchasesDetails;
            AdjustmentDetails = adjustmentDetails;
        }

        /// <summary> The ISO currency in which the meter is charged, for example, USD. </summary>
        public string Currency { get; }
        /// <summary> The beginning balance for the billing period. </summary>
        public decimal? BeginningBalance { get; }
        /// <summary> The ending balance for the billing period (for open periods this will be updated daily). </summary>
        public decimal? EndingBalance { get; }
        /// <summary> Total new purchase amount. </summary>
        public decimal? NewPurchases { get; }
        /// <summary> Total adjustment amount. </summary>
        public decimal? Adjustments { get; }
        /// <summary> Total Commitment usage. </summary>
        public decimal? Utilized { get; }
        /// <summary> Overage for Azure services. </summary>
        public decimal? ServiceOverage { get; }
        /// <summary> Charges Billed separately. </summary>
        public decimal? ChargesBilledSeparately { get; }
        /// <summary> serviceOverage + chargesBilledSeparately. </summary>
        public decimal? TotalOverage { get; }
        /// <summary> Azure service commitment + total Overage. </summary>
        public decimal? TotalUsage { get; }
        /// <summary> Total charges for Azure Marketplace. </summary>
        public decimal? AzureMarketplaceServiceCharges { get; }
        /// <summary> The billing frequency. </summary>
        public BillingFrequency? BillingFrequency { get; }
        /// <summary> Price is hidden or not. </summary>
        public bool? PriceHidden { get; }
        /// <summary> List of new purchases. </summary>
        public IReadOnlyList<BalancePropertiesNewPurchasesDetailsItem> NewPurchasesDetails { get; }
        /// <summary> List of Adjustments (Promo credit, SIE credit etc.). </summary>
        public IReadOnlyList<BalancePropertiesAdjustmentDetailsItem> AdjustmentDetails { get; }
    }
}
