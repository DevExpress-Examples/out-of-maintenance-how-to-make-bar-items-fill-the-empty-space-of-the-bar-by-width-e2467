using System.Collections;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.ViewInfo;

namespace SpringStyleItem
{
	public class MyDockedBarControlViewInfo : SkinDockedBarControlViewInfo
	{
		public MyDockedBarControlViewInfo(BarManager manager, BarDrawParameters parameters, CustomControl bar)
			: base(manager, parameters, bar)
		{
		}

		private int IndexOfInSpringStylesList(Bar bar)
		{
			BarItemCollection springStyleItems = ((MyBarAndDockingController)Manager.Controller).SpringStyleItems;
			for ( int i = 0; i < springStyleItems.Count; i++ )
				if ( springStyleItems[i].Bar == bar )
					return i;

			return -1;
		}

		private BarItem GetSpringStyleItem(int barIndex)
		{
			return ((MyBarAndDockingController)Manager.Controller).SpringStyleItems[barIndex].BarItem;
		}

		protected override ArrayList PreCalcMultiLineSize(Graphics g, object sourceObject, int AMaxBarWidth, ref int ARestWidth)
		{
			ArrayList rows = base.PreCalcMultiLineSize(g, sourceObject, AMaxBarWidth, ref ARestWidth);
			if ( !(sourceObject is DockedBarControl) || rows == null || ((DockedBarControl)sourceObject).ClientSize == Size.Empty ||
					Manager.Controller == null || !(Manager.Controller is MyBarAndDockingController) )
				return rows;

			for ( int i = 0; i < rows.Count; i++ )
			{
				BarControlRowViewInfo rowViewInfo = (BarControlRowViewInfo)rows[i];
				if ( !rowViewInfo.BarInfo.Bar.OptionsBar.UseWholeRow )
					continue;
				
				int springItemBarIndex = IndexOfInSpringStylesList(rowViewInfo.BarInfo.Bar);
				if ( springItemBarIndex == -1 )
					continue;

				int springLinkIndex = -1;
				int totalOtherLinksWidth = 0;
				for ( int j = 0; j < rowViewInfo.Links.Count; j++ )
				{
					BarLinkViewInfo linkInfo = (BarLinkViewInfo)rowViewInfo.Links[j];
					if ( linkInfo.Link.Item == GetSpringStyleItem(springItemBarIndex) )
						springLinkIndex = j;
					else
						totalOtherLinksWidth += linkInfo.Bounds.Width;
				}

				if ( springLinkIndex == -1 )
					continue;

				int barElementsWidth = DrawParameters.Constants.BarQuickButtonWidth + CalcIndent(BarIndent.Left) + CalcIndent(BarIndent.Right) + CalcIndent(BarIndent.DragBorder) + CalcIndent(BarIndent.SizeGrip);
				Rectangle springLinkBounds = ((BarLinkViewInfo)rowViewInfo.Links[springLinkIndex]).Bounds;
				int oldWidth = springLinkBounds.Width;
				springLinkBounds.Width = rowViewInfo.BarInfo.Bounds.Width - barElementsWidth - totalOtherLinksWidth;

				((BarLinkViewInfo)rowViewInfo.Links[springLinkIndex]).Bounds = springLinkBounds;
				for ( int j = springLinkIndex + 1; j < rowViewInfo.Links.Count; j++ )
				{
					Rectangle linkBounds = ((BarLinkViewInfo)rowViewInfo.Links[j]).Bounds;
					linkBounds.X += springLinkBounds.Width - oldWidth;
					((BarLinkViewInfo)rowViewInfo.Links[j]).Bounds = linkBounds;
				}

			}

			return rows;
		}
	}
}
