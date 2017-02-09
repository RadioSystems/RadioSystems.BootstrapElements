using System;
using System.Collections.Generic;
using System.Linq;
using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.ViewModels;
using Orchard.ContentManagement;
using Orchard.Core.Title.Models;
using Orchard.Layouts.Framework.Display;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Helpers;
using ContentItem = Orchard.Layouts.Elements.ContentItem;

namespace RadioSystems.BootstrapElements.Drivers {
    public class BootstrapContentItemDriver : ElementDriver<BootstrapContentItem> {
        private readonly IContentManager _contentManager;

        public BootstrapContentItemDriver(IContentManager contentManager) {
            _contentManager = contentManager;
        }

        protected override EditorResult OnBuildEditor(BootstrapContentItem element, ElementEditorContext context) {
            var layoutPart = context.Content;
            var viewModel = new BootstrapContentItemViewModel();
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.BootstrapContentItem", Model: viewModel);

            if (context.Updater != null) {
                context.Updater.TryUpdateModel(viewModel, context.Prefix, null, null);
                element.ContentItemIds = ContentItem.Deserialize(viewModel.ContentItemIds);
                element.DisplayType = viewModel.DisplayType;
            }

            var contentItemIds = element.ContentItemIds;
            var displayType = element.DisplayType;
            var layoutContentId = layoutPart != null ? layoutPart.Id : 0;

            viewModel.ContentItems = GetContentItems(RemoveCurrentContentItemId(contentItemIds, layoutContentId)).ToArray();
            viewModel.DisplayType = displayType;

            return Editor(context, editor);
        }

        protected override void OnDisplaying(BootstrapContentItem element, ElementDisplayingContext context) {
            var contentItemIds = context.Content != null ? RemoveCurrentContentItemId(element.ContentItemIds, context.Content.Id) : element.ContentItemIds;
            var displayType = element.DisplayType;
            var contentItems = GetContentItems(contentItemIds).ToArray();
            var contentItemViewModels = contentItems.Select(x => new ContentItemViewModel {
                ContentShape = _contentManager.BuildDisplay(x, displayType),
                Title = x.As<TitlePart>() != null ? x.As<TitlePart>().Title : string.Empty
            }).ToList();

            context.ElementShape.ContentItems = contentItemViewModels;
        }

        protected override void OnExporting(BootstrapContentItem element, ExportElementContext context) {
            var contentItems = GetContentItems(element.ContentItemIds).ToArray();

            if (!contentItems.Any()) {
                return;
            }

            var identities = contentItems.Select(x => _contentManager.GetItemMetadata(x).Identity.ToString()).ToArray();
            context.ExportableData["ContentItems"] = String.Join(",", identities);
        }

        protected override void OnImporting(BootstrapContentItem element, ImportElementContext context) {
            var contentItemIdentities = context.ExportableData.Get("ContentItems");

            if (String.IsNullOrWhiteSpace(contentItemIdentities)) {
                return;
            }

            var identities = contentItemIdentities.Split(',');
            var contentItems = identities.Select(x => context.Session.GetItemFromSession(x)).Where(x => x != null);

            element.ContentItemIds = contentItems.Select(x => x.Id);
        }

        protected IEnumerable<Orchard.ContentManagement.ContentItem> GetContentItems(IEnumerable<int> ids) {
            return _contentManager.GetMany<IContent>(ids, VersionOptions.Published, QueryHints.Empty).Select(x => x.ContentItem);
        }

        // The user can't pick the content that will host the selected content to prevent an infinite loop / stack overflow.
        protected IEnumerable<int> RemoveCurrentContentItemId(IEnumerable<int> ids, int currentId) {
            return ids.Where(x => x != currentId);
        }
    }
}