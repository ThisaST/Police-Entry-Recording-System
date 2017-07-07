namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.parentform
{
    partial class Parent_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.user_ImageTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.User_ImageTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeOnlyLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.AddNewEtryPanel = new System.Windows.Forms.Panel();
            this.AddNewEntryLabel = new System.Windows.Forms.Label();
            this.AddNewUserPanel = new System.Windows.Forms.Panel();
            this.AddUsersLabel = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ReportsPanel = new System.Windows.Forms.Panel();
            this.ReportsLabel = new System.Windows.Forms.Label();
            this.CourtCasePanel = new System.Windows.Forms.Panel();
            this.CourtCaseLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.AddNewEtryPanel.SuspendLayout();
            this.AddNewUserPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.ReportsPanel.SuspendLayout();
            this.CourtCasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.UserPictureBox);
            this.panel1.Location = new System.Drawing.Point(45, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 482);
            this.panel1.TabIndex = 6;
            // 
            // userImageBindingSource
            // 
            this.userImageBindingSource.DataMember = "User_Image";
            this.userImageBindingSource.DataSource = this.entryDBDataSet;
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.AddNewEtryPanel);
            this.panel4.Controls.Add(this.AddNewUserPanel);
            this.panel4.Controls.Add(this.SearchPanel);
            this.panel4.Controls.Add(this.ReportsPanel);
            this.panel4.Controls.Add(this.CourtCasePanel);
            this.panel4.Location = new System.Drawing.Point(744, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 791);
            this.panel4.TabIndex = 10;
            // 
            // user_ImageTableAdapter
            // 
            this.user_ImageTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(90, 743);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(381, 66);
            this.TimeLabel.TabIndex = 15;
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeOnlyLabel
            // 
            this.TimeOnlyLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeOnlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOnlyLabel.ForeColor = System.Drawing.Color.White;
            this.TimeOnlyLabel.Location = new System.Drawing.Point(90, 841);
            this.TimeOnlyLabel.Name = "TimeOnlyLabel";
            this.TimeOnlyLabel.Size = new System.Drawing.Size(381, 66);
            this.TimeOnlyLabel.TabIndex = 16;
            this.TimeOnlyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1902, 239);
            this.panel8.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.Sri_Lanka_Police_logo_svg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(31, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 142);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1469032714_home;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(175, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 128);
            this.panel2.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.Capture;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(633, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(672, 152);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1469032685_close;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(1838, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 64);
            this.panel5.TabIndex = 12;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.background_texture_gradient_light_daAcdhd_wallpaper;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.LogoutLabel);
            this.panel7.Location = new System.Drawing.Point(422, 579);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 180);
            this.panel7.TabIndex = 5;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.ForeColor = System.Drawing.Color.Blue;
            this.LogoutLabel.Location = new System.Drawing.Point(3, 0);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(347, 180);
            this.LogoutLabel.TabIndex = 1;
            this.LogoutLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // AddNewEtryPanel
            // 
            this.AddNewEtryPanel.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.entry;
            this.AddNewEtryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewEtryPanel.Controls.Add(this.AddNewEntryLabel);
            this.AddNewEtryPanel.Location = new System.Drawing.Point(422, 134);
            this.AddNewEtryPanel.Name = "AddNewEtryPanel";
            this.AddNewEtryPanel.Size = new System.Drawing.Size(350, 180);
            this.AddNewEtryPanel.TabIndex = 3;
            // 
            // AddNewEntryLabel
            // 
            this.AddNewEntryLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddNewEntryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewEntryLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewEntryLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.AddNewEntryLabel.Location = new System.Drawing.Point(3, 0);
            this.AddNewEntryLabel.Name = "AddNewEntryLabel";
            this.AddNewEntryLabel.Size = new System.Drawing.Size(347, 180);
            this.AddNewEntryLabel.TabIndex = 1;
            this.AddNewEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewEntryLabel.Click += new System.EventHandler(this.AddNewEntryLabel_Click_1);
            // 
            // AddNewUserPanel
            // 
            this.AddNewUserPanel.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.new_user;
            this.AddNewUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewUserPanel.Controls.Add(this.AddUsersLabel);
            this.AddNewUserPanel.Location = new System.Drawing.Point(32, 133);
            this.AddNewUserPanel.Name = "AddNewUserPanel";
            this.AddNewUserPanel.Size = new System.Drawing.Size(352, 179);
            this.AddNewUserPanel.TabIndex = 3;
            // 
            // AddUsersLabel
            // 
            this.AddUsersLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddUsersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUsersLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsersLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.AddUsersLabel.Location = new System.Drawing.Point(1, 1);
            this.AddUsersLabel.Name = "AddUsersLabel";
            this.AddUsersLabel.Size = new System.Drawing.Size(346, 179);
            this.AddUsersLabel.TabIndex = 1;
            this.AddUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUsersLabel.Click += new System.EventHandler(this.AddUsersLabel_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.search_entry;
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPanel.Controls.Add(this.SearchLabel);
            this.SearchPanel.Location = new System.Drawing.Point(422, 351);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(350, 180);
            this.SearchPanel.TabIndex = 3;
            // 
            // SearchLabel
            // 
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Blue;
            this.SearchLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(347, 180);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SearchLabel.Click += new System.EventHandler(this.SearchLabel_Click);
            // 
            // ReportsPanel
            // 
            this.ReportsPanel.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.Reports;
            this.ReportsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportsPanel.Controls.Add(this.ReportsLabel);
            this.ReportsPanel.Location = new System.Drawing.Point(34, 351);
            this.ReportsPanel.Name = "ReportsPanel";
            this.ReportsPanel.Size = new System.Drawing.Size(350, 180);
            this.ReportsPanel.TabIndex = 2;
            // 
            // ReportsLabel
            // 
            this.ReportsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReportsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportsLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ReportsLabel.Location = new System.Drawing.Point(3, 0);
            this.ReportsLabel.Name = "ReportsLabel";
            this.ReportsLabel.Size = new System.Drawing.Size(346, 180);
            this.ReportsLabel.TabIndex = 1;
            this.ReportsLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ReportsLabel.Click += new System.EventHandler(this.ReportsLabel_Click);
            // 
            // CourtCasePanel
            // 
            this.CourtCasePanel.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.court_case;
            this.CourtCasePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CourtCasePanel.Controls.Add(this.CourtCaseLabel);
            this.CourtCasePanel.Location = new System.Drawing.Point(34, 579);
            this.CourtCasePanel.Name = "CourtCasePanel";
            this.CourtCasePanel.Size = new System.Drawing.Size(350, 180);
            this.CourtCasePanel.TabIndex = 4;
            // 
            // CourtCaseLabel
            // 
            this.CourtCaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.CourtCaseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CourtCaseLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourtCaseLabel.ForeColor = System.Drawing.Color.Blue;
            this.CourtCaseLabel.Location = new System.Drawing.Point(3, 0);
            this.CourtCaseLabel.Name = "CourtCaseLabel";
            this.CourtCaseLabel.Size = new System.Drawing.Size(347, 180);
            this.CourtCaseLabel.TabIndex = 1;
            this.CourtCaseLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CourtCaseLabel.Click += new System.EventHandler(this.CourtCaseLabel_Click);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userImageBindingSource, "Image", true));
            this.UserPictureBox.Location = new System.Drawing.Point(63, 32);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(363, 377);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            this.UserPictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.UserPictureBox_LoadCompleted);
            this.UserPictureBox.Click += new System.EventHandler(this.UserPictureBox_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserLabel.Location = new System.Drawing.Point(141, 436);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(175, 33);
            this.UserLabel.TabIndex = 1;
            // 
            // Parent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1037);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.TimeOnlyLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parent_Form";
            this.Text = "Parent_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Parent_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.AddNewEtryPanel.ResumeLayout(false);
            this.AddNewUserPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.ReportsPanel.ResumeLayout(false);
            this.CourtCasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ReportsLabel;
        private System.Windows.Forms.Panel ReportsPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Panel AddNewEtryPanel;
        private System.Windows.Forms.Label AddNewEntryLabel;
        private System.Windows.Forms.Panel AddNewUserPanel;
        private System.Windows.Forms.Label AddUsersLabel;
        private System.Windows.Forms.Panel CourtCasePanel;
        private System.Windows.Forms.Label CourtCaseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource userImageBindingSource;
        private EntryDBDataSetTableAdapters.User_ImageTableAdapter user_ImageTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimeOnlyLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label UserLabel;
    }
}