// <copyright file="GetRentalPropertyByIdResponse.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.GetRentalPropertyById
{
    using Domain.RentalInventory.Models;

    public class GetRentalPropertyByIdResponse
    {
        public GetRentalPropertyByIdResponse(RentalProperty rentalProperty)
        {
            this.RentalProperty = rentalProperty;
        }

        public RentalProperty RentalProperty { get; }
    }
}
