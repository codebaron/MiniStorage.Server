// <copyright file="RetailInventoryWebApiRegistrar.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.WebApi
{
    using Autofac;
    using Domain.RentalInventory.Features.GetRentalPropertyById;
    using MediatR;

    public class RetailInventoryWebApiRegistrar : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<Mediator>()
                .As<IMediator>()
                .SingleInstance();

            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder
                .RegisterAssemblyTypes(typeof(GetRentalPropertyByIdHandler).Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>));
        }
    }
}
