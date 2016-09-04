using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BBS.Infrastructure.DbModels;
using BBS.Infrastructure.ViewModels;
using SyntacticSugar;
namespace BBS.Controllers.HomePack
{
    /// <summary>
    /// 外包home的处理项
    /// </summary>
    public class Outsourcing  //注意:Outsourcing类是逻辑的入口
    {

        /// <summary>
        ///  处理业务逻辑（只是示例就算看不懂，不合理也没关系,重要的是这儿是处理逻辑的）
        /// </summary>
        /// <param name="allTopic"></param>
        /// <returns></returns>
        internal List<List<V_dnt_test_topics>> ArrangeTopic(List<V_dnt_test_topics> allTopic)
        {
            var reval = new List<List<V_dnt_test_topics>>();
            var groupTypeIdList = allTopic.GroupBy(it => it.fid).Select(it => it.Key).ToList();
            if (allTopic.IsValuable())
            {
                foreach (var typeId in groupTypeIdList)
                {
                    var addItem = allTopic.Where(it => it.fid == typeId).Take(4).ToList();//取四条
                    if (addItem.IsValuable())
                    {
                        reval.Add(addItem);
                    }
                }
            }
            return reval;
        }
    }
}