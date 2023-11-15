namespace PivotDemoBlazor.Data
{
    using DevExpress.Blazor;
    using System;
    using System.Runtime.InteropServices;

    public class SaleInfo
    {
        public int OrderId { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public class DataField
    {
        public string NameField { get; set; }
        public PivotGridFieldArea Area { get; set; }
    }
}
