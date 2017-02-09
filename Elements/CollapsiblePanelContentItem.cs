using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class CollapsiblePanelContentItem : BootstrapContentItem {
        public override bool IsSystemElement {
            get { return false; }
        }

        public override LocalizedString DisplayText {
            get { return T("Collapsible Panel - Content Item"); }
        }
    }
}