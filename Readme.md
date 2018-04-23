# How to make bar items fill the empty space of the bar by width


<p>This example demonstrates how to make bar items have a spring style behavior. To achieve this we have created an BarAndDockingController descendant. This descendant has the SpringStyleItems property that is a collection of Bar-Item pairs. Only one item per bar can be stretched to fill an empty space so if there are several items with the same bar in the SpringStyleItems collection the first of them is stretched.<br />
This example uses "Skin" paint style. If you require this behavior for some other paint styles you can use a similar way to achieve it.</p>

<br/>


