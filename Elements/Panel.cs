using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;

namespace RadioSystems.BootstrapElements.Elements {
    public class Panel : Element {
        public override string Category {
            get { return "Bootstrap"; }
        }

        public override bool HasEditor {
            get { return true; }
        }

        public string PanelTitle {
            get { return this.Retrieve(x => x.PanelTitle); }
            set { this.Store(x => x.PanelTitle, value);}
        }

        public string PanelBody {
            get { return this.Retrieve(x => x.PanelBody); }
            set { this.Store(x => x.PanelBody, value);}
        }

        public string PanelIcon {
            get { return this.Retrieve(x => x.PanelIcon); }
            set { this.Store(x => x.PanelIcon, value);}
        }
    }
}