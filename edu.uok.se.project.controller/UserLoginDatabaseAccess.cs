using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.parentform;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System
{
    class UserLoginDatabaseAccess
    {
        DatabaseConnection connection = new DatabaseConnection();
        

        public bool AcceptLogin(UserLogin user_login)
        {

            try
            {

                SqlCommand command = new SqlCommand();
                

                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT User_id, Password FROM [User] WHERE User_id = '" + user_login.UserID1 + "' AND Password = '" + user_login.Password1 + "' ";
                
                DataTable datatable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(datatable);

                return (datatable.Rows.Count == 1);

            }
            catch (SqlException sql_exception)
            {
                MessageBox.Show(sql_exception.ToString());
                throw sql_exception;
                
            }
            
        }
    }
}
