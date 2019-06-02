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
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RentalPropertyControllerTests
    {
        [TestMethod]
        public async Task RentalPropertyControllerShouldGetPropertyById()
        {
            //// arrange

            // act
            ////var result = await RentalPropertyController.Get(RentalPropertyObjectMother.BuildingA.Id).ConfigureAwait(false);
            var result = await RentalPropertyController.Get().ConfigureAwait(false);

            // assert
            result.Should().NotBeNull();
        }
    }
}
