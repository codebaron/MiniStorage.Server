// <copyright file="GetRentalPropertyByIdHandler.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.GetRentalPropertyById
{
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class GetRentalPropertyByIdHandler : IRequestHandler<GetRentalPropertyByIdRequest, GetRentalPropertyByIdResponse>
    {
        private readonly IGetRentalPropertyByIdRepository getRentalPropertyByIdRepository;

        public GetRentalPropertyByIdHandler(IGetRentalPropertyByIdRepository getRentalPropertyByIdRepository)
        {
            this.getRentalPropertyByIdRepository = getRentalPropertyByIdRepository;
        }

        public async Task<GetRentalPropertyByIdResponse> Handle(GetRentalPropertyByIdRequest request, CancellationToken cancellationToken)
        {
            var rentalProperty = await this.getRentalPropertyByIdRepository.GetRentalPropertyById(request.Id).ConfigureAwait(false);

            return new GetRentalPropertyByIdResponse(rentalProperty);
        }
    }
}
