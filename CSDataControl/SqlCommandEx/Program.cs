using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly : log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SqlCommandEx
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private static readonly string strConn =
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
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                int sw = -1;
                conn.Open();

                while (sw != 0)
                {
                    Console.WriteLine("번호를 입력해주세요.");
                    Console.WriteLine("  1. Select ALL");
                    Console.WriteLine("  2. Select Count");
                    Console.WriteLine("  3. Select by ID");
                    Console.WriteLine("  4. Insert");
                    Console.WriteLine("  0. Exit");

                    try
                    {
                        sw = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException fe)
                    {
                        log.Error(fe);
                        sw = 0;
                    }
                    
                    switch (sw)
                    {
                        case 1:
                            Console.WriteLine("select all");
                            SelectAll(conn);
                            break;
                        case 2:
                            Console.WriteLine("select count");
                            Console.WriteLine("==============================================================");
                            Console.WriteLine("레코드 수 : " + SelectCount(conn));
                            Console.WriteLine("==============================================================");
                            break;
                        case 3:
                            int id = 0;
                            try
                            {
                                Console.WriteLine("select by id");
                                id = int.Parse(Console.ReadLine());
                                SelectById(conn, id);
                            }
                            catch (FormatException fe)
                            {
                                log.Error(fe);
                            }
                            break;
                        case 4:
                            Console.WriteLine("insert");
                            ScoresVO vo = new ScoresVO();
                            Console.Write("Class를 입력해주세요. > ");
                            vo.Class = Console.ReadLine();
                            vo.Score = new Random().Next(50, 100);
                            try
                            {
                                Console.Write("점수를 입력해주세요. > ");
                                vo.Score = int.Parse(Console.ReadLine());
                                Insert(conn, vo);
                            }
                            catch (FormatException fe)
                            {

                                log.Error(fe);
                            }
                            break;
                    }
                }

            }

            
        }

        private static int SelectCount(SqlConnection conn)
        {
            log.Debug("SelectCount 호출");
            int count = 0;

            //jdbc의 Statement와 비슷하다.
            SqlCommand cmd = new SqlCommand(SELECT_COUNT, conn);
            count = (int)cmd.ExecuteScalar();

            return count;
        }

        private static void Insert(SqlConnection conn, ScoresVO vo)
        {
            log.Debug("Insert 호출 vo="+vo.ToString());
            SqlCommand cmd = new SqlCommand(null, conn);
            cmd.CommandText = INSERT;

            //===========================================================================
            SqlParameter classParam = new SqlParameter("@class", SqlDbType.NVarChar, vo.Class.Length)
            {
                Value = vo.Class
            };

            SqlParameter scoreParam = new SqlParameter("@score", SqlDbType.Int)
            {
                Value = vo.Score
            };
            
            cmd.Parameters.Add(classParam);
            cmd.Parameters.Add(scoreParam);
            
            // 완성된 명령어로 준비
            cmd.Prepare();
            // 실행
            //===========================================================================
            // 특정 쿼리문 (ex: insert update delete 등등)
            cmd.ExecuteNonQuery();
        }

        // SqlCommand.Prepare()이용하여 쿼리 완성
        private static void SelectById(SqlConnection conn, int id)
        {
            //TSQL  문장과 Connection 객체를 지정
            SqlCommand cmd = new SqlCommand(null, conn);

            //===========================================================================
            cmd.CommandText = SELECT_BY_ID;
            // 내용 채우기
            SqlParameter idParameter = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = id
            };

            // 채운것 커맨드에 추가
            cmd.Parameters.Add(idParameter);

            //실행
            cmd.Prepare();
            //===========================================================================

            Console.WriteLine("==============================================================");
            // 데이터는 서버에서 가져오도록 실행
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    int i = dataReader.GetInt32(0);
                    string clas = dataReader.GetString(1);
                    int score = dataReader.GetInt32(2);
                    DateTime lastUpdate = dataReader.GetDateTime(3);

                    Console.WriteLine(string.Format("id : {0} / class : {1} / score : {2} / lastUpdate : {3}",
                                i, clas, score, lastUpdate.ToShortDateString()));
                }

            }

            Console.WriteLine("==============================================================");
        }

        private static void SelectAll(SqlConnection conn)
        {
            //TSQL  문장과 Connection 객체를 지정
            SqlCommand cmd = new SqlCommand(SELECT_ALL, conn);

            Console.WriteLine("==============================================================");
            // 데이터는 서버에서 가져오도록 실행
            // jdbc의 ResultSet 과 비슷함
            // 한줄씩 이동해야하며, 사용이 끝나면 close 해줘야 하는 것 까지 모두 같음
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    //Getter 를 사용
                    //int id = dataReader.GetInt32(0);
                    //string clas = dataReader.GetString(1);
                    //int score = dataReader.GetInt32(2);
                    //DateTime lastUpdate = dataReader.GetDateTime(3);

                    // 인덱서를 사용(컬럼명 대신 숫자를 써도 됨)
                    int id = (int)dataReader["Id"];
                    string clas = dataReader["Class"] as string;
                    int score = (int)dataReader["Score"];
                    DateTime lastUpdate = (DateTime)dataReader["LastUpdate"];

                    Console.WriteLine(string.Format("id : {0} / class : {1} / score : {2} / lastUpdate : {3}",
                                id, clas, score, lastUpdate.ToShortDateString()));
                }

            }             
            Console.WriteLine("==============================================================");
        }

    }
}
