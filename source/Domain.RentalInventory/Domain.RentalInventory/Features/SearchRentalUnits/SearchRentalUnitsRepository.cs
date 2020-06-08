// <copyright file="SearchRentalUnitsRepository.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Features.SearchRentalUnits
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using Dapper;
    using Domain.RentalInventory.Features.Common.Data;
    using Domain.RentalInventory.Models;
    using Domain.RentalInventory.Models.Values;

    public class SearchRentalUnitsRepository : ISearchRentalUnitsRepository
    {
        private const string SearchRentalUnitsSqlTemplate = "SELECT /**select**/ FROM RentalUnit /**where**/";

        private const string ConnectionString = "Server=.;Database=RentalInventory;Integrated Security=True";

        public async Task<IEnumerable<RentalUnit>> SearchRentalUnits(
            int? rentalPropertyId,
            RentalUnitSize? rentalUnitSize,
            RentalUnitStatus? rentalUnitStatus,
            RentalUnitType? rentalUnitType)
        {
            var dynamicQuery = this.GetDynamicQuerySql(
                rentalPropertyId,
                rentalUnitSize,
                rentalUnitStatus,
                rentalUnitType);

            using (var connection = new SqlConnection(ConnectionString))
            {
                var rentalUnitData = await connection.QueryAsync<RentalUnitData>(dynamicQuery.RawSql, dynamicQuery.Parameters).ConfigureAwait(false);

                return rentalUnitData.Select(rud => new RentalUnit(rud));
            }
        }

        private SqlBuilder.Template GetDynamicQuerySql(
            int? rentalPropertyId,
            RentalUnitSize? rentalUnitSize,
            RentalUnitStatus? rentalUnitStatus,
            RentalUnitType? rentalUnitType)
        {
            var builder = new SqlBuilder();

            if (rentalPropertyId.HasValue)
            {
                builder.Where("RentalPropertyId = @RentalPropertyId", new { RentalPropertyId = rentalPropertyId.Value });
            }

            if (rentalUnitSize.HasValue)
            {
                builder.Where("RentalUnitSizeId = @RentalUnitSizeId", new { RentalUnitSizeId = (int)rentalUnitSize.Value });
            }

            if (rentalUnitStatus.HasValue)
            {
                builder.Where("RentalUnitStatusId = @RentalUnitStatusId", new { RentalUnitStatusId = (int)rentalUnitStatus.Value });
            }

            if (rentalUnitType.HasValue)
            {
                builder.Where("RentalUnitTypeId = @RentalUnitTypeId", new { RentalUnitTypeId = (int)rentalUnitType.Value });
            }

            builder.Select("Id, Name, RentalPropertyId, RentalUnitSizeId, RentalUnitStatusId, RentalUnitTypeId");

            var sql = builder.AddTemplate(SearchRentalUnitsSqlTemplate);

            return sql;
        }
    }
}
