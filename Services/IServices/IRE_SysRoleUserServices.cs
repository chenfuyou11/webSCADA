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
    public partial interface IRE_SysRoleUserServices:IBaseServices<RE_SysRoleUser>
    {
        #region 针对此表的特殊操作写在此处
        /// <summary>
        /// 人员角色列表
        /// </summary>
        /// <param name="Roleid"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="account"></param>
        /// <returns></returns>

        object RoleUser(int Roleid, int page, int limit, string account);
        /// <summary>
        /// 添加人员角色列表
        /// </summary>
        /// <param name="Roleid"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        object AddRoleUser(int Roleid, int limit, int page);
        /// <summary>
        /// 添加选择的人员到角色人员
        /// </summary>
        /// <param name="list"></param>
        /// <param name="roleid"></param>
        /// <returns></returns>
        int AddRangeUserRole(List<Guid> list, int roleid);
        /// <summary>
        /// 删除角色人员
        /// </summary>
        /// <param name="account"></param>
        /// <param name="roleid"></param>
        /// <returns></returns>
        int DeleteRoleUser(string account, int roleid);
      #endregion
    } 
}