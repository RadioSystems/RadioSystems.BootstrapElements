using Orchard.Layouts.Elements;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class Tabs : Container {
        public override string Category {
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText {
            get { return T("Tabs"); }
        }

        public override bool HasEditor {
            get { return false; }
        }
    }
}