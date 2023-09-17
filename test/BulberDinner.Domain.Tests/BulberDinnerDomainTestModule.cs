using BulberDinner.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BulberDinner;

[DependsOn(
    typeof(BulberDinnerEntityFrameworkCoreTestModule)
    )]
public class BulberDinnerDomainTestModule : AbpModule
{

}
