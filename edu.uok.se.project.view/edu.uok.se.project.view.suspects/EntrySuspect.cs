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

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.suspects
{
    public partial class EntrySuspect : Form
    {
        VictimModel victim = new VictimModel();

        public EntrySuspect()
        {
            InitializeComponent();
        }

        public EntrySuspect(string text)
        {
            Text = text;
        }

        private void entry_SuspectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.entry_SuspectBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EntrySuspect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Entry_Suspect' table. You can move, or remove it, as needed.
            this.entry_SuspectTableAdapter.Fill(this.entryDBDataSet.Entry_Suspect);
            suspect_idTextBox.Text = Text;
        }

        private void SearchVictimLabel_Click(object sender, EventArgs e)
        {
            if (NICRaadioButton.Checked)
            {
                DataTable data_table = new DataTable();
                victim.Nic = SearchTextBox.Text;

                VictimSearchDBAccess dbaccess = new VictimSearchDBAccess();
                data_table = dbaccess.VictimNICSearchData(victim);
                dataGridView1.DataSource = data_table;

            }
            else if (FullNameRadioButton.Checked)
            {
                DataTable data_table = new DataTable();
                victim.FullName = SearchTextBox.Text;

                VictimSearchDBAccess dbaccess = new VictimSearchDBAccess();
                data_table = dbaccess.VictimFullNameSearch(victim);
                dataGridView1.DataSource = data_table;
            }
        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            entry_SuspectBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            entry_SuspectBindingSource.RemoveCurrent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
