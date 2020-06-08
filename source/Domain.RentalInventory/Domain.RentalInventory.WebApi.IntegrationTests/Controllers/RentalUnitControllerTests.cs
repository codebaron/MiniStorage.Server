// <copyright file="RentalUnitControllerTests.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.IntegrationTests.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models.Values;
    using Domain.RentalInventory.Models.Values.RentalUnit;
    using Domain.RentalInventory.Test.Common.TestData.ObjectMothers;
    using Domain.RentalInventory.WebApi.Controllers;
    using Domain.RentalInventory.WebApi.Models.RentalUnit;
    using FluentAssertions;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
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
                RentalUnitType = RentalUnitType.ClimateControl,
            };

            // act
            var result = await controller.Search(rentalUnitSearchRequest).ConfigureAwait(false);

            // assert
            result.Should().NotBeNull()
                .And.BeOfType<ActionResult<RentalUnitSearchResponse>>();

            result.Result.Should().NotBeNull()
                .And.BeOfType<OkObjectResult>();

            var actionResult = result.Result.As<OkObjectResult>();
            actionResult.StatusCode.Should().Be((int)HttpStatusCode.OK);

            var searchResults = (RentalUnitSearchResponse)actionResult.Value;
            searchResults.RentalUnitSearchResults.Should().HaveCount(6)
                .And.Contain(r =>
                    r.RentalUnitId == RentalUnitObjectMother.UnitA13.Id &&
                    r.RentalUnitName == RentalUnitObjectMother.UnitA13.Name);
        }
    }
}
