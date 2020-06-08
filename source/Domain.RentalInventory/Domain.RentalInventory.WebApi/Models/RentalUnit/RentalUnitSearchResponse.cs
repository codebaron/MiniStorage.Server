// <copyright file="RentalUnitSearchResponse.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Models.RentalUnit
{
    using System.Collections.Generic;
    using Domain.RentalInventory.Features.SearchRentalUnits;

    public class RentalUnitSearchResponse
    {
        internal RentalUnitSearchResponse(SearchRentalUnitsResponse searchRentalUnitsResponse)
        {
            this.RentalUnitSearchResults = new List<RentalUnitSearchResult>();

            foreach (var item in searchRentalUnitsResponse.RentalUnits)
            {
                this.RentalUnitSearchResults.Add(new RentalUnitSearchResult(item));
            }
        }

        public IList<RentalUnitSearchResult> RentalUnitSearchResults { get; private set; }
    }
}
