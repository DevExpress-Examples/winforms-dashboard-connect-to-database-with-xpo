using System;
using DevExpress.Xpo;

namespace DashboardXpoDemo.DataAccess {
    public class RevenueAnalysisDataItem : XPObject {
        public RevenueAnalysisDataItem(Session session) : base(session) { }
        int fYear;
        public int Year {
            get { return fYear; }
            set { SetPropertyValue(nameof(Year), ref fYear, value); }
        }
        string fState;
        public string State {
            get { return fState; }
            set { SetPropertyValue(nameof(State), ref fState, value); }
        }
        string fCategory;
        public string Category {
            get { return fCategory; }
            set { SetPropertyValue(nameof(Category), ref fCategory, value); }
        }
        string fProduct;
        public string Product {
            get { return fProduct; }
            set { SetPropertyValue(nameof(Product), ref fProduct, value); }
        }
        decimal fRevenue;
        public decimal Revenue {
            get { return fRevenue; }
            set { SetPropertyValue(nameof(Revenue), ref fRevenue, value); }
        }
        int fUnitsSold;
        public int UnitsSold {
            get { return fUnitsSold; }
            set { SetPropertyValue(nameof(UnitsSold), ref fUnitsSold, value); }
        }
    }
}