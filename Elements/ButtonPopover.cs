using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    public class ButtonPopover : Element {
        public override string Category {
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText {
            get { return T("Button Popover"); }
        }
    
        public string Title {
            get { return this.Retrieve(x => x.Title); }
            set { this.Store(x => x.Title, value);}
        }

        public string ButtonText {
            get { return this.Retrieve(x => x.ButtonText); }
            set { this.Store(x => x.ButtonText, value);}
        }

        public string Content {
            get { return this.Retrieve(x => x.Content); }
            set { this.Store(x => x.Content, value);}
        }

        public string Position {
            get { return this.Retrieve(x => x.Position); }
            set { this.Store(x => x.Position, value);}
        }

    }
}