Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraBars.ViewInfo

Namespace SpringStyleItem
    Public Class MyDockedBarControlViewInfo
        Inherits SkinDockedBarControlViewInfo
        Public Sub New(ByVal manager As BarManager, ByVal parameters As BarDrawParameters, ByVal bar As CustomControl)
            MyBase.New(manager, parameters, bar)
        End Sub

        Private Function IndexOfInSpringStylesList(ByVal bar As Bar) As Integer
            Dim springStyleItems As BarItemCollection = (CType(Manager.Controller, MyBarAndDockingController)).SpringStyleItems
            For i As Integer = 0 To springStyleItems.Count - 1
                If springStyleItems(i).Bar Is bar Then
                    Return i
                End If
            Next i

            Return -1
        End Function

        Private Function GetSpringStyleItem(ByVal barIndex As Integer) As BarItem
            Return (CType(Manager.Controller, MyBarAndDockingController)).SpringStyleItems(barIndex).BarItem
        End Function

        Protected Overrides Function PreCalcMultiLineSize(ByVal g As Graphics, ByVal sourceObject As Object, ByVal AMaxBarWidth As Integer, ByRef ARestWidth As Integer) As ArrayList
            Dim rows As ArrayList = MyBase.PreCalcMultiLineSize(g, sourceObject, AMaxBarWidth, ARestWidth)
            If Not (TypeOf sourceObject Is DockedBarControl) OrElse rows Is Nothing OrElse (CType(sourceObject, DockedBarControl)).ClientSize = Size.Empty OrElse Manager.Controller Is Nothing OrElse Not (TypeOf Manager.Controller Is MyBarAndDockingController) Then
                Return rows
            End If

            For i As Integer = 0 To rows.Count - 1
                Dim rowViewInfo As BarControlRowViewInfo = CType(rows(i), BarControlRowViewInfo)
                If (Not rowViewInfo.BarInfo.Bar.OptionsBar.UseWholeRow) Then
                    Continue For
                End If

                Dim springItemBarIndex As Integer = IndexOfInSpringStylesList(rowViewInfo.BarInfo.Bar)
                If springItemBarIndex = -1 Then
                    Continue For
                End If

                Dim springLinkIndex As Integer = -1
                Dim totalOtherLinksWidth As Integer = 0
                For j As Integer = 0 To rowViewInfo.Links.Count - 1
                    Dim linkInfo As BarLinkViewInfo = CType(rowViewInfo.Links(j), BarLinkViewInfo)
                    If linkInfo.Link.Item.Equals(GetSpringStyleItem(springItemBarIndex)) Then
                        springLinkIndex = j
                    Else
                        totalOtherLinksWidth += linkInfo.Bounds.Width
                    End If
                Next j

                If springLinkIndex = -1 Then
                    Continue For
                End If

                Dim barElementsWidth As Integer = DrawParameters.Constants.BarQuickButtonWidth + CalcIndent(BarIndent.Left) + CalcIndent(BarIndent.Right) + CalcIndent(BarIndent.DragBorder) + CalcIndent(BarIndent.SizeGrip)
                Dim springLinkBounds As Rectangle = (CType(rowViewInfo.Links(springLinkIndex), BarLinkViewInfo)).Bounds
                Dim oldWidth As Integer = springLinkBounds.Width
                springLinkBounds.Width = rowViewInfo.BarInfo.Bounds.Width - barElementsWidth - totalOtherLinksWidth

                CType(rowViewInfo.Links(springLinkIndex), BarLinkViewInfo).Bounds = springLinkBounds
                For j As Integer = springLinkIndex + 1 To rowViewInfo.Links.Count - 1
                    Dim linkBounds As Rectangle = (CType(rowViewInfo.Links(j), BarLinkViewInfo)).Bounds
                    linkBounds.X += springLinkBounds.Width - oldWidth
                    CType(rowViewInfo.Links(j), BarLinkViewInfo).Bounds = linkBounds
                Next j

            Next i

            Return rows
        End Function
    End Class
End Namespace
