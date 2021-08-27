<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617158/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2467)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BarItemPair.cs](./CS/SpringStyleItem/BarItemPair.cs) (VB: [BarItemPair.vb](./VB/SpringStyleItem/BarItemPair.vb))
* [Form1.cs](./CS/SpringStyleItem/Form1.cs) (VB: [Form1.Designer.vb](./VB/SpringStyleItem/Form1.Designer.vb))
* [Form1.Designer.cs](./CS/SpringStyleItem/Form1.Designer.cs) (VB: [Form1.Designer.vb](./VB/SpringStyleItem/Form1.Designer.vb))
* [MyBarAndDockingController.cs](./CS/SpringStyleItem/MyBarAndDockingController.cs) (VB: [MyBarAndDockingController.vb](./VB/SpringStyleItem/MyBarAndDockingController.vb))
* [MyDockedBarControlViewInfo.cs](./CS/SpringStyleItem/MyDockedBarControlViewInfo.cs) (VB: [MyDockedBarControlViewInfo.vb](./VB/SpringStyleItem/MyDockedBarControlViewInfo.vb))
<!-- default file list end -->
# How to make bar items fill the empty space of the bar by width


<p>This example demonstrates how to make bar items have a spring style behavior. To achieve this we have created an BarAndDockingController descendant. This descendant has the SpringStyleItems property that is a collection of Bar-Item pairs. Only one item per bar can be stretched to fill an empty space so if there are several items with the same bar in the SpringStyleItems collection the first of them is stretched.<br />
This example uses "Skin" paint style. If you require this behavior for some other paint styles you can use a similar way to achieve it.</p>

<br/>


