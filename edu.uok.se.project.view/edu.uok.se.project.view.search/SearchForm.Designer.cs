namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.search
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.FullNameRadioButton = new System.Windows.Forms.RadioButton();
            this.NICRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchEntryDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchEntryDetailsLabel = new System.Windows.Forms.Label();
            this.VictimDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.EntryDetailsSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VictimDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryDetailsSearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.FullNameRadioButton);
            this.groupBox1.Controls.Add(this.NICRadioButton);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.SearchEntryDetails);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(66, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Entry Records ";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 167);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(99, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Entry ID";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 124);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Victim ID";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // FullNameRadioButton
            // 
            this.FullNameRadioButton.AutoSize = true;
            this.FullNameRadioButton.Location = new System.Drawing.Point(23, 82);
            this.FullNameRadioButton.Name = "FullNameRadioButton";
            this.FullNameRadioButton.Size = new System.Drawing.Size(174, 24);
            this.FullNameRadioButton.TabIndex = 1;
            this.FullNameRadioButton.Text = "Victim Full Name";
            this.FullNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // NICRadioButton
            // 
            this.NICRadioButton.AutoSize = true;
            this.NICRadioButton.Checked = true;
            this.NICRadioButton.Location = new System.Drawing.Point(23, 43);
            this.NICRadioButton.Name = "NICRadioButton";
            this.NICRadioButton.Size = new System.Drawing.Size(120, 24);
            this.NICRadioButton.TabIndex = 0;
            this.NICRadioButton.TabStop = true;
            this.NICRadioButton.Text = "Victim NIC";
            this.NICRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchEntryDetails
            // 
            this.SearchEntryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEntryDetails.Location = new System.Drawing.Point(327, 82);
            this.SearchEntryDetails.Name = "SearchEntryDetails";
            this.SearchEntryDetails.Size = new System.Drawing.Size(301, 30);
            this.SearchEntryDetails.TabIndex = 1;
            this.SearchEntryDetails.TextChanged += new System.EventHandler(this.SearchEntryDetails_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Victim Details";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764625_search;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.SearchEntryDetailsLabel);
            this.panel4.Location = new System.Drawing.Point(678, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 46);
            this.panel4.TabIndex = 17;
            // 
            // SearchEntryDetailsLabel
            // 
            this.SearchEntryDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchEntryDetailsLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchEntryDetailsLabel.Name = "SearchEntryDetailsLabel";
            this.SearchEntryDetailsLabel.Size = new System.Drawing.Size(45, 46);
            this.SearchEntryDetailsLabel.TabIndex = 5;
            this.SearchEntryDetailsLabel.Click += new System.EventHandler(this.SearchEntryDetailsLabel_Click);
            // 
            // VictimDataGridView
            // 
            this.VictimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VictimDataGridView.Location = new System.Drawing.Point(120, 335);
            this.VictimDataGridView.Name = "VictimDataGridView";
            this.VictimDataGridView.RowTemplate.Height = 24;
            this.VictimDataGridView.Size = new System.Drawing.Size(788, 196);
            this.VictimDataGridView.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Entry Details";
            // 
            // EntryDetailsSearchDataGridView
            // 
            this.EntryDetailsSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntryDetailsSearchDataGridView.Location = new System.Drawing.Point(120, 603);
            this.EntryDetailsSearchDataGridView.Name = "EntryDetailsSearchDataGridView";
            this.EntryDetailsSearchDataGridView.RowTemplate.Height = 24;
            this.EntryDetailsSearchDataGridView.Size = new System.Drawing.Size(961, 176);
            this.EntryDetailsSearchDataGridView.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1469032685_close;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(1392, 913);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 64);
            this.panel1.TabIndex = 23;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t3;
            this.ClientSize = new System.Drawing.Size(1546, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EntryDetailsSearchDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VictimDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VictimDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryDetailsSearchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton FullNameRadioButton;
        private System.Windows.Forms.RadioButton NICRadioButton;
        private System.Windows.Forms.TextBox SearchEntryDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label SearchEntryDetailsLabel;
        private System.Windows.Forms.DataGridView VictimDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EntryDetailsSearchDataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}