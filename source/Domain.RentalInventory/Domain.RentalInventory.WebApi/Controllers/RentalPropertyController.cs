// <copyright file="RentalPropertyController.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.Controllers
{
    using System.Threading.Tasks;
    using Domain.RentalInventory.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class RentalPropertyController : Controller
    {
        //// GET: api/<controller>
        ////[HttpGet]
        ////public IEnumerable<string> Get()
        ////{
        ////    return new string[] { "value1", "value2" };
        ////}

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public static Task<RentalProperty> Get()
        {
            return Task.FromResult(new RentalProperty());
        }

        //// POST api/<controller>
        ////[HttpPost]
        ////public void Post([FromBody]string value)
        ////{
        ////}

        //// PUT api/<controller>/5
        ////[HttpPut("{id}")]
        ////public void Put(int id, [FromBody]string value)
        ////{
        ////}

        //// DELETE api/<controller>/5
        ////[HttpDelete("{id}")]
        ////public void Delete(int id)
        ////{
        ////}
    }
}
