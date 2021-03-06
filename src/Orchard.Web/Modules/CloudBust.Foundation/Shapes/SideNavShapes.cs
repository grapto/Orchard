﻿using Orchard.ContentManagement;
using Orchard.DisplayManagement.Descriptors;
using Orchard.Widgets.Models;

namespace CloudBust.Foundation.Shapes {
    public class SideNavShapes : IShapeTableProvider {
        public void Discover(ShapeTableBuilder builder) {
            builder.Describe("Parts_MenuWidget").OnDisplaying(displaying => {
                ContentItem contentItem = displaying.Shape.ContentItem;
                var widgetPart = contentItem.As<WidgetPart>();
                var zoneName = widgetPart.Zone.ToString();

                if (zoneName.ToLower() != "sidenav") return;
                if (displaying.ShapeMetadata.DisplayType != "Detail") return;

                displaying.ShapeMetadata.Alternates.Add("Parts_MenuWidget___" + "SideNav");
                var menuShape = displaying.Shape.Menu;
                menuShape.Metadata.Alternates.Add("Menu___" + zoneName);
                foreach (var o in menuShape.Items) {
                    string type = o.Item.GetType().Name;
                    o.Metadata.Alternates.Add(type + "___" + zoneName);
                }
            });
            builder.Describe("Widget.Wrapper").OnDisplaying(displaying => {
                ContentItem contentItem = displaying.Shape.ContentItem;
            });
        }
    }
}