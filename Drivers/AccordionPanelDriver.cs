using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.Services;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Framework.Elements;

namespace RadioSystems.BootstrapElements.Drivers {
    public class AccordionPanelDriver : ElementDriver<AccordionPanel> {
        protected override EditorResult OnBuildEditor(AccordionPanel element, ElementEditorContext context) {
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.AccordionPanel", Model: element);

            if (context.Updater == null) {
                return Editor(context, editor);
            }

            context.Updater.TryUpdateModel(element, context.Prefix, null, null);

            return Editor(context, editor);
        }

        protected override void OnLayoutSaving(AccordionPanel element, ElementSavingContext context) {
            if (string.IsNullOrEmpty(element.HtmlId)) {
                element.HtmlId = HtmlIdGenerator.Generate();
            }
        }
    }
}