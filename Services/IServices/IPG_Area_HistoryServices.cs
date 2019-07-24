//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IServices
{
    using System;
    using System.Collections.Generic;
    
    using Base;
    using Model;
      /// <summary>
      /// 负责每个数据表的业务逻辑操作的约定
      /// </summary>
    public partial interface IPG_Area_HistoryServices:IBaseServices<PG_Area_History>
    {
        #region 针对此表的特殊操作写在此处
        object GasUseSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 趋势分析用户区域实时图
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="aid"></param>
        /// <returns></returns>
        object TrendArea(DateTime currtime, DateTime begtime, List<string> aid);
        /// <summary>
        /// 趋势分析用户区域实时图Ajax
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="aid"></param>
        /// <returns></returns>
        object TrendAreaAjax(DateTime currtime, DateTime begtime, List<string> aid);
      #endregion
    } 
}