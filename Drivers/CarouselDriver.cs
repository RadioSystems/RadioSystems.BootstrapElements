﻿using System.Collections.Generic;
using System.Linq;
using RadioSystems.BootstrapElements.Elements;
using RadioSystems.BootstrapElements.Services;
using RadioSystems.BootstrapElements.ViewModels;
using Orchard.ContentManagement;
using Orchard.Layouts.Framework.Display;
using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Framework.Elements;
using Orchard.Layouts.ViewModels;
using Orchard.MediaLibrary.Models;
using ContentItem = Orchard.Layouts.Elements.ContentItem;

namespace RadioSystems.BootstrapElements.Drivers {
    public class CarouselDriver : ElementDriver<Carousel> {
        private readonly IContentManager _contentManager;

        public CarouselDriver(IContentManager contentManager) {
            _contentManager = contentManager;
        }


        protected override EditorResult OnBuildEditor(Carousel element, ElementEditorContext context) {
            var viewModel = new ContentItemEditorViewModel();
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.Carousel", Model: viewModel);

            if (context.Updater != null) {
                context.Updater.TryUpdateModel(viewModel, context.Prefix, null, null);
                element.MediaItemIds = ContentItem.Deserialize(viewModel.ContentItemIds);
                element.DisplayType = viewModel.DisplayType;
            }

            var contentItemIds = element.MediaItemIds;
            var displayType = element.DisplayType;
            var layoutPart = context.Content;
            var layoutId = layoutPart != null ? layoutPart.Id : 0;

            viewModel.ContentItems = GetContentItems(RemoveCurrentContentItemId(contentItemIds, layoutId)).ToArray();
            viewModel.DisplayType = displayType;

            return Editor(context, editor);
        }

        protected override void OnDisplaying(Carousel element, ElementDisplayingContext context) {
            var contentItemIds = RemoveCurrentContentItemId(element.MediaItemIds, context.Content.Id);

            var contentItems = GetContentItems(contentItemIds).Select(x =>  x.As<MediaPart>().MediaUrl).ToArray();

            context.ElementShape.ContentItems = contentItems;
        }

        protected override void OnLayoutSaving(Carousel element, ElementSavingContext context) {
            if (string.IsNullOrEmpty(element.HtmlId)) {
                element.HtmlId = HtmlIdGenerator.Generate();
            }
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