//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarsApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarModelTable
    {
        public int carmodelID { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public double dailyPrice { get; set; }
        public double dailyLateFee { get; set; }
        public string year { get; set; }
        public string gearbox { get; set; }
    }
}