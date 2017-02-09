using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class PanelContentItem : BootstrapContentItem {
        public override bool IsSystemElement {
            get { return false; }
        }

        public override LocalizedString DisplayText {
            get { return T("Panel - Content Item"); }
        }
    }
}