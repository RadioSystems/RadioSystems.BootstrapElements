using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class AccordionPanel : Element {
        public override string Category {
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText {
            get { return T("Accordion Panel"); }
        }

        public string Title {
            get { return this.Retrieve(x => x.Title); }
            set { this.Store(x => x.Title, value); }
        }

        public string Icon {
            get { return this.Retrieve(x => x.Icon); }
            set { this.Store(x => x.Icon, value); }
        }

        public string Body {
            get { return this.Retrieve(x => x.Body); }
            set { this.Store(x => x.Body, value); }
        }

        public bool DefaultExpanded{
            get { return this.Retrieve(x => x.DefaultExpanded); }
            set { this.Store(x => x.DefaultExpanded, value);}
        }
    }
}