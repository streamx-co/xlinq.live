using System;
using Models.BikeStores;
using Streamx.Linq.SQL.Grammar;

namespace SqlServerTutorial {
    
    public class FullName {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    public class CityCount {
        public string City { get; set; }
        public int Count { get; set; }
    }
    
    public class Cities {
        public string City { get; set; }
    }
    
    public class CityState {
        public string City { get; set; }
        public string State { get; set; }
    }
    
    public class CityStateZip {
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
    
    public class Phones {
        public string Phone { get; set; }
    }
    
    public class ProductCategoryPrice {
        public string Product { get; set; }
        public string Category { get; set; }
        public decimal ListPrice { get; set; }
    }
    
    public class ProductCategoryBrandPrice {
        public string Product { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal ListPrice { get; set; }
    }
    
    public class CustomerYear {
        public Customers Customer { get; set; }
        public int Year { get; set; }
    }
    
    public class CustomerYearOrders {
        public Customers Customer { get; set; }
        public int Year { get; set; }
        public int OrdersPlaced { get; set; }
    }
    
    public class OrderNetSale {
        public Orders Order { get; set; }
        public decimal NetSale { get; set; }
    }
    
    public class SalesSummaryByYear {
        public short ModelYear { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Sales { get; set; }
    }
    
    public class SalesSummary {
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Sales { get; set; }
    }
    
    public class SalesGrouping {
        public byte GroupingBrand { get; set; }
        public byte GroupingCategory { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Sales { get; set; }
    }

    public class Scalar<T> {
        public T Value { get; set; }
    }

    public class OrderMaxListPrice {
        public Orders Order { get; set; }
        public decimal MaxListPrice { get; set; }
    }

    public class StaffSales {
        public String Staff { get; set; }
        public decimal Sales { get; set; }
    }
    
    [Tuple]
    public class CTECategorySales {
        public int CategoryId { get; set; }
        public decimal Sales { get; set; }
    }
    
    public class CTECategoryCounts : CTECategorySales {
        public String CategoryName { get; set; }
        public int ProductCount { get; set; }
    }
    
    public class CategoryCounts {
        public Categories Category { get; set; }
        public int ProductCount { get; set; }
        public decimal Sales { get; set; }
    }
    
    public class ProductInYear {
        public String ProductName { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }
    }
    
    public class GrossSalesByDay {
        public int Day { get; set; }
        public decimal GrossSales { get; set; }
    }
    
    public class VwNetSalesWithNext {
        public int? Month { get; set; }
        public decimal? NetSales { get; set; }
        public decimal? NextNetSales { get; set; }
    }

    public class VwNetSalesBrandsWithNext {
        public string BrandName { get; set; }
        public int? Month { get; set; }
        public decimal? NetSales { get; set; }
        public decimal? NextNetSales { get; set; }
    }
}
