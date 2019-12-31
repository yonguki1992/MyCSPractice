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
        private static readonly string SELECT_MULTIRESULT =
            "select * from scores where id=@id1; select * from scores where id=@id2";

        
        public static DataSet GetData()
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

        public static DataSet GetDataInPaging(int startRecord = 0, int maxRecords = MAX_RECORDS)
        {
            log.DebugFormat("GetDataInPaging 호출 startRecord={0}, maxRecords={1}",startRecord, maxRecords);

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

        public static DataSet GetDataMulti(int id1 = 1, int id2 = 2)
        {
            log.DebugFormat("GetDataInPaging 호출 id1={0}, id2={1}", id1, id2);

            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();

            //sqlCommand 초기화
            SqlCommand cmd = new SqlCommand(SELECT_MULTIRESULT, conn);

            //@id1~2 채워서 명령어 완성하기
            SqlParameter id1Param = new SqlParameter("@id1", SqlDbType.Int)
            {
                Value = id1
            };
            cmd.Parameters.Add(id1Param);
            SqlParameter id2Param = new SqlParameter("@id2", SqlDbType.Int)
            {
                Value = id2
            };
            cmd.Parameters.Add(id2Param);

            cmd.Prepare();
            //명령어를 sqlAdapter에 등록
            SqlDataAdapter adapter = new SqlDataAdapter()
            {
                SelectCommand = cmd
            };

            DataSet ds = new DataSet();
            adapter.Fill(ds, "scores");

            conn.Close();
            return ds;
        }

        public static int SelectCount()
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
