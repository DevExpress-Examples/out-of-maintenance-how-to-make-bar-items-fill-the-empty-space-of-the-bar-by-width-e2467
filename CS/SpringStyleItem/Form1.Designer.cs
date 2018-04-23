namespace SpringStyleItem
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			SpringStyleItem.BarItemPair barItemPair1 = new SpringStyleItem.BarItemPair();
			SpringStyleItem.BarItemPair barItemPair2 = new SpringStyleItem.BarItemPair();
			SpringStyleItem.BarItemPair barItemPair3 = new SpringStyleItem.BarItemPair();
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
			this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
			this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.myBarAndDockingController1 = new SpringStyleItem.MyBarAndDockingController(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myBarAndDockingController1)).BeginInit();
			this.SuspendLayout();
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
			this.bar1.OptionsBar.UseWholeRow = true;
			this.bar1.Text = "Tools";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "barButtonItem1";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barCheckItem1
			// 
			this.barCheckItem1.Caption = "barCheckItem1";
			this.barCheckItem1.Id = 2;
			this.barCheckItem1.Name = "barCheckItem1";
			// 
			// barStaticItem1
			// 
			this.barStaticItem1.Caption = "barStaticItem1";
			this.barStaticItem1.Id = 4;
			this.barStaticItem1.Name = "barStaticItem1";
			this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// bar2
			// 
			this.bar2.BarName = "Custom 3";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 1;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLinkContainerItem1)});
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Custom 3";
			// 
			// barCheckItem2
			// 
			this.barCheckItem2.Caption = "barCheckItem2";
			this.barCheckItem2.Id = 3;
			this.barCheckItem2.Name = "barCheckItem2";
			// 
			// barLinkContainerItem1
			// 
			this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
			this.barLinkContainerItem1.Id = 5;
			this.barLinkContainerItem1.Name = "barLinkContainerItem1";
			// 
			// bar3
			// 
			this.bar3.BarName = "Custom 4";
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 2;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Custom 4";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "barButtonItem2";
			this.barButtonItem2.Id = 6;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "barSubItem1";
			this.barSubItem1.Id = 7;
			this.barSubItem1.Name = "barSubItem1";
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
			this.barManager1.Controller = this.myBarAndDockingController1;
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barStaticItem1,
            this.barLinkContainerItem1,
            this.barButtonItem2,
            this.barSubItem1});
			this.barManager1.MaxItemId = 8;
			// 
			// myBarAndDockingController1
			// 
			this.myBarAndDockingController1.PropertiesBar.AllowLinkLighting = false;
			barItemPair1.Bar = this.bar1;
			barItemPair1.BarItem = this.barButtonItem1;
			barItemPair2.Bar = this.bar2;
			barItemPair2.BarItem = this.barLinkContainerItem1;
			barItemPair3.Bar = this.bar3;
			barItemPair3.BarItem = this.barButtonItem2;
			this.myBarAndDockingController1.SpringStyleItems.Add(barItemPair1);
			this.myBarAndDockingController1.SpringStyleItems.Add(barItemPair2);
			this.myBarAndDockingController1.SpringStyleItems.Add(barItemPair3);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(603, 78);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 262);
			this.barDockControlBottom.Size = new System.Drawing.Size(603, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 78);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 184);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(603, 78);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 184);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 262);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myBarAndDockingController1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarCheckItem barCheckItem1;
		private MyBarAndDockingController myBarAndDockingController1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarCheckItem barCheckItem2;
		private DevExpress.XtraBars.BarStaticItem barStaticItem1;
		private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarSubItem barSubItem1;




	}
}

