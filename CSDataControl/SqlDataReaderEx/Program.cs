using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly : log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SqlDataReaderEx
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private static readonly string CONNECTION =
            "server=localhost,1433; Database=KYUDB; UID=KimYongUk; PWD=123456;";
        private static readonly string SELECT_ALL =
            "select * from scores";
        private static readonly string SELECT_COUNT =
            "select count(*) from scores";
        private static readonly string SELECT_BY_ID =
            "select * from scores where id=@id";
        private static readonly string INSERT =
            "insert into scores(class, score) values(@class, @score)";
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            using (SqlConnection conn = new SqlConnection(CONNECTION))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SELECT_ALL, conn);

                //SqlDataReader 객체를 리턴
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string s = dataReader["Class"] as string;
                        // 또는 dataReader[1] as string / dataReader.GetString(1);
                        log.Debug(s);
                        sb.Append(s);
                    }
                    Console.WriteLine(sb.ToString());
                }
                
            }
        }

    }
}
