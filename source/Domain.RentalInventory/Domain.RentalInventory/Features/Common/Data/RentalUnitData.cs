// <copyright file="RentalUnitData.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.Common.Data
{
    public class RentalUnitData
    {
        ////public RentalUnitData(long id, string name, long rentalPropertyId, long rentalUnitSize, long rentalUnitStatus, long rentalUnitType)
        ////{
        ////    this.Id = id;
        ////    this.Name = name;
        ////    this.RentalPropertyId = rentalPropertyId;
        ////    this.RentalUnitSize = rentalUnitSize;
        ////    this.RentalUnitStatus = rentalUnitStatus;
        ////    this.RentalUnitType = rentalUnitType;
        ////}

        public long Id { get; set; }

        public string Name { get; set; }

        public long RentalPropertyId { get; set; }

        public long RentalUnitSize { get; set; }

        public long RentalUnitStatus { get; set; }

        public long RentalUnitType { get; set; }
    }
}
