using Police_Entry_Recording_System.edu.uok.se.project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police_Entry_Recording_System.edu.uok.se.project.controller
{
    class UserSearchDBAccess
    {
        DatabaseConnection connection = new DatabaseConnection();


        //Method for access the database to search user records 
        ////// USING USER_ID
        public DataTable UserIdSearchData(UserDetailsModel userid)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT * FROM [User] WHERE User_id = '" + userid.UserID + "'";

                DataTable datatable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(datatable);
                connection.CloseConnection();

                return datatable;
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }


        //Method for access the database to search user records 
        ////// USING NIC
        public DataTable UserNICSearchData(UserDetailsModel user_nic)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT * FROM [User] WHERE NIC = '" + user_nic.Nic + "'";

                DataTable datatable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(datatable);
                connection.CloseConnection();

                return datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }



        //Method for access the database to search user records 
        ////// USING USER FULL NAME
        public DataTable UserFullNameSearch(UserDetailsModel user_fullname)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT * FROM [User] WHERE Full_Name LIKE '" + "%" + user_fullname.FullName + "%" + "'";

                DataTable datatable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(datatable);
                connection.CloseConnection();

                return datatable;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
