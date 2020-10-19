// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Details of estimated savings. </summary>
    public partial class ReservationRecommendationDetailsCalculatedSavingsProperties
    {
        /// <summary> Initializes a new instance of ReservationRecommendationDetailsCalculatedSavingsProperties. </summary>
        internal ReservationRecommendationDetailsCalculatedSavingsProperties()
        {
        }

        /// <summary> Initializes a new instance of ReservationRecommendationDetailsCalculatedSavingsProperties. </summary>
        /// <param name="onDemandCost"> The cost without reservation. </param>
        /// <param name="overageCost"> The difference between total reservation cost and reservation cost. </param>
        /// <param name="quantity"> The quantity for calculated savings. </param>
        /// <param name="reservationCost"> The exact cost of the estimated usage using reservation. </param>
        /// <param name="totalReservationCost"> The cost of the suggested quantity. </param>
        /// <param name="savings"> The amount saved by purchasing the recommended quantity of reservation. </param>
        internal ReservationRecommendationDetailsCalculatedSavingsProperties(float? onDemandCost, float? overageCost, float? quantity, float? reservationCost, float? totalReservationCost, float? savings)
        {
            OnDemandCost = onDemandCost;
            OverageCost = overageCost;
            Quantity = quantity;
            ReservationCost = reservationCost;
            TotalReservationCost = totalReservationCost;
            Savings = savings;
        }

        /// <summary> The cost without reservation. </summary>
        public float? OnDemandCost { get; }
        /// <summary> The difference between total reservation cost and reservation cost. </summary>
        public float? OverageCost { get; }
        /// <summary> The quantity for calculated savings. </summary>
        public float? Quantity { get; }
        /// <summary> The exact cost of the estimated usage using reservation. </summary>
        public float? ReservationCost { get; }
        /// <summary> The cost of the suggested quantity. </summary>
        public float? TotalReservationCost { get; }
        /// <summary> The amount saved by purchasing the recommended quantity of reservation. </summary>
        public float? Savings { get; }
    }
}
