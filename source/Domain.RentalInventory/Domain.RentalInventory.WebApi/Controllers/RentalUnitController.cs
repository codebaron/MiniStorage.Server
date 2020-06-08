// <copyright file="RentalUnitController.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Features.SearchRentalUnits;
    using Domain.RentalInventory.Models.Values.RentalUnit;
    using Domain.RentalInventory.WebApi.Models.RentalUnit;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class RentalUnitController : Controller
    {
        private readonly IMediator mediator;

        public RentalUnitController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // POST api/rentalunit/search
        [HttpPost]
        public async Task<ActionResult<RentalUnitSearchResponse>> Search([FromBody] RentalUnitSearchRequest rentalUnitSearchRequest)
        {
            if (rentalUnitSearchRequest == null)
            {
                throw new ArgumentNullException(nameof(rentalUnitSearchRequest));
            }

            var searchRentalUnitsRequest = new SearchRentalUnitsRequest(
                rentalUnitSearchRequest.RentalPropertyId,
                rentalUnitSearchRequest.RentalUnitSize,
                rentalUnitSearchRequest.RentalUnitStatus,
                rentalUnitSearchRequest.RentalUnitType);

            var searchResults = await this.mediator.Send(searchRentalUnitsRequest).ConfigureAwait(false);

            return this.Ok(new RentalUnitSearchResponse(searchResults));
        }
    }
}
