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
        public SearchRentalUnitsRequest(
            int? rentalPropertyId,
            RentalUnitSize? rentalUnitSize,
            RentalUnitStatus? rentalUnitStatus,
            RentalUnitType? rentalUnitType)
        {
            this.RentalPropertyId = rentalPropertyId;
            this.RentalUnitSize = rentalUnitSize;
            this.RentalUnitStatus = rentalUnitStatus;
            this.RentalUnitType = rentalUnitType;
        }

        public int? RentalPropertyId { get; }

        public RentalUnitSize? RentalUnitSize { get; }

        public RentalUnitStatus? RentalUnitStatus { get; }

        public RentalUnitType? RentalUnitType { get; }
    }
}
