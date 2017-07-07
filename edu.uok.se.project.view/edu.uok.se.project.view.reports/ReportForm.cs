using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void GenerateBReport_Click(object sender, EventArgs e)
        {
            DisplayBReport report = new DisplayBReport();
            report.MdiParent = this;
            report.Show();
        }
    }
}
