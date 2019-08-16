Namespace DashboardXpoDemo
	Partial Public Class Dashboard1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dashboardXpoDataSource1 = New DevExpress.DashboardCommon.DashboardXpoDataSource()
			Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardXpoDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' chartDashboardItem1
			' 
			dimension1.DataMember = "Year"
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.chartDashboardItem1.AxisX.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			Me.chartDashboardItem1.AxisX.NumericFormat.Precision = 0
			Me.chartDashboardItem1.AxisX.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
			Me.chartDashboardItem1.AxisX.Title = "Year"
			Me.chartDashboardItem1.AxisX.TitleVisible = True
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure1.DataMember = "Revenue"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.chartDashboardItem1.DataMember = ""
			Me.chartDashboardItem1.DataSource = Me.dashboardXpoDataSource1
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = "Revenue Analysis"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ShowCaption = False
			' 
			' dashboardXpoDataSource1
			' 
			Me.dashboardXpoDataSource1.ComponentName = "dashboardXpoDataSource1"
			Me.dashboardXpoDataSource1.ConnectionStringName = "XpoTutorial"
			Me.dashboardXpoDataSource1.EntityTypeString = "DashboardXpoDemo.DataAccess.RevenueAnalysisDataItem, DashboardXpoDemo, Version=1." & "0.0.0, Culture=neutral, PublicKeyToken=null"
			Me.dashboardXpoDataSource1.Name = "XPO Data Source 1"
			' 
			' pieDashboardItem1
			' 
			dimension2.DataMember = "State"
			Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
			measure2.DataMember = "Revenue"
			Me.pieDashboardItem1.DataItemRepository.Clear()
			Me.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.pieDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
			Me.pieDashboardItem1.DataMember = ""
			Me.pieDashboardItem1.DataSource = Me.dashboardXpoDataSource1
			Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieDashboardItem1.Name = ""
			Me.pieDashboardItem1.ShowCaption = False
			Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
			' 
			' pivotDashboardItem1
			' 
			dimension3.DataMember = "State"
			Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
			measure3.DataMember = "UnitsSold"
			measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
			measure3.NumericFormat.Precision = 0
			measure4.DataMember = "Revenue"
			measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
			dimension4.DataMember = "Category"
			dimension5.DataMember = "Product"
			Me.pivotDashboardItem1.DataItemRepository.Clear()
			Me.pivotDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
			Me.pivotDashboardItem1.DataItemRepository.Add(measure4, "DataItem4")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension5, "DataItem1")
			Me.pivotDashboardItem1.DataMember = ""
			Me.pivotDashboardItem1.DataSource = Me.dashboardXpoDataSource1
			Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
			Me.pivotDashboardItem1.Name = "Sales by State"
			Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4, dimension5})
			Me.pivotDashboardItem1.ShowCaption = True
			Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3, measure4})
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardXpoDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartDashboardItem1, Me.pieDashboardItem1, Me.pivotDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem1.Weight = 50.077760497667185R
			dashboardLayoutItem2.DashboardItem = Me.pieDashboardItem1
			dashboardLayoutItem2.Weight = 49.922239502332815R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 37.873754152823921R
			dashboardLayoutItem3.DashboardItem = Me.pivotDashboardItem1
			dashboardLayoutItem3.Weight = 62.126245847176079R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Revenue Analysis"
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardXpoDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private dashboardXpoDataSource1 As DevExpress.DashboardCommon.DashboardXpoDataSource
		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
		Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
	End Class
End Namespace
