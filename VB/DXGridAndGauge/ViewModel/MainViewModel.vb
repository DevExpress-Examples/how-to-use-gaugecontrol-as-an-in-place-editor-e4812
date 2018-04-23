Imports Microsoft.VisualBasic
Imports DXGridAndGauge.Core
Imports DXGridAndGauge.Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace DXGridAndGauge.ViewModel
	Public Class MainViewModel
		Inherits Bindable
		Public Shared Function CreateTestItems() As TestDataItems
			Dim res As New TestDataItems()
			res.Add(New TestDataItem() With {.ID = 0, .Text = "Text 0", .Date = DateTime.Now, .ComboValueID = 0})
			res.Add(New TestDataItem() With {.ID = 1, .Text = "Text 1", .Date = DateTime.Now.AddDays(1), .ComboValueID = 1})
			res.Add(New TestDataItem() With {.ID = 2, .Text = "Text 2", .Date = DateTime.Now.AddDays(2), .ComboValueID = 2})
			Return res
		End Function
		Public Shared Function CreateComboValues() As ComboValues
			Dim res As New ComboValues()
			res.Add(New ComboValue() With {.ID = 0, .Text = "ComboValue 0"})
			res.Add(New ComboValue() With {.ID = 1, .Text = "ComboValue 1"})
			res.Add(New ComboValue() With {.ID = 2, .Text = "ComboValue 2"})
			Return res
		End Function
		Public Property Data() As TestDataItems
			Get
				Return data_Renamed
			End Get
			Set(ByVal value As TestDataItems)
				If data_Renamed Is value Then
					Return
				End If
				data_Renamed = value
				OnPropertyChanged("Data")
			End Set
		End Property
		Public Property ComboValues() As ComboValues
			Get
				Return comboValues_Renamed
			End Get
			Set(ByVal value As ComboValues)
				If comboValues_Renamed Is value Then
					Return
				End If
				comboValues_Renamed = value
				OnPropertyChanged("ComboValues")
			End Set
		End Property
		Public Sub New()
			Data = CreateTestItems()
			ComboValues = CreateComboValues()
		End Sub

		Private data_Renamed As TestDataItems
		Private comboValues_Renamed As ComboValues
	End Class

End Namespace
