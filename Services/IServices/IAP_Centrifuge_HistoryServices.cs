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
    public partial interface IAP_Centrifuge_HistoryServices:IBaseServices<AP_Centrifuge_History>
    {
        #region 针对此表的特殊操作写在此处
        #region 统计分析服务界面接口
        /// <summary>
        /// 统计分析空压站压力功率图
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="arr"></param>
        /// <param name="sid"></param>
        /// <returns></returns>
        object StaMainpq(DateTime currtime, DateTime begtime,string sid);
        /// <summary>
        /// 统计分析，空压机产气量功率图
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="sidcid"></param>
        /// <returns></returns>
        object CentriProduceEpower(DateTime currtime, DateTime begtime, string sidcid);
        /// <summary>
        /// 空压机统计分析，放散率BOV打开度图
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="sidcid"></param>
        /// <returns></returns>
        object CentriBovLoss(DateTime currtime, DateTime begtime, string sidcid);
        /// <summary>
        /// 统计分析，空压机单耗放散率
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="sidcid"></param>
        /// <returns></returns>
        object CentriUpiLoss(DateTime currtime, DateTime begtime, string sidcid);
        /// <summary>
        /// 统计分析，空压机压力功率图
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="sidcid"></param>
        /// <returns></returns>
        object CentriPEpower(DateTime currtime, DateTime begtime, string sidcid);
        #endregion
        List<Model.Stack> StackSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 空压机开关机实时数据
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        List<int> SwitchSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 空压机开关能效数据
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        List<List<Model.ViewObject.CenSwitchStack_VO>> SwitchStackSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 空压机趋势分析图
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="censtrlist"></param>
        /// <returns></returns>
        object TrendCentri(DateTime currtime, DateTime begtime,List<string>censtr);


        /// <summary>
        /// 空压机趋势分析图Ajax
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="censtrlist"></param>
        /// <returns></returns>
        object TrendCentriAjax(DateTime currtime, DateTime begtime, List<string> censtrlist);
        /// <summary>
        /// 空压机压力功率
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        object CentrifugePePowerPage(DateTime currtime, DateTime begtime);
        #endregion
    } 
}
