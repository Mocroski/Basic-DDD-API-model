using BulberDinner.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BulberDinner.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BulberDinnerEntityFrameworkCoreModule),
    typeof(BulberDinnerApplicationContractsModule)
    )]
public class BulberDinnerDbMigratorModule : AbpModule
{
}
