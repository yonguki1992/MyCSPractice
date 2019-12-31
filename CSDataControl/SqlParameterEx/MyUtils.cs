using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlParameterEx
{
    class MyUtils
    {
        public const int MAX_RECORDS = 10;
        private static readonly ILog log = LogManager.GetLogger(typeof(MyUtils));
        private static readonly string CONNECTION =
            "server=localhost,1433; Database=KYUDB; UID=KimYongUk; PWD=123456;";


        private static readonly string SELECT_BY_DATE =
            "SELECT * FROM scores WHERE class=@Class AND lastupdate>=@lastUpdate";

        public static DataSet GetScores(string Class, DateTime lastUpdate)
        {
            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();
            SqlCommand cmd = new SqlCommand(SELECT_BY_DATE, conn);

            // 컬럼 지정 예시1)
            //SqlParameter classParam = new SqlParameter("@Class", SqlDbType.NVarChar, Class.Length)
            //{
            //    Value = Class
            //};
            //cmd.Parameters.Add(classParam);

            //SqlParameter lastUpdateParam = new SqlParameter("@lastUpdate", SqlDbType.DateTime)
            //{
            //    Value = lastUpdate
            //};
            //cmd.Parameters.Add(lastUpdateParam);
            
            // 1처럼 생성자에 타입 지정하고 값을 대입해도 되지만
            // 2처럼 AddWithValue를 이용해 타입지정 없이 대입 가능
            
            //컬럼지정 예시2)
            cmd.Parameters.AddWithValue("@Class", Class);
            cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "scores");

            conn.Close();

            return dataSet;
        }

        // E를 포함하는 모든 것들
        // ds = QueryByClass("E");
        private static readonly string SELECT_BY_CLASS_LIKE =
            "SELECT * FROM scores WHERE class LIKE @Class";
        // 안 됨
        //private static readonly string SELECT_BY_CLASS_LIKE2 = "SELECT * FROM scores WHERE @Class";

        public static DataSet QueryByClass(string str)
        {
            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();

            SqlCommand cmd = new SqlCommand(SELECT_BY_CLASS_LIKE, conn);

            StringBuilder sb = new StringBuilder();
            //sb.Append(str).Append("%"); // str 로 시작하는 문자열
            //sb.Append("%").Append(str); //str로 끝나는 문자열
            sb.Append("%").Append(str).Append("%"); //str이 포함된 문자열

            cmd.Parameters.AddWithValue("@Class", sb.ToString());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            conn.Close();
            return ds;
        }


        //저장된 프로시져 사용하기
        public static int[] UsingStoredProcedure(int p_in)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTION))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_GetCount", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //입력 변수
                SqlParameter pInput = new SqlParameter("@in", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Input,
                    Value = p_in
                };
                cmd.Parameters.Add(pInput);

                //출력 변수
                SqlParameter pOutput = new SqlParameter("@out", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pOutput);

                // 반환값
                SqlParameter pResult = new SqlParameter()
                {
                    Direction = ParameterDirection.ReturnValue
                };
                cmd.Parameters.Add(pResult);

                // 프로시져 sp_GetNext 실행
                cmd.ExecuteNonQuery();

                //sqlParameter에 저장
                int[] results = new int[]
                {
                    (int)pOutput.Value, (int)pResult.Value
                };

                return results;
            }
        }
    }
}
