# How To Bind WinForms Dashboard Viewer to XPO Persistent Class Data

We created the *DevExpress.DashboardCommon.DashboardXpoDataSource* component to help XPO users bind their persistent class data to DevExpress Dashboard (DevExpress Dashboard is part of the Universal Subscription).

You can configure the new component as follows:
1. In code (at runtime):
```
this.dashboardXpoDataSource1.ComponentName = "dashboardXpoDataSource1";
this.dashboardXpoDataSource1.ConnectionStringName = "XpoTutorial"; // Refers to the connection string in the application's configuration file.
this.dashboardXpoDataSource1.EntityTypeString = "DashboardXpoDemo.DataAccess.RevenueAnalysisDataItem, DashboardXpoDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
```

2. Using the built-in dashboard Data Source Wizard:
![](https://github.com/DevExpress-Examples/winforms-dashboard-connect-to-database-with-xpo/blob/19.2.3%2B/DashboardXpoDataSource1.png)
![](https://github.com/DevExpress-Examples/winforms-dashboard-connect-to-database-with-xpo/blob/19.2.3%2B/DashboardXpoDataSource11.png)
![](https://github.com/DevExpress-Examples/winforms-dashboard-connect-to-database-with-xpo/blob/19.2.3%2B/DashboardXpoDataSource2.png)
