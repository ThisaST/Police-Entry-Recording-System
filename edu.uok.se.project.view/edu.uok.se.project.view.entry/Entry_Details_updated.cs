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

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entry
{
    public partial class Entry_Details_updated : Form
    {

        VictimModel victim = new VictimModel();
        private Entry_Acess entry_Acess;
        private string userid;

        public Entry_Details_updated()
        {
            InitializeComponent();
        }

        public Entry_Details_updated(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        public Entry_Details_updated(string userid, Entry_Acess entry_Acess) : this(userid)
        {
            this.entry_Acess = entry_Acess;
            this.userid = userid;
        }

        

        private void entryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.entryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
                entry_Acess.EntryDescriptionLabel.Enabled = true;
                // description.entry_idMaskedTextBox.Text = entry_IDMaskedTextBox.Text;
                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Entry_Details_updated_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.entryDBDataSet.Entry);

        }

        private void SearchVictimLabel_Click(object sender, EventArgs e)
        {
            if (NICRaadioButton.Checked)
            {
                DataTable data_table = new DataTable();
                victim.Nic = SearchTextBox.Text;

                VictimSearchDBAccess dbaccess = new VictimSearchDBAccess();
                data_table = dbaccess.VictimNICSearchData(victim);
                VictimDataGridView.DataSource = data_table;

            }
            else if (FullNameRadioButton.Checked)
            {
                DataTable data_table = new DataTable();
                victim.FullName = SearchTextBox.Text;

                VictimSearchDBAccess dbaccess = new VictimSearchDBAccess();
                data_table = dbaccess.VictimFullNameSearch(victim);
                VictimDataGridView.DataSource = data_table;
            }
        }

        private void VictimDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VictimDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in VictimDataGridView.SelectedRows)
            {
                victim_idTextBox.Text = row.Cells[0].Value.ToString();

            }
        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            entryBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            entryBindingSource.RemoveCurrent();
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
