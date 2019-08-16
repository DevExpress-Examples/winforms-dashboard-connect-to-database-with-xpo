Imports System
Imports DevExpress.Xpo

Namespace DashboardXpoDemo.DataAccess
	Public Class RevenueAnalysisDataItem
		Inherits XPObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private fYear As Integer
		Public Property Year() As Integer
			Get
				Return fYear
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(NameOf(Year), fYear, value)
			End Set
		End Property
		Private fState As String
		Public Property State() As String
			Get
				Return fState
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(State), fState, value)
			End Set
		End Property
		Private fCategory As String
		Public Property Category() As String
			Get
				Return fCategory
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(Category), fCategory, value)
			End Set
		End Property
		Private fProduct As String
		Public Property Product() As String
			Get
				Return fProduct
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(Product), fProduct, value)
			End Set
		End Property
		Private fRevenue As Decimal
		Public Property Revenue() As Decimal
			Get
				Return fRevenue
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(NameOf(Revenue), fRevenue, value)
			End Set
		End Property
		Private fUnitsSold As Integer
		Public Property UnitsSold() As Integer
			Get
				Return fUnitsSold
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(NameOf(UnitsSold), fUnitsSold, value)
			End Set
		End Property
	End Class
End Namespace