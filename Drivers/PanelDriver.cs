using RadioSystems.BootstrapElements.Elements;
using Orchard.Layouts.Framework.Drivers;

namespace RadioSystems.BootstrapElements.Drivers {
    public class CollabsiblePanelContentItemDriver : ElementDriver<Panel> {
        protected override EditorResult OnBuildEditor(Panel element, ElementEditorContext context) {
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.Panel", Model: element);

            if (context.Updater == null) {
                return Editor(context, editor);
            }

            context.Updater.TryUpdateModel(element, context.Prefix, null, null);

            return Editor(context, editor);
        }
    }
}