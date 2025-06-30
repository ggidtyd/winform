using Final.Models;
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Final.DB
{
    public class DatabaseManager
    {
        private static string connStr = "server=localhost;database=student_db;uid=root;pwd=12345;charset=utf8;";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public static User getUser(string id, MySqlConnection conn)
        {
            User user = new User();

            try
            {
                string sql = "SELECT * FROM users WHERE user_id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.idx = reader.GetInt32("idx");
                    if (reader["user_id"] != DBNull.Value)
                    {
                        user.userId = reader.GetString("user_id");
                    }
                    else
                    {
                        user.userId = "";
                    }

                    if (reader["user_pw"] != DBNull.Value)
                    {
                        user.userPw = reader.GetString("user_pw");
                    }
                    else
                    {
                        user.userPw = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return user;
        }

        public static bool duplicateCheck(string student_number)
        {
            using (var conn = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM students WHERE student_number = @student_number";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@student_number", student_number);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count >= 1)
                    return true;
                else
                    return false;
            }

        }

        public static void delete(int idx)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = "DELETE FROM students WHERE idx = @idx";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idx", idx);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void save(string studentNumber, string name, string phone)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = "INSERT INTO students (student_number, name, phone) VALUES (@num, @name, @phone)";
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@num", studentNumber);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void edit(int idx, string studentNumber, string name, string phone)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = "UPDATE students SET student_number = @num, name = @name, phone = @phone WHERE idx = @idx"; ;
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idx", idx);
                    cmd.Parameters.AddWithValue("@num", studentNumber);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable read()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = "SELECT idx, student_number, name, phone FROM students";
                    var adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }
    }
}
