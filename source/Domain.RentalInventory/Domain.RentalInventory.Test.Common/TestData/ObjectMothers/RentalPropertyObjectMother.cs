// <copyright file="RentalPropertyObjectMother.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Test.Common.TestData.ObjectMothers
{
    using Domain.RentalInventory.Models;

    public static class RentalPropertyObjectMother
    {
        public static RentalProperty BuildingA => new RentalProperty
        {
            Id = 1,
            Name = "Building A",
        };
    }
}
