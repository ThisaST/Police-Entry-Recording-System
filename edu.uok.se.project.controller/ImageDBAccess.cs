using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.controller
{
    class ImageDBAccess
    {
        DatabaseConnection connection = new DatabaseConnection();


        //public System.Drawing.Image GetUserImage(string user_id)
        //{

        //    try
        //    {

        //        SqlCommand command = new SqlCommand();


        //        command.Connection = connection.GetConnection();
        //        connection.OpenConnection();

        //        command.CommandText = "SELECT [Image] FROM [User_Image] WHERE User_id = '" + user_id + "' ";

        //        DataTable datatable = new DataTable();
        //        SqlDataAdapter adapter = new SqlDataAdapter(command);

        //        adapter.Fill(datatable);

        //        return ;

        //    }
        //    catch (SqlException sql_exception)
        //    {
        //        MessageBox.Show(sql_exception.ToString());
        //        throw sql_exception;

        //    }

        //}
    }
}
