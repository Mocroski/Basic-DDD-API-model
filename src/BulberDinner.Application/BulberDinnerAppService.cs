using System;
using System.Collections.Generic;
using System.Text;
using BulberDinner.Localization;
using Volo.Abp.Application.Services;

namespace BulberDinner;

/* Inherit your application services from this class.
 */
public abstract class BulberDinnerAppService : ApplicationService
{
    protected BulberDinnerAppService()
    {
        LocalizationResource = typeof(BulberDinnerResource);
    }
}
