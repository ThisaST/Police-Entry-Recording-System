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

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.user
{
    public partial class NewUsers : Form
    {

        UserSearchDBAccess search_users = new UserSearchDBAccess();

        public NewUsers()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.userBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured.. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NewUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.User' table. You can move, or remove it, as needed.
            
            //passwordTextBox.Text = "";

            this.userTableAdapter.Fill(this.entryDBDataSet.User);

        }


        //clear all the textboxes and others once

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            userBindingSource.RemoveCurrent();
        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            userBindingSource.AddNew();

            created_TimeMaskedTextBox.Text = DateTime.Now.ToString("h:mm:ss tt");
            last_Update_DateDateTimePicker.Text = DateTime.Now.ToString();

        }

        private void created_TimeMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {
            UserDetailsModel user_details = new UserDetailsModel();
            DataTable data_table = new DataTable();

            //search using ID

            if (SearchUsingUser_id.Checked)
            {
                user_details.UserID = SearchTextBox.Text;
                

                data_table = search_users.UserIdSearchData(user_details);

                UserDataGirView.DataSource = data_table;
            }
            else if (SearchUsingNICRadioButton.Checked)     // search using nic
            {
                user_details.Nic = SearchTextBox.Text;

                data_table = search_users.UserNICSearchData(user_details);

                UserDataGirView.DataSource = data_table;
            }
            else if (SearchUsingFullNameRadioButton.Checked)   //search using full name
            {
                user_details.FullName = SearchTextBox.Text;

                data_table = search_users.UserFullNameSearch(user_details);

                UserDataGirView.DataSource = data_table;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserImageLabel_Click(object sender, EventArgs e)
        {
            UserImage image = new UserImage();
            image.Show();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
