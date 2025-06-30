using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace DB01
{
    internal class MySqlUtil
    {
        // mysql 접속 정보
        public string server;
        public string uid;
        public string pwd;
        public string database;
        public int port;
        public int time_out = 120;
        bool pooling = false;

        public MySqlUtil()
        {
            server = "127.0.0.1";
            uid = "test";
            pwd = "12345";
            database = "test";
            port = 3306;              // mysql 기본 포트
            time_out = 120;
            pooling = true;
        }

        public string get_connection_string()
        {
            string ret_str = string.Empty;
            string temp_str = @"server = " + this.server + "; database = " + this.database
                + "; user id = " + this.uid + "; password = " + this.pwd;
            if (this.port != 3306)
            {
                temp_str += "; port = " + this.port + "";
            }
            temp_str += "; CHARSET=utf8mb4; SslMode=none; Pooling =" + this.pooling + ";";
            temp_str += "; default command timeout=" + this.time_out + "; CharSet = utf8;";
            ret_str = temp_str;

            return ret_str;
        }

        public int login(string user_id, string user_pwd)
        {
            // 테이블에 user_id, user_pwd 인 user의 개수를 세서 반환하고 있다
            int user_count = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(get_connection_string()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) as cnt from users " +
                        " WHERE user_id = @user_id AND user_pwd = @user_pwd";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@user_pwd", user_pwd);
                    user_count = Convert.ToInt32(cmd.ExecuteScalar()); // Count, Min, Max 등 해당 값 결과가 리턴 됨
                                                             
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return (int)user_count;

        }

        public int update_user_login_date(string user_id)
        {
            int result = 0;

            // 사용자 로그인 시간 갱신
            try
            {
                using (MySqlConnection conn = new MySqlConnection(get_connection_string()))
                {
                    conn.Open();
                    string update_sql = "UPDATE users SET login_date = NOW()" +
                        "WHERE user_id = @user_id";
                    MySqlCommand cmd = new MySqlCommand(update_sql, conn);
                    cmd.CommandText = update_sql;
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    result = (int)cmd.ExecuteNonQuery();                // 몇개의 데이터가 업데이트 됐는지 그 개수를 리턴
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public Users get_user(string user_id)
        {
            Users user = new Users();

            // 사용자 ID를 이용해서 조회하여 Users를 찾아 가져온다
            try
            {
                using (MySqlConnection conn = new MySqlConnection(get_connection_string()))
                {
                    conn.Open();
                    // user_id로 조회해서 있으면 사용자 객체에 정보를 담아 반환한다
                    string sql = "SELECT * FROM users WHERE user_id = @user_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue ("@user_id", user_id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user.idx = reader.GetInt32("idx");
                        if (reader["user_id"] != DBNull.Value) // db에 해당 부분 값이 null이면 exception으로 넘어감
                        {
                            user.user_id = reader.GetString("user_id");
                        }
                        else
                        {
                            user.user_id = "";
                        }

                        if (reader["user_pwd"] != DBNull.Value)
                        {
                            user.user_pwd = reader.GetString("user_pwd");
                        }
                        else
                        {
                            user.user_pwd = "";
                        }

                        if (reader["user_role"] != DBNull.Value)
                        {
                            user.user_role = reader.GetString("user_role");
                        }
                        else
                        {
                            user.user_role = "";
                        }

                        if (reader["user_name"] != DBNull.Value)
                        {
                            user.user_name = reader.GetString("user_name");
                        }
                        else
                        {
                            user.user_name = "";
                        }

                        if (reader["login_date"] != DBNull.Value)
                        {
                            user.login_date = reader.GetDateTime("login_date");
                        }
                        else
                        {
                            user.login_date = DateTime.MinValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return user;
        }

        public List<Users> get_users()
        {
            List<Users> users = new List<Users>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(get_connection_string()))
                {
                    conn.Open();
                    string query = " SELECT * FROM users";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.CommandText = query;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Users tmp_user = new Users();
                        tmp_user.idx = reader.GetInt32("idx");
                        if (reader["user_id"] != DBNull.Value)
                            tmp_user.user_id = reader.GetString("user_id");
                        else
                            tmp_user.user_id = "";

                        if (reader["user_pwd"] != DBNull.Value)
                            tmp_user.user_pwd = reader.GetString("user_pwd");
                        else
                            tmp_user.user_pwd = "";

                        if (reader["user_role"] != DBNull.Value)
                            tmp_user.user_role = reader.GetString("user_role");
                        else
                            tmp_user.user_role = "";

                        if (reader["user_name"] != DBNull.Value)
                            tmp_user.user_name = reader.GetString("user_name");
                        else
                            tmp_user.user_name = "";

                        if (reader["login_date"] != DBNull.Value)
                            tmp_user.login_date = reader.GetDateTime("login_date");
                        else
                            tmp_user.login_date = DateTime.MinValue;

                        users.Add(tmp_user); // 리스트에 추가되는 사용자들을 넣어준다. 
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return users;
        }

        public int add_user(string user_id, string user_pwd, string user_name)
        {
            int result = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(get_connection_string()))
                {
                    conn.Open();
                    string query = "INSERT INTO users( user_id, user_pwd, user_name ) " +
                        "values( @user_id, @user_pwd, @user_name )";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@user_pwd", user_pwd);
                    cmd.Parameters.AddWithValue("@user_name", user_name);
                    result = cmd.ExecuteNonQuery();   // 몇개의 데이터가 들어갔는지 그 개수를 리턴
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }
    }
}
