using Police_Entry_Recording_System.edu.uok.se.project.controller;
using Police_Entry_Recording_System.edu.uok.se.project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.search
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        VictimModel victim = new VictimModel();

        private void SearchEntryDetails_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchEntryDetailsLabel_Click(object sender, EventArgs e)
        {
            if (NICRadioButton.Checked)
            {
                // DataTable data_table = new DataTable();
                victim.Nic = SearchEntryDetails.Text;

                SearchEntryDetailsDBAccess dbaccess = new SearchEntryDetailsDBAccess();
                VictimDataGridView.DataSource = dbaccess.VictimNicSearchVictimDetails(victim);

                EntryDetailsSearchDataGridView.DataSource = dbaccess.VictimNicSearchEntryDetails(victim);


            }
            else if (FullNameRadioButton.Checked)
            {
                DataTable data_table = new DataTable();
                victim.FullName = SearchEntryDetails.Text;

                VictimSearchDBAccess dbaccess = new VictimSearchDBAccess();
                //data_table = dbaccess.
                //VictimDataGridView.DataSource = data_table;
            }
        }
    }
}
