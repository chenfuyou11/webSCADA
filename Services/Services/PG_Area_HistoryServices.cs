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
    using System.Linq;
    using CommonHelper;

    /// <summary>
    /// 负责每个数据表的业务逻辑操作的约定
    /// </summary>
    public partial class PG_Area_HistoryServices:BaseServices<PG_Area_History>,IPG_Area_HistoryServices
    {
        IBB_AreaRepository bbdal;
        IPG_Area_HistoryRepository dal;
        private long startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0)).Ticks;
      #region 定义构造函数，接收autofac将数据仓储层的具体实现类的对象注入到此类中
    	public PG_Area_HistoryServices(IPG_Area_HistoryRepository dal, IBB_AreaRepository tbbdal)
    	{
    		this.dal = dal;
    		base.baseDal = dal;
            bbdal = tbbdal;
    	}
        #endregion

        #region 针对此表的特殊操作写在此处
        public object GasUseSer(DateTime currtime, DateTime begtime)
        {
            var bbarea = bbdal.QueryWhere(x => true);
            //var res = dal.QueryWhere(d => d.DateTime >= begtime && d.DateTime <= currtime).GroupBy(g => new { g.AreaID, g.FactoryID }).Select(s => new
            //{
            //    inletSQ = Math.Round((decimal)s.Average(i => i.Inlet_SQ), 2),
            //    areaID = s.Key.AreaID
            //}).Join(bbarea, m => m.areaID, n => n.Code, (m, n) => new
            //{
            //    value = m.inletSQ,
            //    name = n.Name
            //}).ToList();
            var res=dal.QuerySplitPage(d => d.DateTime >= begtime && d.DateTime <= currtime,or=>or.OrderByDescending(o=>o.Id),21,1).Select(s=>new {
                inletSQ= Math.Round((decimal)s.Inlet_SQ, 2),
                areaID=s.AreaID
            }).OrderBy(o=>o.areaID).Join(bbarea, m => m.areaID, n => n.Code, (m, n) => new
            {
                value = m.inletSQ,
                name = n.Name
            }).ToList();
            return res;
        }
        public object TrendArea(DateTime currtime, DateTime begtime,List<string> aid)
        {
            var query = dal.QueryWhere(d => d.DateTime >= begtime && d.DateTime <= currtime);
            if (aid.Count < 2)
            {
                var areaid = aid[0];
                var res = query.Where(x => x.AreaID.Equals(areaid)).ToList().Select(s => new
                {
                    time = (DateTime.Parse("" + s.DateTime).AddHours(8).Ticks - startTime) / 10000,
                    flow = s.Inlet_SQ,
                    press = s.Inlet_AP
                }).OrderBy(o=>o.time).ToList();
                return res;
            }
            else
            {
                var where = ExtendWhereClass.False<Model.PG_Area_History>();
                foreach(var item in aid)
                {
                    where = where.Or(x => x.AreaID.Equals(item));
                }
                var res = query.Where(where.Compile()).ToList().Select(s => new
                {
                    time = (DateTime.Parse("" + s.DateTime).AddHours(8).Ticks - startTime) / 10000,
                    flow = s.Inlet_SQ,
                    press = s.Inlet_AP,
                    area = s.AreaID
                }).OrderBy(o => o.area).GroupBy(g => new { g.area }).ToList();
                return res;
            }
         
            
        }
        public object TrendAreaAjax(DateTime currtime, DateTime begtime, List<string> aid)
        {
            var query = dal.QueryWhere(d => d.DateTime >= begtime && d.DateTime <= currtime);
            if (aid.Count < 2)
            {
                var areaid = aid[0];
                var res = query.Where(x => x.AreaID.Equals(areaid)).ToList().Select(s => new
                {
                    time = (DateTime.Parse("" + s.DateTime).AddHours(8).Ticks - startTime) / 10000,
                    flow = s.Inlet_SQ,
                    press = s.Inlet_AP,
                }).FirstOrDefault();
                return res;
            }
            else
            {
                var where = ExtendWhereClass.False<Model.PG_Area_History>();
                foreach(var item in aid)
                {
                    where = where.Or(x => x.AreaID.Equals(item));
                }
                var res = query.Where(where.Compile()).ToList().Select(s => new
                {

                    time = (DateTime.Parse("" + s.DateTime).AddHours(8).Ticks - startTime) / 10000,
                    flow = s.Inlet_SQ,
                    press = s.Inlet_AP,
                    areaid = s.AreaID
                }).OrderBy(o => o.areaid).GroupBy(g => g.areaid).Select(s => s.FirstOrDefault()).ToList();
                return res;
            }
           
        }
        #endregion
    } 
}
