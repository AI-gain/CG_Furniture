//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBCL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment_Order
    {
        public string Pao_ID { get; set; }
        public string Order_ID { get; set; }
        public decimal Payable_Money { get; set; }
        public Nullable<decimal> Realpay_Money { get; set; }
        public string Supplier { get; set; }
        public string Operater { get; set; }
        public System.DateTime Pao_Date { get; set; }
        public string Remark { get; set; }
    }
}
