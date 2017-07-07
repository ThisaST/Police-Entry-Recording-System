using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.evidence
{
    public partial class EvidenceForm : Form
    {
        public EvidenceForm()
        {
            InitializeComponent();
        }

        private void evidenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.evidenceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please Try Again..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EvidenceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.entryDBDataSet.Entry);
            // TODO: This line of code loads data into the 'entryDBDataSet.Evidence' table. You can move, or remove it, as needed.
            this.evidenceTableAdapter.Fill(this.entryDBDataSet.Evidence);

        }

        private void evidence_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void equipmentsLabel_Click(object sender, EventArgs e)
        {

        }

        private void equipmentsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void evidence_DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void evidence_DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void evidence_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void entry_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void entry_idMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EntryIDDataDridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in EntryIDDataDridView.SelectedRows)
            {
                entry_idMaskedTextBox.Text = row.Cells[0].Value.ToString();

            }
        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            evidenceBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            evidenceBindingSource.RemoveCurrent();
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
