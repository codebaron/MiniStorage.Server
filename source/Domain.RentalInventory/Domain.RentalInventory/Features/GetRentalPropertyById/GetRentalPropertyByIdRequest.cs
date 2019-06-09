// <copyright file="GetRentalPropertyByIdRequest.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.GetRentalPropertyById
{
    using MediatR;

    public class GetRentalPropertyByIdRequest : IRequest<GetRentalPropertyByIdResponse>
    {
        public GetRentalPropertyByIdRequest(int id)
        {
            this.Id = id;
        }

        public int Id { get; }
    }
}
