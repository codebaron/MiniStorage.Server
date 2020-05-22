// <copyright file="RentalUnitSearchRequest.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Models.Values.RentalUnit
{
    public class RentalUnitSearchRequest
    {
        public int? RentalPropertyId { get; set; }

        public RentalUnitSize? RentalUnitSize { get; set; }

        public RentalUnitStatus? RentalUnitStatus { get; set; }

        public RentalUnitType? RentalUnitType { get; set; }
    }
}
