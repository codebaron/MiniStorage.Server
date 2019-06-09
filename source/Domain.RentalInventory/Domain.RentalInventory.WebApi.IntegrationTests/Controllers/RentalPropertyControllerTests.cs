// <copyright file="RentalPropertyControllerTests.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.IntegrationTests.Controllers
{
    using System.Threading.Tasks;
    using Domain.RentalInventory.Test.Common.TestData.ObjectMothers;
    using Domain.RentalInventory.WebApi.Controllers;
    using FluentAssertions;
    using MediatR;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RentalPropertyControllerTests : ControllerTestsBase
    {
        [TestMethod]
        public async Task RentalPropertyControllerShouldGetPropertyById()
        {
            // arrange
            var controller = new RentalPropertyController(this.Resolve<IMediator>());

            // act
            var result = await controller.Get(RentalPropertyObjectMother.BuildingA.Id).ConfigureAwait(false);

            // assert
            result.Should().NotBeNull();
        }
    }
}
