using Police_Entry_Recording_System.edu.uok.se.project.Model;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entrydescription;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.evidence;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.suspects;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.victim;
using Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.witness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entry
{
    public partial class Entry_Acess : Form
    {
        private string userid;

        public Entry_Acess()
        {
            InitializeComponent();
        }

        public Entry_Acess(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void VictimDetailsLabel_Click(object sender, EventArgs e)
        {
            Victim victim_ = new Victim();
            victim_.MdiParent = this;
            victim_.Show();
        }

        private void EntryDetailsLabel_Click(object sender, EventArgs e)
        {
            Entry_Details_updated update_entry = new Entry_Details_updated(userid , this);
            update_entry.MdiParent = this;
            update_entry.Show();
        }

        private void EntryDescriptionLabel_Click(object sender, EventArgs e)
        {
            EntryDescription new_description = new EntryDescription();
            new_description.MdiParent = this;
            new_description.Show();
        }

        private void SuspectDetailsLabel_Click(object sender, EventArgs e)
        {
            SuspectDetails suspect = new SuspectDetails();
            suspect.MdiParent = this;
            suspect.Show();
        }

        private void EvidenceLabel_Click(object sender, EventArgs e)
        {
            EvidenceForm evidence = new EvidenceForm();
            evidence.MdiParent = this;
            evidence.Show();
        }

        private void WitnessDetailsLabel_Click(object sender, EventArgs e)
        {
            WitnessDetails witness = new WitnessDetails();
            witness.MdiParent = this;
            witness.Show();
        }
    }
}
