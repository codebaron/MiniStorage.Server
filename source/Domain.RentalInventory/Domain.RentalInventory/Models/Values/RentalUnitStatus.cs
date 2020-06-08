// <copyright file="RentalUnitStatus.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Models.Values
{
    public enum RentalUnitStatus
    {
        Vacant = 1,

        ManagementHold = 2,

        CustomerHold = 3,

        Rented = 4,

        Delinquent = 5,
    }
}
