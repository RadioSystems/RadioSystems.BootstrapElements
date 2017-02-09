using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.Services;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Framework.Elements;

namespace RadioSystems.BootstrapElements.Drivers {
    public class TabPaneDriver : ElementDriver<TabPane> {
        protected override EditorResult OnBuildEditor(TabPane element, ElementEditorContext context) {
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.TabPane", Model: element);

            if (context.Updater == null) {
                return Editor(context, editor);
            }

            context.Updater.TryUpdateModel(element, context.Prefix, null, null);

            return Editor(context, editor);
        }

        protected override void OnLayoutSaving(TabPane element, ElementSavingContext context) {
            if (string.IsNullOrEmpty(element.HtmlId)) {
                element.HtmlId = HtmlIdGenerator.Generate();
            }
        }
    }
}