// <copyright file="SearchRentalUnitsRepository.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models;

    public class SearchRentalUnitsRepository : ISearchRentalUnitsRepository
    {
        public Task<IEnumerable<RentalUnit>> SearchRentalUnits(string name)
        {
            throw new NotImplementedException();
        }
    }
}
