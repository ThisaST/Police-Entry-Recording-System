using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.victim
{
    public partial class Victim : Form
    {
        public Victim()
        {
            InitializeComponent();
        }

        private void victimBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.victimBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Victim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Victim' table. You can move, or remove it, as needed.
            this.victimTableAdapter.Fill(this.entryDBDataSet.Victim);

        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            victimBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            victimBindingSource.RemoveCurrent();
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
