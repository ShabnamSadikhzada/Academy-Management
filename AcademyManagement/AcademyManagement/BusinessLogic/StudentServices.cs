using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyManagement.Models;

namespace AcademyManagement.BusinessLogic;

public class StudentServices
{
    string connection = "server=.,1404;database=Academy Management;uid=sa;pwd=Pro247!!;";
    public void CreateStudent(Student st)
    {
        using SqlConnection con = new SqlConnection(connection);
        using SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = $"insert into Students (FirstName, LastName, Username, Password) VALUES(@firstName, @lastName, @username, @password);";
        cmd.Parameters.AddWithValue("FirstName", st.FirstName);
        cmd.Parameters.AddWithValue("LastName", st.LastName);
        cmd.Parameters.AddWithValue("Username", st.Username);
        cmd.Parameters.AddWithValue("Password", st.Password);

        cmd.CommandType = CommandType.Text;

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        bool result = cmd.ExecuteNonQuery() > 0;
        Console.WriteLine(result);
    }

    public void UpdateStudent(int id, string newFirstName)
    {
        using SqlConnection con = new SqlConnection(connection);
        using SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = $"select FirstName, LastName, Username, Password from Students where id = @id";
        cmd.Parameters.AddWithValue("id", id);

        cmd.CommandText = $"update Students set firstname = @newName where id = @id";
        cmd.Parameters.AddWithValue("newName", newFirstName);

        cmd.CommandType = CommandType.Text;

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        bool result = cmd.ExecuteNonQuery() > 0;
        Console.WriteLine(result);
    }

    public void DeleteStudent(int id)
    {
        using SqlConnection con = new SqlConnection(connection);
        using SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = $"delete from Students where id = @id";
        cmd.Parameters.AddWithValue("id", id);

        cmd.CommandType = CommandType.Text;

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        bool result = cmd.ExecuteNonQuery() > 0;
        Console.WriteLine(result);
    }
}
