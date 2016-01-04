using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventeam.Models
{
    public class PlatformInfoViewModel
    {
        // Platform
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public string PlatformCityName { get; set; }
        public string PlatformAddress { get; set; }

        public ImageViewModel MainPhoto { get; set; }
    }
}