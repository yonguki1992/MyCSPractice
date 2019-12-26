using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapterEx
{
    class MySqlUtils
    {
        public const int MAX_RECORDS = 10;
        private static readonly ILog log = LogManager.GetLogger(typeof(MySqlUtils));
        private static readonly string CONNECTION =
            "server=localhost,1433; Database=KYUDB; UID=KimYongUk; PWD=123456;";
        private static readonly string SELECT_ALL =
            "select * from scores order by id desc";
        private static readonly string SELECT_COUNT =
            "select count(*) from scores";
        private static readonly string SELECT_BY_ID =
            "select * from scores where id=@id";
        private static readonly string INSERT =
            "insert into scores(class, score) values(@class, @score)";
        public DataSet GetData()
        {
            log.Debug("GetData 호출");

            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();
            //DataAdapter와 DataReader와 다른 점은 전자는 데이터를 가져와서 연결을 끊고
            // 후자는 데이터를 가져와도 연결을 유지한다는 것
            //sqlDataAdapter 초기화
            SqlDataAdapter adapter = new SqlDataAdapter(SELECT_ALL, conn);

            DataSet ds = new DataSet();
            //fill 메서드를 실행하여 결과 dataSet을 리턴받음
            adapter.Fill(ds);
            
            conn.Close();
            log.Debug("GetData 리턴 ds=" + ds.Tables);
            return ds;
        }

        public DataSet GetDataInPaging(int startRecord = 0, int maxRecords = MAX_RECORDS)
        {
            log.Debug("GetDataInPaging 호출");

            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();

            //sqlDataAdapter 초기화
            SqlDataAdapter adapter = new SqlDataAdapter(SELECT_ALL, conn);

            DataSet ds = new DataSet();
            //페이지 처음위치와 페이지 크기 지정 후 결과 dataSet을 리턴받음
            adapter.Fill(ds, startRecord, maxRecords, "scores");

            conn.Close();
            log.Debug("GetDataInPaging 리턴 ds=" + ds.Tables);
            return ds;
        }

        public int SelectCount()
        {

            using(SqlConnection conn = new SqlConnection(CONNECTION))
            {
                conn.Open();
                int count = 0;

                SqlCommand cmd = new SqlCommand(SELECT_COUNT, conn);

                count = (int)cmd.ExecuteScalar();

                return count;
            }

        }
    }
}
