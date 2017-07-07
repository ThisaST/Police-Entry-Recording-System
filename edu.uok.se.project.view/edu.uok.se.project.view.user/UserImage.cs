using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.webcam;
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
    public partial class UserImage : Form
    {
        public UserImage()
        {
            InitializeComponent();
        }

        private void user_ImageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.user_ImageBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.entryDBDataSet);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Image_id you entered is already exist...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UserImage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.User_Image' table. You can move, or remove it, as needed.
            this.user_ImageTableAdapter.Fill(this.entryDBDataSet.User_Image);

        }

        private void TakePictureButton_Click(object sender, EventArgs e)
        {
            WebCam webcam = new WebCam();
            webcam.Show();
         }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            UserImageChooseFileDialog.FileName = "";

            if(UserImageChooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(UserImageChooseFileDialog.FileName);
            }
        }

        private void AddNewUserLabel_Click(object sender, EventArgs e)
        {
            user_ImageBindingSource.AddNew();
        }

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            user_ImageBindingSource.RemoveCurrent();
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
