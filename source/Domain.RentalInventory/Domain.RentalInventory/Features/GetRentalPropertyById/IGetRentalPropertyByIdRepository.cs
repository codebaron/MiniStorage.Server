// <copyright file="IGetRentalPropertyByIdRepository.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.GetRentalPropertyById
{
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models;

    public interface IGetRentalPropertyByIdRepository
    {
        Task<RentalProperty> GetRentalPropertyById(long id);
    }
}
