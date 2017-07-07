using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.witness
{
    public partial class WitnessDetails : Form
    {
        public WitnessDetails()
        {
            InitializeComponent();
        }

        private void witnessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.witnessBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WitnessDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Evidence' table. You can move, or remove it, as needed.
            this.evidenceTableAdapter.Fill(this.entryDBDataSet.Evidence);
            // TODO: This line of code loads data into the 'entryDBDataSet.Witness' table. You can move, or remove it, as needed.
            this.witnessTableAdapter.Fill(this.entryDBDataSet.Witness);

        }

        private void witness_Last_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EvidenceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in EvidenceDataGridView.SelectedRows)
            {
                evidence_IdTextBox.Text = row.Cells[0].Value.ToString();

            }
        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            witnessBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            witnessBindingSource.RemoveCurrent();
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
