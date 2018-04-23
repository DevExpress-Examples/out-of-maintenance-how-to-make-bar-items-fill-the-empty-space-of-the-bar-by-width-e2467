Imports System.Collections
Imports DevExpress.XtraBars

Namespace SpringStyleItem
    Public Class BarItemPair
        Private _bar As Bar
        Private _barItem As BarItem

        Public Sub New()
        End Sub

        Public Property Bar() As Bar
            Get
                Return _bar
            End Get
            Set(ByVal value As Bar)
                _bar = value
            End Set
        End Property

        Public Property BarItem() As BarItem
            Get
                Return _barItem
            End Get
            Set(ByVal value As BarItem)
                _barItem = value
            End Set
        End Property
    End Class

    Public Class BarItemCollection
        Inherits CollectionBase

        Private ownerController As MyBarAndDockingController = Nothing

        Public Sub New(ByVal controller As MyBarAndDockingController)
            MyBase.New()
            ownerController = controller
        End Sub
        Public Sub New(ByVal controller As MyBarAndDockingController, ByVal capacity As Integer)
            MyBase.New(capacity)
            ownerController = controller
        End Sub

        Public Function Add(ByVal item As BarItemPair) As Integer
            For i As Integer = 0 To Me.Count - 1
                If Me(i).Bar Is item.Bar Then
                    Return -1
                End If
            Next i

            Return List.Add(item)
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal item As BarItemPair)
            For i As Integer = 0 To Me.Count - 1
                If Me(i).Bar Is item.Bar Then
                    Return
                End If
            Next i

            List.Insert(index, item)
        End Sub

        Public Sub Remove(ByVal item As BarItemPair)
            List.Remove(item)
        End Sub

        Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
            MyBase.OnInsertComplete(index, value)
            ownerController.OnChanged()
        End Sub

        Protected Overrides Sub OnClearComplete()
            MyBase.OnClearComplete()
            ownerController.OnChanged()
        End Sub

        Default Public Property Item(ByVal index As Integer) As BarItemPair
            Get
                Return DirectCast(List(index), BarItemPair)
            End Get
            Set(ByVal value As BarItemPair)
                List(index) = value
            End Set
        End Property
    End Class
End Namespace
