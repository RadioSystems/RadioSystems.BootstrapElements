﻿using System;
using System.Collections.Generic;
using System.Linq;
using Orchard.ContentManagement;
using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;

namespace RadioSystems.BootstrapElements.Elements {
    public class BootstrapContentItem : Element {
        public override bool IsSystemElement {
            get { return true; }
        }

        public override string Category {
            get { return "Bootstrap"; }
        }

        public IEnumerable<int> ContentItemIds {
            get { return Deserialize(this.Retrieve<string>("ContentItemIds")); }
            set { this.Store("ContentItemIds", Serialize(value)); }
        }

        public string DisplayType {
            get { return ElementDataHelper.Retrieve(this, x => x.DisplayType); }
            set { this.Store(x => x.DisplayType, value); }
        }

        public static string Serialize(IEnumerable<int> values) {
            return values != null ? String.Join(",", values) : "";
        }

        public static IEnumerable<int> Deserialize(string data) {
            if (String.IsNullOrWhiteSpace(data)) {
                return Enumerable.Empty<int>();
            }

            var query =
                from x in data.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                let id = XmlHelper.Parse<int?>(x)
                where id != null
                select id.Value;

            return query;
        }
    }
}