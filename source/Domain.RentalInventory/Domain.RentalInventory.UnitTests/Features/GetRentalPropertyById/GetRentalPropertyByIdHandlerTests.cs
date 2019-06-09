// <copyright file="GetRentalPropertyByIdHandlerTests.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.UnitTests.Features.GetRentalPropertyById
{
    using System.Threading;
    using Domain.RentalInventory.Features.GetRentalPropertyById;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GetRentalPropertyByIdHandlerTests
    {
        [TestMethod]
        public void GetRentalPropertyByIdHandlerShouldHandleGetPropertyByIdRequest()
        {
            // arrange
            var handler = new GetRentalPropertyByIdHandler();

            // act
            var response = handler.Handle(new GetRentalPropertyByIdRequest(0), CancellationToken.None);

            // assert
            response.Should().NotBeNull();
        }
    }
}
