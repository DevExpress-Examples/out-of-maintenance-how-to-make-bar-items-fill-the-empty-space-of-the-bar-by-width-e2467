Namespace SpringStyleItem
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim barItemPair1 As New SpringStyleItem.BarItemPair()
			Dim barItemPair2 As New SpringStyleItem.BarItemPair()
			Dim barItemPair3 As New SpringStyleItem.BarItemPair()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
			Me.barLinkContainerItem1 = New DevExpress.XtraBars.BarLinkContainerItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.myBarAndDockingController1 = New SpringStyleItem.MyBarAndDockingController(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myBarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem1),
				New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1)
			})
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "Tools"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "barCheckItem1"
			Me.barCheckItem1.Id = 2
			Me.barCheckItem1.Name = "barCheckItem1"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "barStaticItem1"
			Me.barStaticItem1.Id = 4
			Me.barStaticItem1.Name = "barStaticItem1"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Custom 3"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem2),
				New DevExpress.XtraBars.LinkPersistInfo(Me.barLinkContainerItem1)
			})
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Custom 3"
			' 
			' barCheckItem2
			' 
			Me.barCheckItem2.Caption = "barCheckItem2"
			Me.barCheckItem2.Id = 3
			Me.barCheckItem2.Name = "barCheckItem2"
			' 
			' barLinkContainerItem1
			' 
			Me.barLinkContainerItem1.Caption = "barLinkContainerItem1"
			Me.barLinkContainerItem1.Id = 5
			Me.barLinkContainerItem1.Name = "barLinkContainerItem1"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Custom 4"
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 2
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
				New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2),
				New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)
			})
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Custom 4"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 6
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barSubItem1
			' 
			Me.barSubItem1.Caption = "barSubItem1"
			Me.barSubItem1.Id = 7
			Me.barSubItem1.Name = "barSubItem1"
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.barManager1.Controller = Me.myBarAndDockingController1
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barCheckItem1, Me.barCheckItem2, Me.barStaticItem1, Me.barLinkContainerItem1, Me.barButtonItem2, Me.barSubItem1})
			Me.barManager1.MaxItemId = 8
			' 
			' myBarAndDockingController1
			' 
			Me.myBarAndDockingController1.PropertiesBar.AllowLinkLighting = False
			barItemPair1.Bar = Me.bar1
			barItemPair1.BarItem = Me.barButtonItem1
			barItemPair2.Bar = Me.bar2
			barItemPair2.BarItem = Me.barCheckItem2
			barItemPair3.Bar = Me.bar3
			barItemPair3.BarItem = Me.barSubItem1
			Me.myBarAndDockingController1.SpringStyleItems.Add(barItemPair1)
			Me.myBarAndDockingController1.SpringStyleItems.Add(barItemPair2)
			Me.myBarAndDockingController1.SpringStyleItems.Add(barItemPair3)
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(603, 87)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 262)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(603, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 87)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 175)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(603, 87)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 175)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(603, 262)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myBarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private myBarAndDockingController1 As MyBarAndDockingController
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private barLinkContainerItem1 As DevExpress.XtraBars.BarLinkContainerItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem




	End Class
End Namespace

