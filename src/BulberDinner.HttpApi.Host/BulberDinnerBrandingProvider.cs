using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BulberDinner;

[Dependency(ReplaceServices = true)]
public class BulberDinnerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BulberDinner";
}
