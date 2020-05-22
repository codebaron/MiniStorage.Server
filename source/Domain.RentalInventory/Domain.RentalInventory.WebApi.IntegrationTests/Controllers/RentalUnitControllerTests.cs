// <copyright file="RentalUnitControllerTests.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.IntegrationTests.Controllers
{
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models.Values;
    using Domain.RentalInventory.Models.Values.RentalUnit;
    using Domain.RentalInventory.WebApi.Controllers;
    using FluentAssertions;
    using MediatR;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RentalUnitControllerTests : ControllerTestsBase
    {
        [TestMethod]
        public async Task RentalUnitControllerShouldSearch()
        {
            // arrange
            var controller = new RentalUnitController(this.Resolve<IMediator>());
            var rentalUnitSearchRequest = new RentalUnitSearchRequest
            {
                RentalPropertyId = 1,
                RentalUnitStatus = RentalUnitStatus.Vacant,
            };

            // act
            var result = await controller.Search(rentalUnitSearchRequest).ConfigureAwait(false);

            // assert
            result.Should().NotBeNull();
        }
    }
}
