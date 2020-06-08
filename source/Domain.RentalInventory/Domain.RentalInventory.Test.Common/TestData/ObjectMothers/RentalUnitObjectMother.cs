// <copyright file="RentalUnitObjectMother.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Test.Common.TestData.ObjectMothers
{
    using Domain.RentalInventory.Models;
    using Domain.RentalInventory.Models.Values;

    public static class RentalUnitObjectMother
    {
        public static RentalUnit UnitA13 => new RentalUnit
        {
            Id = 13,
            Name = "A13",
            RentalPropertyId = 1,
            RentalUnitSize = RentalUnitSize.Unit10x15,
            RentalUnitStatus = RentalUnitStatus.Vacant,
            RentalUnitType = RentalUnitType.ClimateControl,
        };
    }
}
