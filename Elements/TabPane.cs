using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class TabPane : Element{
        public override string Category { 
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText {
            get { return T("Tab Pane"); }
        }

        public string Title {
            get { return this.Retrieve(x => x.Title); }
            set { this.Store(x => x.Title, value);}
        }

        public string Content {
            get { return this.Retrieve(x => x.Content); }
            set { this.Store(x => x.Content, value);}
        }

        public string Icon {
            get { return this.Retrieve(x => x.Icon); }
            set { this.Store(x => x.Icon, value);}
        }
    }
}