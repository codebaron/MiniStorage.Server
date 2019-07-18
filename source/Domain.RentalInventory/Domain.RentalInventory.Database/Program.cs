// <copyright file="Program.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Domain.RentalInventory.Database
{
    using System;
    using System.Linq;
    using System.Reflection;
    using DbUp;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var connectionString =
                args.FirstOrDefault()
                ?? "Server=.;Database=RentalInventory;Trusted_connection=true";

            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
            }

            Console.ForegroundColor = ConsoleColor.Green;
#pragma warning disable CA1303 // Do not pass literals as localized parameters
            Console.WriteLine("Success!");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
            Console.ResetColor();
        }
    }
}
