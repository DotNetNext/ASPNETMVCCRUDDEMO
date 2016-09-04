using SqlSugar;
using SyntacticSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBS.Infrastructure.Dao
{
    public class SugarDao : IDisposable
    {

        public SqlSugarClient DB;

        public SugarDao()
        {
            this.DB = GetInstance();
        }
        private SqlSugarClient GetInstance()
        {
            try
            {
                string connectionString = ConfigSugar.GetConfigString("DefaultConnection"); //这里可以动态根据cookies或session实现多库切换
                return new SqlSugarClient(connectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("连接数据库出错，请检查您的连接字符串，和网络。 ex:".AppendString(ex.Message));
            }
        }
        public void Dispose()
        {
            if (this.DB != null)
            {
                DB.Dispose();
            }
        }
    }
}
