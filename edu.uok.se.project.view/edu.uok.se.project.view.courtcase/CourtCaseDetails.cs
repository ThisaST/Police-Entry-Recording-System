using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.courtcase
{
    public partial class CourtCaseDetails : Form
    {
        public CourtCaseDetails()
        {
            InitializeComponent();
        }

        private void court_CaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.court_CaseBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured.. Please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CourtCaseDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.entryDBDataSet.Entry);
            // TODO: This line of code loads data into the 'entryDBDataSet.Court_Case' table. You can move, or remove it, as needed.
            this.court_CaseTableAdapter.Fill(this.entryDBDataSet.Court_Case);

        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            court_CaseBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            court_CaseBindingSource.RemoveCurrent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login_Page page = new Login_Page();
                page.Show();
            }
        }
    }
}
