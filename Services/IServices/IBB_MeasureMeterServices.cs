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
    public partial interface IBB_MeasureMeterServices:IBaseServices<BB_MeasureMeter>
    {
        #region 针对此表的特殊操作写在此处
        object MeasureMeterList(int limit, int page);
        Model.BussionObject.MeasureMeterShow_BO MeasureMeterModi(int id);
        int MeasureMeterModi(Model.BussionObject.MeasureMeterShow_BO model);
        int MeasureMeterAdd(Model.BussionObject.MeasureMeterShow_BO model);
      #endregion
    } 
}
