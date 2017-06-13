# RadioSystems.BootstrapElements
Orchard CMS Module for Bootstrap Elements. Adds bootstrap based elements that can be used in the layout editor UI. All elements included under the **Bootstrap** category in they layout editor.

## Requirements

In order for the included module to function properly. You must include a copy of [jQuery](https://jquery.com/) and [Bootstrap](http://getbootstrap.com/) in your Orchard site. You can optionally include [Font Awesome](http://fontawesome.io/) if you wish to 
take advantage of the icon properties of the included elements.

## Descriptions

## Accordion

In order to create an accordion on your page, you must do the following:

1. First drag and drop an **Accordion** element from the elements list on the right hand side of the editor onto the canvas

2. Add one or more **Accordion Panels** inside of the accordion element. An editor will pop for each Accordion panel that will allow you to specify the panel title, panel icon, panel body, 
and whether or not the panel should *default to expanded*. By default all accordion panels are closed on page load, by selecting the checkbox for *default to expanded* you can specify
which accordion section you want opened on page load.

## Tabs

Tabs create a tabbable area on a page. They are displayed as follows:

To create tabs on a page you must follow the following steps:

1. Drag a **Tabs** container element from the right side menu under the *Blue* sub-section.

2. Drag two more more **Tab Pane** elements into the *Tabs* container. **Ensure that you put the *Tab Pane* inside the *Tabs* container**.

3. When creating or editing a **Tab Pane** element, you can set the title and text/content of the tab, as well as an optional tab icon. These icons are in the form of a Font Awesome
framework class such as *fa-gears*, *fa-user*, *fa-bell*, etc. A full list of these icons can be found here [Font Awesome Icons](http://fontawesome.io/icons/)

## Button Popover
Button popovers are buttons that display text when clicked. 

You can specify the position of the popover text as *Top*, *Bottom*, *Left*, or *Right*.

## Modal
A modal is a dismissable popover window that will be displayed on page load.

In order to add a modal to a page, drag a **Modal** item from the right hand menu under the *Blue* sub-section. Then fill in the desired parameters.

There are three modal types to select from, **Info**, **Warning**, and **Alert**. These types dictate that color of the modal header background. Info is standard *blue*, warning is *yellow*, and alert is *red*


## Shadow Box

A shadow box is a container element that is displayed as a white box with a slightly transparent background and a shadow effect. 

In order to add a shadow box, drag a **Shadow Box** element from the right hande side under the *Blue* subsection. Once you have added it, you can then add any other items you wish inside of it to create content
that is shadow boxed.