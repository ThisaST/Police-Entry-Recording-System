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
    class SearchEntryDetailsDBAccess
    {
        DatabaseConnection connection = new DatabaseConnection();


        //When Search using the NIC of the victim
        public DataTable VictimNicSearchVictimDetails(VictimModel victim_nic)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT * FROM [victim] WHERE NIC = '" + victim_nic.Nic + "'";

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

        public DataTable VictimNicSearchEntryDetails(VictimModel victim_nic)
        {
            try
            {
                SqlCommand command = new SqlCommand();


                command.Connection = connection.GetConnection();
                connection.OpenConnection();

                command.CommandText = "SELECT Entry.Entry_id ,  Entry.Entry_type ,  Entry.Entry_Added_Date , Entry_Description.Date_of_Incident , Entry_Description.Incident_type , Entry_Description.Vehicle_No , Entry_Description.Deaths , Entry_Description.Injuries " +
                    "FROM [Entry] ,  [Entry_Description] , Victim WHERE victim.victim_ID = Entry.victim_id AND Entry.entry_id = Entry_Description.entry_id AND victim.NIC = '" + victim_nic.Nic + "'";

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