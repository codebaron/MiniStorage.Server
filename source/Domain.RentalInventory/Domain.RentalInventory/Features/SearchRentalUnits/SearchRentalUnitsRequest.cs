// <copyright file="SearchRentalUnitsRequest.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using Domain.RentalInventory.Models.Values;
    using MediatR;

    public class SearchRentalUnitsRequest : IRequest<SearchRentalUnitsResponse>
    {
        public int? RentalPropertyId { get; set; }

        public RentalUnitSize? RentalUnitSize { get; set; }

        public RentalUnitStatus? RentalUnitStatus { get; set; }

        public RentalUnitType? RentalUnitType { get; set; }
    }
}
