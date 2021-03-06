﻿using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Tracking.AfterShip.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }
        [NopResourceDisplayName("Plugins.Tracking.AfterShip.ApiKey")]
        public string ApiKey { get; set; }
        [NopResourceDisplayName("Plugins.Tracking.AfterShip.AfterShipUsername")]
        public string AfterShipUsername { get; set; }
        [NopResourceDisplayName("Plugins.Tracking.AfterShip.AllowCustomerNotification")]
        public bool AllowCustomerNotification { get; set; }
    }
}