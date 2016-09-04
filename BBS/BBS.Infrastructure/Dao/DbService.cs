using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using SyntacticSugar;
namespace BBS.Infrastructure.Dao
{
    /// <summary>
    /// DAL层只需要这么一个类就可以了
    /// 如果你需要一些自定义扩展，可以把SqlSugarClient外面在套一层，相当于仓储
    /// 因为SqlSugarORM是我开源的一个ORM，对我而言已经是完美的了,没有扩展的必要
    /// 当然这里也可以换成EF等其它ORM,只需要把SqlSugarClient换成DbContext
    /// </summary>
    public class DbService
    {
        private SqlSugarClient _db;
        public DbService(SugarDao dao)
        {
            _db = dao.DB;
        }

        /// <summary>
        ///服务命令
        /// </summary>
        /// <typeparam name="Outsourcing">外包服务类型</typeparam>
        /// <param name="func"></param>
        public void Command<Outsourcing>(Action<SqlSugarClient, Outsourcing> func) where Outsourcing : class, new()
        {
            try
            {
                var o = new Outsourcing();
                func(_db, o);
                o = null;//及时释放对象 
                //_db 会在http请求结束前执行 dispose 
            }
            catch (Exception ex)
            {
                //在这里可以处理所有controller的异常
                //获错误写入日志
                WriteExMessage(ex);
                throw ex;
            }
        }
        /// <summary>
        /// 将错误信息写入日志
        /// </summary>
        /// <param name="ex"></param>
        private static void WriteExMessage(Exception ex)
        {
            var logPath = FileSugar.MergeUrl(
                FileSugar.GetMapPath("~/"),
                "log",
                DateTime.Now.ToString("yyyy-MM-dd.txt")
                );
            FileSugar.AppendText(logPath, "***********{0}{1}***********".ToFormat("开始:", DateTime.Now));
            FileSugar.AppendText(logPath, ex.Message);
            FileSugar.AppendText(logPath, "***********{0}***********\r\n".ToFormat("结束"));
        }
    }
}
