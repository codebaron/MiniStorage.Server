// <copyright file="SearchRentalUnitsHandler.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models;
    using MediatR;

    public class SearchRentalUnitsHandler : IRequestHandler<SearchRentalUnitsRequest, SearchRentalUnitsResponse>
    {
        private readonly ISearchRentalUnitsRepository searchRentalUnitsRepository;

        public SearchRentalUnitsHandler(ISearchRentalUnitsRepository searchRentalUnitsRepository)
        {
            this.searchRentalUnitsRepository = searchRentalUnitsRepository;
        }

        public async Task<SearchRentalUnitsResponse> Handle(SearchRentalUnitsRequest request, CancellationToken cancellationToken)
        {
            var searchResults = await this.searchRentalUnitsRepository.SearchRentalUnits(
                request.RentalPropertyId,
                request.RentalUnitSize,
                request.RentalUnitStatus,
                request.RentalUnitType).ConfigureAwait(false);

            var results = new SearchRentalUnitsResponse(searchResults.ToList());

            return results;
        }
    }
}
