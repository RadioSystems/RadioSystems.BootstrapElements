using Orchard.Layouts.Elements;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class JumboTron : Container {
        public override string Category {
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText
        {
            get { return T("Jumbo Tron"); }
        }

        public override bool HasEditor {
            get { return false; }
        }
    }
}