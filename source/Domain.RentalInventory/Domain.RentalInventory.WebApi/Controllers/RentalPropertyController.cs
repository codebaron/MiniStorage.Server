// <copyright file="RentalPropertyController.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Controllers
{
    using System.Threading.Tasks;
    using Domain.RentalInventory.Features.GetRentalPropertyById;
    using Domain.RentalInventory.WebApi.Models.RentalProperty;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class RentalPropertyController : Controller
    {
        private readonly IMediator mediator;

        public RentalPropertyController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET api/rentalproperty/1
        [HttpGet("{id}")]
        public async Task<RentalPropertyViewModel> Get(long id)
        {
            var request = new GetRentalPropertyByIdRequest(id);

            var response = await this.mediator.Send(request).ConfigureAwait(false);

            return new RentalPropertyViewModel(response.RentalProperty);
        }
    }
}
