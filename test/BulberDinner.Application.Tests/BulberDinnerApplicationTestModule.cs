using Volo.Abp.Modularity;

namespace BulberDinner;

[DependsOn(
    typeof(BulberDinnerApplicationModule),
    typeof(BulberDinnerDomainTestModule)
    )]
public class BulberDinnerApplicationTestModule : AbpModule
{

}
