﻿using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

namespace CloudBust.Resources.Models
{
    [OrchardFeature("CloudBust.Resources.OwlCarousel")]
    public class OwlCarouselSettingsPart : ContentPart<OwlCarouselSettingsPartRecord> {    
        public bool AutoEnable
        {
            get { return Record.AutoEnable; }
            set { Record.AutoEnable = value; }
        }
        public bool AutoEnableAdmin
        {
            get { return Record.AutoEnableAdmin; }
            set { Record.AutoEnableAdmin = value; }
        }
    }
}