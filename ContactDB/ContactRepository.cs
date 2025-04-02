using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ContactDB
{
    internal class ContactRepository : IContactRepository
    {
        private string connectionstring = "Data Source =DESKTOP-US98V30\\MYSQLSERVER;Initial Catalog =Contact_DB;Integrated security=true;TrustServerCertificate=True";
        public bool Delete(int contactID)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                string query = "Delete From  Contact Where contactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }

        public bool Insert(string name, string family, string adress, string emaill, string mobile, int age)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                string query = " Insert Into Contact (Name,Family,Mobile,Adress,Email,Age)Values(@name,@family,@mobile,@adress,@email,@age)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@family", family);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@adress", adress);
                command.Parameters.AddWithValue("@email", emaill);
                command.Parameters.AddWithValue("@age", age);
                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Search(string parameter)
        {
            string query = "select*from Contact WHERE Name LIKE  @parameter OR Family LIKE  @parameter";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {

            string query = "select*from Contact";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SelectRow(int contactID)
        {

            string query = "select*from Contact WHERE ContactID=" + contactID;
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int contactID, string name, string family, string adress, string emaill, string mobile, int age)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                string query = " UPDATE Contact  set Name=@name,Family=@family,Mobile=@mobile,Adress=@adress,Email=@mail,Age=@age WHERE ContactID=@id ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@family", family);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@adress", adress);
                command.Parameters.AddWithValue("@mail", emaill);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@id", contactID);
                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
