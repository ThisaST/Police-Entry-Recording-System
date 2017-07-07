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
    public partial class DisplayBReport : Form
    {
        public DisplayBReport()
        {
            InitializeComponent();
        }

        private void DisplayBReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entryDBDataSet.B_Report' table. You can move, or remove it, as needed.
            this.b_ReportTableAdapter.Fill(this.entryDBDataSet.B_Report);
            CreatingBreport breport = new CreatingBreport();
            breport.SetDataSource(this.entryDBDataSet);
            BreportViewer.ReportSource = breport;
        }
    }
}
