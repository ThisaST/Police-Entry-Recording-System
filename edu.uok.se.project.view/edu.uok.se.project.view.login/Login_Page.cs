using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.parentform;
using System.Data.SqlClient;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entry;
using Police_Entry_Recording_System.edu.uok.se.project.Model;

namespace Police_Entry_Recording_System
{
    public partial class Login_Page : Form
    {
        public string currentUser;
        //Entry_Details_ details = new Entry_Details_();
        public Login_Page()
        {
            InitializeComponent();
        }

        UserLogin login = new UserLogin();
        private void LoginLabel_Click(object sender, EventArgs e)
        {
            bool validUserIdAndPassword;
            // get an object of userlogin class
            

            //get the user id entered
            if (UserIdMaskedTextBox.Equals("user-"))
            {
                MessageBox.Show("Please enter your user id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTextBox.Text = "";
            }
            else
            {
                login.UserID1 = UserIdMaskedTextBox.Text;
            }

            //get the password entered
            if (PasswordTextBox.Equals(""))
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                login.Password1 = PasswordTextBox.Text;
            }

            Login_Page page = new Login_Page();
            //Parent_Form parent = new Parent_Form();//temporary
            //connect to the database
            UserLoginDatabaseAccess data_access = new UserLoginDatabaseAccess();
            //loading.Show();
            //parent.Show(); //temporary

            //calling the db access class to access the database



            validUserIdAndPassword = data_access.AcceptLogin(login);

            if (validUserIdAndPassword)
            {
                Parent_Form parent = new Parent_Form(login.UserID1);

                
                
                //this.Close();
                
                parent.Show();


            }
            else
            {
                MessageBox.Show("Enter Valid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Parent_Form parent = new Parent_Form(login.UserID1);

            //parent.Show();
       

            }
        //LoadingWinForm loading = new LoadingWinForm();
        private void Login_Page_Load(object sender, EventArgs e)
        {
            UserIdMaskedTextBox.Text = "user-";
            PasswordTextBox.Text = "";
            
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginLabel_Click(this, new EventArgs());
            }
        }
    }
}
