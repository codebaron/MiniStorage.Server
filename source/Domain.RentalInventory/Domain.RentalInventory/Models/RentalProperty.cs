// <copyright file="RentalProperty.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RentalProperty
    {
        public RentalProperty(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public long Id { get; }

        [Required]
        public string Name { get; }
    }
}
