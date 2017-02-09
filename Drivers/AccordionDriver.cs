using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.Services;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Framework.Elements;

namespace RadioSystems.BootstrapElements.Drivers {
    public class AccordionDriver : ElementDriver<Accordion> {
        protected override void OnLayoutSaving(Accordion element, ElementSavingContext context) {
            if (string.IsNullOrEmpty(element.HtmlId)) {
                element.HtmlId = HtmlIdGenerator.Generate();
            }
        }
    }
}