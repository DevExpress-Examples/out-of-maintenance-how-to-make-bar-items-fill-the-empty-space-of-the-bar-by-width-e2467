using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;

namespace SpringStyleItem
{
	public class MyBarAndDockingController : BarAndDockingController
	{
		private BarItemCollection springStyleItems;

		public MyBarAndDockingController(IContainer container)
			: base(container)
		{
            Init();
        }
		public MyBarAndDockingController()
			: base()
        {
            Init();
        }

        private void Init()
        {
            springStyleItems = new BarItemCollection(this);
        }

        protected internal new void OnChanged()
		{
			base.OnChanged();
		}

        public void AddBarControlInfo()
		{
			foreach ( BarManagerPaintStyle paintStyle in this.PaintStyles )
			{
				BarControlInfo info = paintStyle.BarInfoCollection["DockedBarControl"];
				if ( info != null )
				{
					BarControlInfoCollection infos = new BarControlInfoCollection(paintStyle);
					for ( int i = 0; i < paintStyle.BarInfoCollection.Count; i++ )
					{
						BarControlInfo barInfo = paintStyle.BarInfoCollection[i];
						if ( barInfo.Name != "DockedBarControl" )
							infos.Add(new BarControlInfo(barInfo.Name, barInfo.ItemType, barInfo.ViewInfoType, barInfo.Painter));
						else
							infos.Add(new BarControlInfo(barInfo.Name, barInfo.ItemType, typeof(MyDockedBarControlViewInfo), barInfo.Painter));
					}

					paintStyle.BarInfoCollection.Clear();
					for ( int i = 0; i < infos.Count; i++ )
						paintStyle.BarInfoCollection.Add(new BarControlInfo(infos[i].Name, infos[i].ItemType, infos[i].ViewInfoType, infos[i].Painter));
				}
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public BarItemCollection SpringStyleItems
		{
			get
			{
				return springStyleItems;
			}
		}
	}
}
