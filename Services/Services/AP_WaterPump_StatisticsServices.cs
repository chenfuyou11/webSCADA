//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services
{
    using System;
    using System.Collections.Generic;
    
    using Model;
    using Base;
    using IServices;
    using IRepository;
      /// <summary>
      /// 负责每个数据表的业务逻辑操作的约定
      /// </summary>
    public partial class AP_WaterPump_StatisticsServices:BaseServices<AP_WaterPump_Statistics>,IAP_WaterPump_StatisticsServices
    {
    	IAP_WaterPump_StatisticsRepository dal;
      #region 定义构造函数，接收autofac将数据仓储层的具体实现类的对象注入到此类中
    	public AP_WaterPump_StatisticsServices(IAP_WaterPump_StatisticsRepository dal)
    	{
    		this.dal = dal;
    		base.baseDal = dal;
    	}
      #endregion
    
       #region 针对此表的特殊操作写在此处
            
      #endregion
    } 
}
