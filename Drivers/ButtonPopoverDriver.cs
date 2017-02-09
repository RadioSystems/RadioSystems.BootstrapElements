using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.Services;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Framework.Elements;

namespace RadioSystems.BootstrapElements.Drivers {
    public class ButtonPopoverDriver : ElementDriver<ButtonPopover> {
        protected override EditorResult OnBuildEditor(ButtonPopover element, ElementEditorContext context) {
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.ButtonPopover", Model: element);

            if (context.Updater == null) {
                return Editor(context, editor);
            }

            context.Updater.TryUpdateModel(element, context.Prefix, null, null);

            return Editor(context, editor);
        }

        protected override void OnLayoutSaving(ButtonPopover element, ElementSavingContext context) {
            if (string.IsNullOrEmpty(element.HtmlId)) {
                element.HtmlId = HtmlIdGenerator.Generate();
            }
        }
    }
}