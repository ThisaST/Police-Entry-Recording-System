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
    public partial class SuspectDetails : Form
    {
        public SuspectDetails()
        {
            InitializeComponent();
        }

        private void suspectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.suspectsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
                EntrySuspect entry_suspect = new EntrySuspect(suspect_idTextBox.Text);
                entry_suspect.ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void SuspectDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Suspects' table. You can move, or remove it, as needed.
            this.suspectsTableAdapter.Fill(this.entryDBDataSet.Suspects);

        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            suspectsBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            suspectsBindingSource.RemoveCurrent();
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
