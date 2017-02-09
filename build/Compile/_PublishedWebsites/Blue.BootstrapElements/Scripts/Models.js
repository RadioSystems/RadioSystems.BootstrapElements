var LayoutEditor;
(function (LayoutEditor) {
    LayoutEditor.Accordion = function (data, htmlId, htmlClass, htmlStyle, isTemplated, children) {
        LayoutEditor.Element.call(this, "Accordion", data, htmlId, htmlClass, htmlStyle, isTemplated);
        LayoutEditor.Container.call(this, ["Grid", "Content"], children);
        //this.isContainable = true;
        this.dropTargetClass = "layout-common-holder";

        this.toObject = function () {
            var result = this.elementToObject();
            result.children = this.childrenToObject();
            return result;
        };
    };

    LayoutEditor.Accordion.from = function (value) {
        var result = new LayoutEditor.Accordion(
            value.data,
            value.htmlId,
            value.htmlClass,
            value.htmlStyle,
            value.isTemplated,
            LayoutEditor.childrenFrom(value.children));
        result.toolboxIcon = value.toolboxIcon;
        result.toolboxLabel = value.toolboxLabel;
        result.toolboxDescription = value.toolboxDescription;
        return result;
    };

    LayoutEditor.registerFactory("Accordion", function (value) {
        return LayoutEditor.Accordion.from(value);
    });

})(LayoutEditor || (LayoutEditor = {}));

var LayoutEditor;
(function (LayoutEditor) {
    LayoutEditor.JumboTron = function (data, htmlId, htmlClass, htmlStyle, isTemplated, children) {
        LayoutEditor.Element.call(this, "JumboTron", data, htmlId, htmlClass, htmlStyle, isTemplated);
        LayoutEditor.Container.call(this, ["Grid","Content"], children);
        //this.isContainable = true;
        this.dropTargetClass = "layout-common-holder";

        this.toObject = function () {
            var result = this.elementToObject();
            result.children = this.childrenToObject();
            return result;
        };
    };

    LayoutEditor.JumboTron.from = function (value) {
        var result = new LayoutEditor.JumboTron(
            value.data,
            value.htmlId,
            value.htmlClass,
            value.htmlStyle,
            value.isTemplated,
            LayoutEditor.childrenFrom(value.children));
        result.toolboxIcon = value.toolboxIcon;
        result.toolboxLabel = value.toolboxLabel;
        result.toolboxDescription = value.toolboxDescription;
        return result;
    };

    LayoutEditor.registerFactory("JumboTron", function (value) {
        return LayoutEditor.JumboTron.from(value);
    });

})(LayoutEditor || (LayoutEditor = {}));

var LayoutEditor;
(function (LayoutEditor) {
    LayoutEditor.Tabs = function (data, htmlId, htmlClass, htmlStyle, isTemplated, children) {
        LayoutEditor.Element.call(this, "Tabs", data, htmlId, htmlClass, htmlStyle, isTemplated);
        LayoutEditor.Container.call(this, ["Grid", "Content"], children);
        //this.isContainable = true;
        this.dropTargetClass = "layout-common-holder";

        this.toObject = function () {
            var result = this.elementToObject();
            result.children = this.childrenToObject();
            return result;
        };
    };

    LayoutEditor.Tabs.from = function (value) {
        var result = new LayoutEditor.Tabs(
            value.data,
            value.htmlId,
            value.htmlClass,
            value.htmlStyle,
            value.isTemplated,
            LayoutEditor.childrenFrom(value.children));
        result.toolboxIcon = value.toolboxIcon;
        result.toolboxLabel = value.toolboxLabel;
        result.toolboxDescription = value.toolboxDescription;
        return result;
    };

    LayoutEditor.registerFactory("Tabs", function (value) {
        return LayoutEditor.Tabs.from(value);
    });

})(LayoutEditor || (LayoutEditor = {}));

var LayoutEditor;
(function (LayoutEditor) {
    LayoutEditor.ShadowBox = function (data, htmlId, htmlClass, htmlStyle, isTemplated, children) {
        LayoutEditor.Element.call(this, "ShadowBox", data, htmlId, htmlClass, htmlStyle, isTemplated);
        LayoutEditor.Container.call(this, ["Grid", "Content"], children);
        //this.isContainable = true;
        this.dropTargetClass = "layout-common-holder";

        this.toObject = function () {
            var result = this.elementToObject();
            result.children = this.childrenToObject();
            return result;
        };
    };

    LayoutEditor.ShadowBox.from = function (value) {
        var result = new LayoutEditor.ShadowBox(
            value.data,
            value.htmlId,
            value.htmlClass,
            value.htmlStyle,
            value.isTemplated,
            LayoutEditor.childrenFrom(value.children));
        result.toolboxIcon = value.toolboxIcon;
        result.toolboxLabel = value.toolboxLabel;
        result.toolboxDescription = value.toolboxDescription;
        return result;
    };

    LayoutEditor.registerFactory("ShadowBox", function (value) {
        return LayoutEditor.ShadowBox.from(value);
    });

})(LayoutEditor || (LayoutEditor = {}));