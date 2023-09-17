using BulberDinner.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BulberDinner.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BulberDinnerController : AbpControllerBase
{
    protected BulberDinnerController()
    {
        LocalizationResource = typeof(BulberDinnerResource);
    }
}
