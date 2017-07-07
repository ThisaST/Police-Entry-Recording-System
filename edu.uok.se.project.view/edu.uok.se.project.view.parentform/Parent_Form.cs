using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.courtcase;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entry;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.reports;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.search;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.parentform
{
    public partial class Parent_Form : Form
    {
        private string userid;

        public Parent_Form()
        {
            InitializeComponent();
            
        }

        public Parent_Form(string userid)
        {
            InitializeComponent();
            timer1.Start();
            this.userid = userid;
        }

        private void AddNewEntryLabel_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        //add new users to the system
        private void AddUsersLabel_Click(object sender, EventArgs e)
        {
            NewUsers newuser = new NewUsers();
            //newuser.MdiParent = this;
            newuser.ShowDialog();
        }

        private void AddNewEntryLabel_Click_1(object sender, EventArgs e)
        {
            //Entry_Details_ entry_detail = new Entry_Details_();
            //entry_detail.Show();

            Entry_Acess add_entry_details = new Entry_Acess(userid);
            //add_entry_details.MdiParent = this;
            add_entry_details.ShowDialog();
        }

        private void ReportsLabel_Click(object sender, EventArgs e)
        {
            ReportForm reports = new ReportForm();
            reports.ShowDialog();
        }

        private void UserPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void UserPictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.ShowDialog();
        }

        private void Parent_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.User_Image' table. You can move, or remove it, as needed.
            this.user_ImageTableAdapter.Fill(this.entryDBDataSet.User_Image);
            UserLabel.Text = userid;
        }

        private void CourtCaseLabel_Click(object sender, EventArgs e)
        {
            CourtCaseDetails courtcase = new CourtCaseDetails();
            courtcase.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Parent_Form form = new Parent_Form();
           // panel5.Location = new Point(form.MaximizedBounds.Width - 64, Location.Y);
            DialogResult answer;
            answer = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Logout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            
            
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login_Page page = new Login_Page();
                page.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date_time = DateTime.Now;
            TimeLabel.Text = date_time.ToLongDateString();
            TimeOnlyLabel.Text = date_time.ToLongTimeString();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

