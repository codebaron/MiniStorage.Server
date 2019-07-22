// <copyright file="GetRentalPropertyByIdRepository.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.GetRentalPropertyById
{
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using Dapper;
    using Domain.RentalInventory.Models;

    public class GetRentalPropertyByIdRepository : IGetRentalPropertyByIdRepository
    {
        private const string ConnectionString = "Server=.;Database=RentalInventory;Integrated Security=True";
        private const string Sql = "SELECT Id, Name FROM RentalProperty WHERE Id = @Id";

        public async Task<RentalProperty> GetRentalPropertyById(long id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var rentalProperty = await connection.QuerySingleAsync<RentalProperty>(Sql, new { Id = id }).ConfigureAwait(false);

                return rentalProperty;
            }
        }
    }
}
