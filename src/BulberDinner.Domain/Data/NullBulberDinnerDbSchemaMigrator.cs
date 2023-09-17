using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BulberDinner.Data;

/* This is used if database provider does't define
 * IBulberDinnerDbSchemaMigrator implementation.
 */
public class NullBulberDinnerDbSchemaMigrator : IBulberDinnerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
