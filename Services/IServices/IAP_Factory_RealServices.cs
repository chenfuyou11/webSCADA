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
    public partial interface IAP_Factory_RealServices:IBaseServices<AP_Factory_Real>
    {
        #region 针对此表的特殊操作写在此处
        List<AP_Factory_Real> Test(DateTime currtime, DateTime begtime);
        #region 大数据界面服务接口
        /// <summary>
        /// 大数据界面瞬时流量数据
        /// </summary>
        /// <param name="currtime">当前时间</param>
        /// <param name="begtime">之前时间</param>
        /// <param name="monthtime">月初0点</param>
        /// <returns></returns>
        object MomentSer(DateTime currtime, DateTime begtime, DateTime monthtime);
        /// <summary>
        /// 大数据界面UPI放散率数据
        /// </summary>
        /// <param name="currtime">当前时间</param>
        /// <param name="begtime">之前时间</param>
        /// <returns></returns>
        object ScatterSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 大数据界面放散率分布数据
        /// </summary>
        /// <param name="currtime">当前时间</param>
        /// <param name="begtime">之前时间</param>
        /// <param name="jsonList">规定区间</param>
        /// <returns></returns>
        object FrequencySer(DateTime currtime, DateTime begtime, double[] jsonList);
        /// <summary>
        /// 大数据界面压力功率流量数据
        /// </summary>
        /// <param name="currtime">当前时间</param>
        /// <param name="begtime">之前时间</param>
        /// <returns></returns>
        List<Model.ViewObject.SupplyStackSumpowerpq_VO> SupplyStackSumPowerpq(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 大数据界面必要实际开启台数实时刷新数据
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        Model.ViewObject.SupplyStackSumpowerpq_VO SupplySer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 大数据界面功率流量压力实时刷新数据
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        Model.ViewObject.SupplyStackSumpowerpq_VO StackProEpq(DateTime currtime, DateTime begtime);
        #endregion

        #region 趋势分析界面服务接口方法
        /// <summary>
        /// 趋势分析界面空压系统工厂的所有数据
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        object TrendFacProducePressSumPower(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 趋势分析界面工厂当前时间的数据
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        object TrendFacProducePressSumPowerAjax(DateTime currtime, DateTime begtime);
        #endregion

        #region 统计分析界面服务接口方法
        /// <summary>
        /// 统计分析，工厂产气量概率分布图/ 小于等于24小时，并且属于今天访问该方法
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        object Produceflow(DateTime currtime, DateTime begtime, int a);
        /// <summary>
        /// 统计分析，工厂upi和放散率散点，实时表
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        object EScatterSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 统计分析，工厂放散率分布图，实时表
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        object LossSer(DateTime currtime, DateTime begtime);
        /// <summary>
        /// 统计分析，工厂产气量功率图，实时表
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        object ProduceEpower(DateTime currtime, DateTime begtime);
        #endregion

        #region 优化指导界面服务实现方法
        /// <summary>
        /// 优化指导界面，当前系统的实时upi值和产气量之和
        /// </summary>
        /// <param name="currtime"></param>
        /// <param name="begtime"></param>
        /// <returns></returns>
        List<decimal?> EnergyAnalsysUPI(DateTime currtime, DateTime begtime);
        #endregion
        #endregion
    }
}
