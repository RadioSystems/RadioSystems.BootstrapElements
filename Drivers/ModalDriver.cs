using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.Services;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Framework.Elements;

namespace RadioSystems.BootstrapElements.Drivers {
    public class ModalDriver : ElementDriver<Modal> {
        protected override EditorResult OnBuildEditor(Modal element, ElementEditorContext context) {
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.Modal", Model: element);

            if (context.Updater == null) {
                return Editor(context, editor);
            }

            context.Updater.TryUpdateModel(element, context.Prefix, null, null);

            return Editor(context, editor);
        }
        protected override void OnLayoutSaving(Modal element, ElementSavingContext context) {
            if (string.IsNullOrEmpty(element.HtmlId)) {
                element.HtmlId = HtmlIdGenerator.Generate();
            }
        }
    }
}