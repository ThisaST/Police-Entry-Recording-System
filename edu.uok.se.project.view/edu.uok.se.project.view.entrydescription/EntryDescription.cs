using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entrydescription
{
    public partial class EntryDescription : Form
    {
        

        public EntryDescription()
        {
            InitializeComponent();
        }

        private void entry_DescriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.entry_DescriptionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please Try Again..!" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        private void EntryDescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.entryDBDataSet.Entry);
            // TODO: This line of code loads data into the 'entryDBDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.entryDBDataSet.User);
            // TODO: This line of code loads data into the 'entryDBDataSet.Entry_Description' table. You can move, or remove it, as needed.
            this.entry_DescriptionTableAdapter.Fill(this.entryDBDataSet.Entry_Description);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UserIDDataGridView.SelectedRows)
            {
                user_idMaskedTextBox.Text = row.Cells[0].Value.ToString();

            }
        }

        private void EntryIDDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in EntryIDDataGridView.SelectedRows)
            {
                entry_idMaskedTextBox.Text = row.Cells[0].Value.ToString();

            }
        }

        private void date_of_IncidentLabel_Click(object sender, EventArgs e)
        {

        }

        private void time_Of_IncidentLabel_Click(object sender, EventArgs e)
        {

        }

        private void description_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void audio_LinksLabel_Click(object sender, EventArgs e)
        {

        }

        private void video_LinkLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            entry_DescriptionBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            entry_DescriptionBindingSource.RemoveCurrent();
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
