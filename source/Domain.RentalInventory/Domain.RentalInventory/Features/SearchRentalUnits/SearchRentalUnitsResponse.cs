﻿// <copyright file="SearchRentalUnitsResponse.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using System.Collections.Generic;
    using Domain.RentalInventory.Models;

    public class SearchRentalUnitsResponse
    {
        public SearchRentalUnitsResponse(IList<RentalUnit> rentalUnits)
        {
            this.RentalUnits = rentalUnits;
        }

        public IList<RentalUnit> RentalUnits { get; }
    }
}
