//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment_log
    {
        public int payment_id { get; set; }
        public int course_id { get; set; }
        public int user_id { get; set; }
        public float amount { get; set; }
        public string txn_id { get; set; }
        public int payment_status { get; set; }
        public System.DateTime datetime { get; set; }
    }
}