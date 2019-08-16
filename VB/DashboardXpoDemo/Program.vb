Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DashboardXpoDemo
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			DashboardXpoDemo.DataAccess.DemoDataHelper.Seed()
			Application.Run(New DashboardForm())
		End Sub
	End Module
End Namespace
