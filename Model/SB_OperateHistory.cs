//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SB_OperateHistory
    {
    	/// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<System.Guid> UserId { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string IPAddress { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string OperateType { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string OperateChildType { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string PageURL { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string PageNameCN { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string OperateRecord { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> OperateTime { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<int> InstrumentID { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<int> AreaID { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<int> StationID { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<int> FactoryID { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public Nullable<int> ClientID { get; set; }
    	/// <summary>
        /// 
        /// </summary>
        public string Valid { get; set; }
    }
}
