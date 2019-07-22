// <copyright file="ControllerTestsBase.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi.IntegrationTests
{
    using Autofac;

    public class ControllerTestsBase : RetailInventoryWebApiRegistrar
    {
        private readonly IContainer container;

        public ControllerTestsBase()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RetailInventoryWebApiRegistrar());

            this.container = builder.Build();
        }

        protected TEntity Resolve<TEntity>()
        {
            return this.container.Resolve<TEntity>();
        }

        protected void ShutdownIoC()
        {
            this.container.Dispose();
        }
    }
}
