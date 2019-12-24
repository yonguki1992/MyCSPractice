using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly : log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SqlConnectEx
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            new Program().ConnectSample();
        }
        public void ConnectSample()
        {
            //윈도우 계정으로 인증 시
            //string strConn =
            // "Data Source=localhost;Initial Catalog=KYUDB; Integrated Security=SSPI;";

            //sql server 인증시
            string strConn =
                "server=localhost,1433; Database=KYUDB; UID=KimYongUk; PWD=123456;";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                // Do something here
                log.Debug("연결성공 "+conn);
            }
            catch (Exception ex)
            {
                log.Debug("연결실패");
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
