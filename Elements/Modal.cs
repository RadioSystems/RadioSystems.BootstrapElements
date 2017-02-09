using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.Helpers;
using Orchard.Localization;

namespace RadioSystems.BootstrapElements.Elements {
    //Defines a modal element, used to trigger a modal on page load
    public class Modal : Element {
        public override string Category{
            get { return "Bootstrap"; }
        }

        public override LocalizedString DisplayText{
            get { return T("Modal"); }
        }

        public string Header{
            get { return this.Retrieve(x => x.Header); }
            set { this.Store(x => x.Header, value);}
        }

        public string Body{
            get { return this.Retrieve(x => x.Body); }
            set { this.Store(x => x.Body, value); }
        }

        public string Footer{
            get { return this.Retrieve(x => x.Footer); }
            set { this.Store(x => x.Footer, value); }
        }

        public string Size {
            get { return this.Retrieve(x => x.Size); }
            set { this.Store(x => x.Size, value);}
        }

        public string Type {
            get { return this.Retrieve(x => x.Type); }
            set { this.Store(x => x.Type, value); }
        }
    }
}