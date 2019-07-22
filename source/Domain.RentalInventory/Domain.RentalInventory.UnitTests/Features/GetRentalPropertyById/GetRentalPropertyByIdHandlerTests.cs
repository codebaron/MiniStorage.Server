// <copyright file="GetRentalPropertyByIdHandlerTests.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.UnitTests.Features.GetRentalPropertyById
{
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.RentalInventory.Features.GetRentalPropertyById;
    using Domain.RentalInventory.Test.Common.TestData.ObjectMothers;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;

    [TestClass]
    public class GetRentalPropertyByIdHandlerTests
    {
        [TestMethod]
        public async Task GetRentalPropertyByIdHandlerShouldHandleGetPropertyByIdRequest()
        {
            // arrange
            var repository = Substitute.For<IGetRentalPropertyByIdRepository>();
            repository.GetRentalPropertyById(Arg.Is(RentalPropertyObjectMother.BuildingA.Id)).Returns(RentalPropertyObjectMother.BuildingA);
            var handler = new GetRentalPropertyByIdHandler(repository);
            var request = new GetRentalPropertyByIdRequest(RentalPropertyObjectMother.BuildingA.Id);

            // act
            var response = await handler.Handle(request, CancellationToken.None).ConfigureAwait(false);

            // assert
            response.Should().NotBeNull();
            response.RentalProperty.Id.Should().Be(RentalPropertyObjectMother.BuildingA.Id);
            response.RentalProperty.Name.Should().BeEquivalentTo(RentalPropertyObjectMother.BuildingA.Name);
        }
    }
}
