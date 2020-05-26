// <copyright file="SearchRentalUnitsHandlerTests.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.UnitTests.Features.SearchRentalUnits
{
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Features.GetRentalPropertyById;
    using Domain.RentalInventory.Features.SearchRentalUnits;
    using Domain.RentalInventory.Test.Common.TestData.ObjectMothers;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;

    [TestClass]
    public class SearchRentalUnitsHandlerTests
    {
        [TestMethod]
        public async Task SearchRentalUnitsHandlerShouldHandleSearchRentalUnitsRequest()
        {
            // arrange
            var repository = Substitute.For<ISearchRentalUnitsRepository>();
            var handler = new SearchRentalUnitsHandler(repository);
            var request = new SearchRentalUnitsRequest();

            // act
            var response = await handler.Handle(request, CancellationToken.None).ConfigureAwait(false);

            // assert
            response.Should().NotBeNull();
        }
    }
}
