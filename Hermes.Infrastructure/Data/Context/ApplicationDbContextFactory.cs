﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FrontStore.Infrastructure.Data.Context;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<FrontStoreDbContext>
{
    /// <summary>
    /// Creates a new instance of the ApplicationDbContext for design-time operations.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the factory.</param>
    /// <returns>
    /// A new instance of the ApplicationDbContext configured with the connection string from 'appsettings.json'.
    /// </returns>
    public FrontStoreDbContext CreateDbContext(string[] args)
    {
        // Configure the builder to use the 'appsettings.json' file
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json")
            .Build();

        // Get the connection string from the configuration
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Create and return the DbContext instance
        var builder = new DbContextOptionsBuilder<FrontStoreDbContext>();
        builder.UseSqlServer(connectionString);
        return new FrontStoreDbContext(builder.Options);
    }
}