using Orchard.Layouts.Elements;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class Accordion : Container {
        public override string Category {
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText {
            get { return T("Accordion"); }
        }

        public override bool HasEditor {
            get { return false; }
        }
    }
}