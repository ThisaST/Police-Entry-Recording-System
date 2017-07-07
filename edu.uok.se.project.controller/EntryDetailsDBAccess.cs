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
    class EntryDetailsDBAccess
    {
        DatabaseConnection connection = new DatabaseConnection();
        public DataTable VictimNICSearchData(VictimModel victim_nic)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT * FROM Entry WHERE NIC IN (SELECT NIC FROM [Victim] WHERE NIC = '" + victim_nic.Nic + "')";

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
        public DataTable VictimFullNameSearch(VictimModel victim_fullname)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT * FROM [Entry] WHERE Full_Name IN (SELECT Full_Name FROM Victim WHERE Full_Name LIKE '" + "%" + victim_fullname.FullName + "%" + "')";

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

