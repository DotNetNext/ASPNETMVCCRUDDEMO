using System;
using System.Collections.Generic;
using SqlSugar;
using System.Web;
using SyntacticSugar;
using BBS.Infrastructure.DbModels;

namespace BBS.Controllers.ListPack
{
    /// <summary>
    /// 外包list的处理项
    /// </summary>
    public class Outsourcing
    {
        /// <summary>
        /// 获取分页html
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public HtmlString GetPageString(int pageIndex, int pageSize, int pageCount)
        {
            PageString ps = new PageString();
            return new HtmlString(ps.ToPageString(pageCount, pageSize, pageIndex, "/List/Index?"));
        }

        //可以假设这里面逻辑很复杂
        public Queryable<dnt_test_topics> GetQueryable(string title)
        {
            var reval = new Queryable<dnt_test_topics>();//创建没有数据库连接对象的queryable
            if (title.IsValuable())
            { //非空
                reval.Where(it => it.title.Contains(title));
            }
            return reval.OrderBy(it => it.tid, OrderByType.desc);
        }
    }
}