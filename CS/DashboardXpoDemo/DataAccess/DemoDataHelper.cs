using DevExpress.Xpo;
using System;
using System.Configuration;
using System.Linq;

namespace DashboardXpoDemo.DataAccess {
    public static class DemoDataHelper {
        class ProductCategory {
            public string Category;
            public string[] Products;
        }

        static readonly Random rnd = new Random(0);
        static readonly string[] states = new string[] { "Alabama", "California", "Connecticut", "Florida", "Missouri", "New York", "Texas", "Virginia" };
        static readonly ProductCategory[] productCategories = new ProductCategory[] {
            new ProductCategory() {Category = "Accessoires", Products = new string[] { "Path Kit", "Bike Wash", "Water Bottle", "Minipump" } },
            new ProductCategory() {Category = "Bikes", Products = new string[] { "Mountain-300", "Touring-2000", "Road-250" } },
            new ProductCategory() {Category = "Clothing", Products = new string[] { "Classic Vest", "Cycling Cap", "Full-Finger Gloves", "Half-Finger Gloves" } },
            new ProductCategory() {Category = "Components", Products = new string[] { "Rear Brakes", "Front Brakes", "ML Headset", "LL Fork", "HL Fork" } }
        };        
        
        public static void Seed() {
            string connStr = ConfigurationManager.ConnectionStrings["XpoTutorial"].ConnectionString;
            var dataLayer = XpoDefault.GetDataLayer(connStr, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            using (UnitOfWork uow = new UnitOfWork(dataLayer)) {
                if (uow.Query<RevenueAnalysisDataItem>().Count() > 0) {
                    return;
                }
                int year = DateTime.Today.Year;
                for (int i = 0; i < 1000; i++) {
                    ProductCategory category = productCategories[rnd.Next(productCategories.Length)];
                    RevenueAnalysisDataItem item = new RevenueAnalysisDataItem(uow) {
                        Category = category.Category,
                        Product = category.Products[rnd.Next(category.Products.Length)],
                        State = states[rnd.Next(states.Length)],
                        UnitsSold = rnd.Next(5, 100),
                        Revenue = rnd.Next(5, 100),
                        Year = rnd.Next(year - 5, year + 1)
                    };
                }
                uow.CommitChanges();
            }
        }
    }
}
