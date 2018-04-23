Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles

Namespace SpringStyleItem
    Public Class MyBarAndDockingController
        Inherits BarAndDockingController


        Private springStyleItems_Renamed As BarItemCollection

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
            ChangeDockedBarControlViewInfo()
        End Sub
        Public Sub New()
            MyBase.New()
            ChangeDockedBarControlViewInfo()
        End Sub

        Protected Friend Shadows Sub OnChanged()
            MyBase.OnChanged()
        End Sub

        Private Sub ChangeDockedBarControlViewInfo()
            springStyleItems_Renamed = New BarItemCollection(Me)

            For Each paintStyle As BarManagerPaintStyle In Me.PaintStyles
                Dim info As BarControlInfo = paintStyle.BarInfoCollection("DockedBarControl")
                If info IsNot Nothing Then
                    Dim infos As New BarControlInfoCollection(paintStyle)
                    For i As Integer = 0 To paintStyle.BarInfoCollection.Count - 1
                        Dim barInfo As BarControlInfo = paintStyle.BarInfoCollection(i)
                        If barInfo.Name <> "DockedBarControl" Then
                            infos.Add(New BarControlInfo(barInfo.Name, barInfo.ItemType, barInfo.ViewInfoType, barInfo.Painter))
                        Else
                            infos.Add(New BarControlInfo(barInfo.Name, barInfo.ItemType, GetType(MyDockedBarControlViewInfo), barInfo.Painter))
                        End If
                    Next i

                    paintStyle.BarInfoCollection.Clear()
                    For i As Integer = 0 To infos.Count - 1
                        paintStyle.BarInfoCollection.Add(New BarControlInfo(infos(i).Name, infos(i).ItemType, infos(i).ViewInfoType, infos(i).Painter))
                    Next i
                End If
            Next paintStyle
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property SpringStyleItems() As BarItemCollection
            Get
                Return springStyleItems_Renamed
            End Get
        End Property
    End Class
End Namespace
