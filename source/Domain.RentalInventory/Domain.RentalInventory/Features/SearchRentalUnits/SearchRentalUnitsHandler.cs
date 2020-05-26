// <copyright file="SearchRentalUnitsHandler.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class SearchRentalUnitsHandler : IRequestHandler<SearchRentalUnitsRequest, SearchRentalUnitsResponse>
    {
        private readonly ISearchRentalUnitsRepository searchRentalUnitsRepository;

        public SearchRentalUnitsHandler(ISearchRentalUnitsRepository searchRentalUnitsRepository)
        {
            this.searchRentalUnitsRepository = searchRentalUnitsRepository;
        }

        public Task<SearchRentalUnitsResponse> Handle(SearchRentalUnitsRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new SearchRentalUnitsResponse());
        }
    }
}
