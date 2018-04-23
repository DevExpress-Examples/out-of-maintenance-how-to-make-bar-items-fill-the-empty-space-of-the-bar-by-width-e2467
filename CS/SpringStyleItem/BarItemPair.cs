using System.Collections;
using DevExpress.XtraBars;

namespace SpringStyleItem
{
	public class BarItemPair
	{
		private Bar _bar;
		private BarItem _barItem;

		public BarItemPair()
		{
		}

		public Bar Bar
		{
			get
			{
				return _bar;
			}
			set
			{
				_bar = value;
			}
		}

		public BarItem BarItem
		{
			get
			{
				return _barItem;
			}
			set
			{
				_barItem = value;
			}
		}
	}

	public class BarItemCollection : CollectionBase
	{
		private MyBarAndDockingController ownerController = null;

		public BarItemCollection(MyBarAndDockingController controller)
			: base()
		{
			ownerController = controller;
		}
		public BarItemCollection(MyBarAndDockingController controller, int capacity)
			: base(capacity)
		{
			ownerController = controller;
		}

		public int Add(BarItemPair item)
		{
			for ( int i = 0; i < this.Count; i++ )
				if ( this[i].Bar == item.Bar )
					return -1;

			return List.Add(item);
		}

		public void Insert(int index, BarItemPair item)
		{
			for ( int i = 0; i < this.Count; i++ )
				if ( this[i].Bar == item.Bar )
					return;

			List.Insert(index, item);
		}

		public void Remove(BarItemPair item)
		{
			List.Remove(item);
		}

		protected override void OnInsertComplete(int index, object value)
		{
			base.OnInsertComplete(index, value);
			ownerController.OnChanged();
		}

		protected override void OnClearComplete()
		{
			base.OnClearComplete();
			ownerController.OnChanged();
		}

		public BarItemPair this[int index]
		{
			get
			{
				return (BarItemPair)List[index];
			}
			set
			{
				List[index] = value;
			}
		}
	}
}
