namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.reports
{
    partial class ReportForm
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
            this.GenerateBReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateBReport
            // 
            this.GenerateBReport.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.thumb_350_688200;
            this.GenerateBReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBReport.ForeColor = System.Drawing.Color.White;
            this.GenerateBReport.Location = new System.Drawing.Point(-1, 33);
            this.GenerateBReport.Name = "GenerateBReport";
            this.GenerateBReport.Size = new System.Drawing.Size(142, 119);
            this.GenerateBReport.TabIndex = 0;
            this.GenerateBReport.Text = "B report";
            this.GenerateBReport.UseVisualStyleBackColor = true;
            this.GenerateBReport.Click += new System.EventHandler(this.GenerateBReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GenerateBReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 565);
            this.panel1.TabIndex = 1;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 565);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateBReport;
        private System.Windows.Forms.Panel panel1;
    }
}