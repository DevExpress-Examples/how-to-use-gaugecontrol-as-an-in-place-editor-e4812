Imports Microsoft.VisualBasic
Imports DXGridAndGauge.Core
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DXGridAndGauge.Data
	Public Class ComboValue
		Inherits Bindable
		Public Property ID() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				If id_Renamed = value Then
					Return
				End If
				id_Renamed = value
				OnPropertyChanged("ID")
			End Set
		End Property
		Public Property Text() As String
			Get
				Return text_Renamed
			End Get
			Set(ByVal value As String)
				If text_Renamed = value Then
					Return
				End If
				text_Renamed = value
				OnPropertyChanged("Text")
			End Set
		End Property
		Private id_Renamed As Integer = -1
		Private text_Renamed As String = Nothing
	End Class
End Namespace
