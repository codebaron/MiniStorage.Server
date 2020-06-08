// <copyright file="RentalUnit.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Models
{
    using System.ComponentModel.DataAnnotations;
    using Domain.RentalInventory.Features.Common.Data;
    using Domain.RentalInventory.Models.Values;

    public class RentalUnit
    {
        internal RentalUnit()
        {
        }

        internal RentalUnit(RentalUnitData rentalUnitData)
        {
            this.Id = rentalUnitData.Id;
            this.Name = rentalUnitData.Name;
            this.RentalPropertyId = rentalUnitData.RentalPropertyId;
            this.RentalUnitSize = (RentalUnitSize)rentalUnitData.RentalUnitSize;
            this.RentalUnitStatus = (RentalUnitStatus)rentalUnitData.RentalUnitStatus;
            this.RentalUnitType = (RentalUnitType)rentalUnitData.RentalUnitType;
        }

        public long Id { get; internal set; }

        [Required]
        public string Name { get; internal set; }

        public long RentalPropertyId { get; internal set; }

        public RentalUnitSize RentalUnitSize { get; internal set; }

        public RentalUnitStatus RentalUnitStatus { get; internal set; }

        public RentalUnitType RentalUnitType { get; internal set; }
    }
}
