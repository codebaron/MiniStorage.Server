// <copyright file="GetRentalPropertyByIdHandler.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.GetRentalPropertyById
{
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models;
    using MediatR;

    public class GetRentalPropertyByIdHandler : IRequestHandler<GetRentalPropertyByIdRequest, GetRentalPropertyByIdResponse>
    {
        public Task<GetRentalPropertyByIdResponse> Handle(GetRentalPropertyByIdRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetRentalPropertyByIdResponse(new RentalProperty()));
        }
    }
}
