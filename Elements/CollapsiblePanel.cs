using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;

namespace RadioSystems.BootstrapElements.Elements {
    public class CollapsiblePanel : Element {
        public override bool HasEditor {
            get { return true; }
        }

        public override string Category {
            get { return "Bootstrap"; }
        }

        public string Title {
            get { return this.Retrieve(x => x.Title); }
            set { this.Store(x => x.Title, value); }
        }

        public string Body {
            get { return this.Retrieve(x => x.Body); }
            set { this.Store(x => x.Body, value); }
        }

        public string Icon {
            get { return this.Retrieve(x => x.Icon); }
            set { this.Store(x => x.Icon, value);}
        }

        public bool DefaultCollapsed {
            get { return this.Retrieve(x => x.DefaultCollapsed); }
            set { this.Store(x => x.DefaultCollapsed, value);}
        }
    }
}