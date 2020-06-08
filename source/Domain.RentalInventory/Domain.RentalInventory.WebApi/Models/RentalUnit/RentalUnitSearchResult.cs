// <copyright file="RentalUnitSearchResult.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Models.RentalUnit
{
    using Domain.RentalInventory.Models;
    using Domain.RentalInventory.Models.Values;

    public class RentalUnitSearchResult
    {
        internal RentalUnitSearchResult(RentalUnit rentalUnit)
        {
            this.RentalUnitId = rentalUnit.Id;
            this.RentalUnitName = rentalUnit.Name;
        }

        public long RentalUnitId { get; private set; }

        public string RentalUnitName { get; private set; }

        public int RentalPropertyId { get; private set; }

        public RentalUnitSize RentalUnitSize { get; private set; }

        public RentalUnitStatus RentalUnitStatus { get; private set; }

        public RentalUnitType RentalUnitType { get; private set; }
    }
}
