using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Milestone2
{
    class DataHandler
    {
        public DataHandler()
        {

        }

        string conn = "Server=(local); Initial Catalog= Milestone_2_PRG_282; Integrated Security = SSPI";

        public DataTable displayStudents()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void insertStudent(int id, string name, string surname, string dob, string gender, int number, string address, string modulecode)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudId", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", number);
                cmd.Parameters.AddWithValue("@StreetAddress", address);
                cmd.Parameters.AddWithValue("@ModuleCode", modulecode);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateStudent(int id, string name, string surname, string dob, string gender, int number, string address, string modulecode)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudId", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", number);
                cmd.Parameters.AddWithValue("@StreetAddress", address);
                cmd.Parameters.AddWithValue("@ModuleCode", modulecode);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteStudent(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudId", id);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchStudent(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudId", id);

                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public DataTable displayModules()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetModule", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    public void insertModule(string modulecode, string name, string description, string link)
    {
        using (SqlConnection connect = new SqlConnection(conn))
        {
            SqlCommand cmd = new SqlCommand("spAddModule", connect);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ModuleCode", modulecode);
            cmd.Parameters.AddWithValue("@ModuleName", name);
            cmd.Parameters.AddWithValue("@ModuleDescription", description);
            cmd.Parameters.AddWithValue("@Link", link);
            

            connect.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void updateModule(string modulecode, string name, string description, string link)
    {
        using (SqlConnection connect = new SqlConnection(conn))
        {
            SqlCommand cmd = new SqlCommand("spUpdateModule", connect);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ModuleCode", modulecode);
            cmd.Parameters.AddWithValue("@ModuleName", name);
            cmd.Parameters.AddWithValue("@ModuleDescription", description);
            cmd.Parameters.AddWithValue("@Link", link);

            connect.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void deleteModule(string modulecode)
    {
        using (SqlConnection connect = new SqlConnection(conn))
        {
            SqlCommand cmd = new SqlCommand("spDeleteModule", connect);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ModuleId", modulecode);

            connect.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public DataTable searchModule(string modulecode)
    {
        using (SqlConnection connect = new SqlConnection(conn))
        {
            SqlCommand cmd = new SqlCommand("spSerachModule", connect);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ModuleCode", modulecode);

            connect.Open();
            DataTable dt = new DataTable();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dt.Load(dr);
                return dt;
            }
        }
    }

    public void register(string user, string pass)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spRegister", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void login(string user, string pass)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spLogin", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

  }
}
