Imports Microsoft.VisualBasic
Imports DXGridAndGauge.Core
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace DXGridAndGauge.Data
	Public Class TestDataItem
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
		Public Property [Date]() As DateTime
			Get
				Return date_Renamed
			End Get
			Set(ByVal value As DateTime)
				If date_Renamed = value Then
					Return
				End If
				date_Renamed = value
				OnPropertyChanged("Date")
			End Set
		End Property
		Public Property ComboValueID() As Integer
			Get
				Return comboValueID_Renamed
			End Get
			Set(ByVal value As Integer)
				If comboValueID_Renamed = value Then
					Return
				End If
				comboValueID_Renamed = value
				OnPropertyChanged("ComboValueID")
			End Set
		End Property
		Private id_Renamed As Integer = -1
		Private text_Renamed As String = Nothing
		Private date_Renamed As DateTime
		Private comboValueID_Renamed As Integer
	End Class
End Namespace
