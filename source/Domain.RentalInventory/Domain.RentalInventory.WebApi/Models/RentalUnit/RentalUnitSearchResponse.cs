// <copyright file="RentalUnitSearchResponse.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Models.RentalUnit
{
    using System.Collections.Generic;

    public class RentalUnitSearchResponse
    {
        public ICollection<RentalUnitSearchResult> RentalUnitSearchResults { get; private set; }
    }
}
