using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BulberDinner.Data;
using Volo.Abp.DependencyInjection;

namespace BulberDinner.EntityFrameworkCore;

public class EntityFrameworkCoreBulberDinnerDbSchemaMigrator
    : IBulberDinnerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBulberDinnerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BulberDinnerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BulberDinnerDbContext>()
            .Database
            .MigrateAsync();
    }
}
