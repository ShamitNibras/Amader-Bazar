//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double Discount { get; set; }
        public int NumOfUse { get; set; }
        public string Category { get; set; }
        public Nullable<double> MinOrder { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime ExpiredAt { get; set; }
    }
}
