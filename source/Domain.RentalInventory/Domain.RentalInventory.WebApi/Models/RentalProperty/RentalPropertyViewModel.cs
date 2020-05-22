// <copyright file="RentalPropertyViewModel.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Models.RentalProperty
{
    using System;
    using Domain.RentalInventory.Models;

    public class RentalPropertyViewModel
    {
        public RentalPropertyViewModel(RentalProperty rentalProperty)
        {
            if (rentalProperty == null)
            {
                throw new ArgumentNullException(nameof(rentalProperty));
            }

            this.Id = rentalProperty.Id;
            this.Name = rentalProperty.Name;
        }

        public long Id { get; }

        public string Name { get; }
    }
}
