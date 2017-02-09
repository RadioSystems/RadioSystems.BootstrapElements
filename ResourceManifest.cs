using Orchard.UI.Resources;

namespace RadioSystems.BootstrapElements {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineScript("RadioSystems.BootstrapElements.Models").SetUrl("Models.js").SetDependencies("Layouts.LayoutEditor");
            manifest.DefineScript("RadioSystems.BootstrapElements.LayoutEditors").SetUrl("LayoutEditor.js").SetDependencies("Layouts.LayoutEditor", "RadioSystems.BootstrapElements.Models");
        }
    }
}