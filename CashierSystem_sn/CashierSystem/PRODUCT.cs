//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CashierSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        public int ProductID { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductDesc { get; set; }
        public string ProductName { get; set; }
        public int UnitID { get; set; }
        public int ProductGoupID { get; set; }
    
        public virtual PRODUCT_GROUPS PRODUCT_GROUPS { get; set; }
        public virtual UNIT UNIT { get; set; }
    }
}
