using System.Threading.Tasks;

namespace BulberDinner.Data;

public interface IBulberDinnerDbSchemaMigrator
{
    Task MigrateAsync();
}
