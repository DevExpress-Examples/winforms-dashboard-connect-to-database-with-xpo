Imports DevExpress.Xpo
Imports System
Imports System.Configuration
Imports System.Linq

Namespace DashboardXpoDemo.DataAccess
	Public Module DemoDataHelper
		Private Class ProductCategory
			Public Category As String
			Public Products() As String
		End Class

		Private ReadOnly rnd As New Random(0)
		Private ReadOnly states() As String = { "Alabama", "California", "Connecticut", "Florida", "Missouri", "New York", "Texas", "Virginia" }
		Private ReadOnly productCategories() As ProductCategory = {
			New ProductCategory() With {
				.Category = "Accessoires",
				.Products = New String() { "Path Kit", "Bike Wash", "Water Bottle", "Minipump" }
			},
			New ProductCategory() With {
				.Category = "Bikes",
				.Products = New String() { "Mountain-300", "Touring-2000", "Road-250" }
			},
			New ProductCategory() With {
				.Category = "Clothing",
				.Products = New String() { "Classic Vest", "Cycling Cap", "Full-Finger Gloves", "Half-Finger Gloves" }
			},
			New ProductCategory() With {
				.Category = "Components",
				.Products = New String() { "Rear Brakes", "Front Brakes", "ML Headset", "LL Fork", "HL Fork" }
			}
		}

		Public Sub Seed()
			Dim connStr As String = ConfigurationManager.ConnectionStrings("XpoTutorial").ConnectionString
			Dim dataLayer = XpoDefault.GetDataLayer(connStr, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
			Using uow As New UnitOfWork(dataLayer)
				If uow.Query(Of RevenueAnalysisDataItem)().Count() > 0 Then
					Return
				End If
				Dim year As Integer = Date.Today.Year
				For i As Integer = 0 To 999
					Dim category As ProductCategory = productCategories(rnd.Next(productCategories.Length))
					Dim item As New RevenueAnalysisDataItem(uow) With {
						.Category = category.Category,
						.Product = category.Products(rnd.Next(category.Products.Length)),
						.State = states(rnd.Next(states.Length)),
						.UnitsSold = rnd.Next(5, 100),
						.Revenue = rnd.Next(5, 100),
						.Year = rnd.Next(year - 5, year + 1)
					}
				Next i
				uow.CommitChanges()
			End Using
		End Sub
	End Module
End Namespace
