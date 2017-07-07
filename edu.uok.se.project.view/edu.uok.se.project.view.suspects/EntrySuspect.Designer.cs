namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.suspects
{
    partial class EntrySuspect
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
            System.Windows.Forms.Label suspect_idLabel;
            System.Windows.Forms.Label entry_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrySuspect));
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
            this.entry_SuspectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entry_SuspectTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.Entry_SuspectTableAdapter();
            this.tableAdapterManager = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager();
            this.entry_SuspectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.entry_SuspectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.suspect_idTextBox = new System.Windows.Forms.TextBox();
            this.entry_idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullNameRadioButton = new System.Windows.Forms.RadioButton();
            this.NICRaadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchVictimLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewUserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            suspect_idLabel = new System.Windows.Forms.Label();
            entry_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_SuspectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_SuspectBindingNavigator)).BeginInit();
            this.entry_SuspectBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // suspect_idLabel
            // 
            suspect_idLabel.AutoSize = true;
            suspect_idLabel.BackColor = System.Drawing.Color.Transparent;
            suspect_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            suspect_idLabel.ForeColor = System.Drawing.Color.White;
            suspect_idLabel.Location = new System.Drawing.Point(150, 122);
            suspect_idLabel.Name = "suspect_idLabel";
            suspect_idLabel.Size = new System.Drawing.Size(104, 20);
            suspect_idLabel.TabIndex = 1;
            suspect_idLabel.Text = "Suspect id:";
            // 
            // entry_idLabel
            // 
            entry_idLabel.AutoSize = true;
            entry_idLabel.BackColor = System.Drawing.Color.Transparent;
            entry_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_idLabel.ForeColor = System.Drawing.Color.White;
            entry_idLabel.Location = new System.Drawing.Point(150, 242);
            entry_idLabel.Name = "entry_idLabel";
            entry_idLabel.Size = new System.Drawing.Size(80, 20);
            entry_idLabel.TabIndex = 3;
            entry_idLabel.Text = "Entry id:";
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entry_SuspectBindingSource
            // 
            this.entry_SuspectBindingSource.DataMember = "Entry_Suspect";
            this.entry_SuspectBindingSource.DataSource = this.entryDBDataSet;
            // 
            // entry_SuspectTableAdapter
            // 
            this.entry_SuspectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Court_CaseTableAdapter = null;
            this.tableAdapterManager.Entry_DescriptionTableAdapter = null;
            this.tableAdapterManager.Entry_SuspectTableAdapter = this.entry_SuspectTableAdapter;
            this.tableAdapterManager.EntryTableAdapter = null;
            this.tableAdapterManager.EvidenceTableAdapter = null;
            this.tableAdapterManager.SuspectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_ImageTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VictimTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // entry_SuspectBindingNavigator
            // 
            this.entry_SuspectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.entry_SuspectBindingNavigator.BindingSource = this.entry_SuspectBindingSource;
            this.entry_SuspectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entry_SuspectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.entry_SuspectBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.entry_SuspectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.entry_SuspectBindingNavigatorSaveItem});
            this.entry_SuspectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entry_SuspectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entry_SuspectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entry_SuspectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entry_SuspectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entry_SuspectBindingNavigator.Name = "entry_SuspectBindingNavigator";
            this.entry_SuspectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entry_SuspectBindingNavigator.Size = new System.Drawing.Size(1301, 27);
            this.entry_SuspectBindingNavigator.TabIndex = 0;
            this.entry_SuspectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // entry_SuspectBindingNavigatorSaveItem
            // 
            this.entry_SuspectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entry_SuspectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entry_SuspectBindingNavigatorSaveItem.Image")));
            this.entry_SuspectBindingNavigatorSaveItem.Name = "entry_SuspectBindingNavigatorSaveItem";
            this.entry_SuspectBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.entry_SuspectBindingNavigatorSaveItem.Text = "Save Data";
            this.entry_SuspectBindingNavigatorSaveItem.Click += new System.EventHandler(this.entry_SuspectBindingNavigatorSaveItem_Click);
            // 
            // suspect_idTextBox
            // 
            this.suspect_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entry_SuspectBindingSource, "Suspect_id", true));
            this.suspect_idTextBox.Location = new System.Drawing.Point(277, 122);
            this.suspect_idTextBox.Name = "suspect_idTextBox";
            this.suspect_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.suspect_idTextBox.TabIndex = 2;
            // 
            // entry_idMaskedTextBox
            // 
            this.entry_idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entry_SuspectBindingSource, "Entry_id", true));
            this.entry_idMaskedTextBox.Location = new System.Drawing.Point(234, 239);
            this.entry_idMaskedTextBox.Name = "entry_idMaskedTextBox";
            this.entry_idMaskedTextBox.Size = new System.Drawing.Size(143, 22);
            this.entry_idMaskedTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.FullNameRadioButton);
            this.groupBox1.Controls.Add(this.NICRaadioButton);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(483, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Entry ID ";
            // 
            // FullNameRadioButton
            // 
            this.FullNameRadioButton.AutoSize = true;
            this.FullNameRadioButton.Location = new System.Drawing.Point(25, 61);
            this.FullNameRadioButton.Name = "FullNameRadioButton";
            this.FullNameRadioButton.Size = new System.Drawing.Size(174, 24);
            this.FullNameRadioButton.TabIndex = 19;
            this.FullNameRadioButton.Text = "Victim Full Name";
            this.FullNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // NICRaadioButton
            // 
            this.NICRaadioButton.AutoSize = true;
            this.NICRaadioButton.Checked = true;
            this.NICRaadioButton.Location = new System.Drawing.Point(25, 34);
            this.NICRaadioButton.Name = "NICRaadioButton";
            this.NICRaadioButton.Size = new System.Drawing.Size(120, 24);
            this.NICRaadioButton.TabIndex = 18;
            this.NICRaadioButton.TabStop = true;
            this.NICRaadioButton.Text = "Victim NIC";
            this.NICRaadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(228, 39);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(330, 30);
            this.SearchTextBox.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumBlue;
            this.panel4.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764625_search;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.SearchVictimLabel);
            this.panel4.Location = new System.Drawing.Point(584, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 46);
            this.panel4.TabIndex = 16;
            // 
            // SearchVictimLabel
            // 
            this.SearchVictimLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchVictimLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchVictimLabel.Name = "SearchVictimLabel";
            this.SearchVictimLabel.Size = new System.Drawing.Size(45, 46);
            this.SearchVictimLabel.TabIndex = 5;
            this.SearchVictimLabel.Click += new System.EventHandler(this.SearchVictimLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 238);
            this.dataGridView1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764311_add_user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.AddNewUserLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(146, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 64);
            this.panel2.TabIndex = 36;
            // 
            // AddNewUserLabel
            // 
            this.AddNewUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddNewUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddNewUserLabel.Location = new System.Drawing.Point(0, 0);
            this.AddNewUserLabel.Name = "AddNewUserLabel";
            this.AddNewUserLabel.Size = new System.Drawing.Size(64, 64);
            this.AddNewUserLabel.TabIndex = 30;
            this.AddNewUserLabel.Click += new System.EventHandler(this.AddNewUserLabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 64);
            this.label3.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764270_save;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.SaveLabel);
            this.panel6.Location = new System.Drawing.Point(249, 383);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 64);
            this.panel6.TabIndex = 37;
            // 
            // SaveLabel
            // 
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SaveLabel.Location = new System.Drawing.Point(0, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(64, 64);
            this.SaveLabel.TabIndex = 33;
            this.SaveLabel.Click += new System.EventHandler(this.entry_SuspectBindingNavigatorSaveItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764647_cancel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.CancelLabel);
            this.panel3.Location = new System.Drawing.Point(358, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 64);
            this.panel3.TabIndex = 38;
            // 
            // CancelLabel
            // 
            this.CancelLabel.BackColor = System.Drawing.Color.Transparent;
            this.CancelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CancelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelLabel.Location = new System.Drawing.Point(0, 0);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(64, 64);
            this.CancelLabel.TabIndex = 31;
            this.CancelLabel.Click += new System.EventHandler(this.CancelLabel_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1469032685_close;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.CloseLabel);
            this.panel8.Location = new System.Drawing.Point(1215, 383);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(64, 64);
            this.panel8.TabIndex = 39;
            // 
            // CloseLabel
            // 
            this.CloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.CloseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Location = new System.Drawing.Point(0, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(64, 64);
            this.CloseLabel.TabIndex = 31;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // EntrySuspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t31;
            this.ClientSize = new System.Drawing.Size(1301, 481);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(suspect_idLabel);
            this.Controls.Add(this.suspect_idTextBox);
            this.Controls.Add(entry_idLabel);
            this.Controls.Add(this.entry_idMaskedTextBox);
            this.Controls.Add(this.entry_SuspectBindingNavigator);
            this.Name = "EntrySuspect";
            this.Text = "EntrySuspect";
            this.Load += new System.EventHandler(this.EntrySuspect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_SuspectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_SuspectBindingNavigator)).EndInit();
            this.entry_SuspectBindingNavigator.ResumeLayout(false);
            this.entry_SuspectBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource entry_SuspectBindingSource;
        private EntryDBDataSetTableAdapters.Entry_SuspectTableAdapter entry_SuspectTableAdapter;
        private EntryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entry_SuspectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton entry_SuspectBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox suspect_idTextBox;
        private System.Windows.Forms.MaskedTextBox entry_idMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FullNameRadioButton;
        private System.Windows.Forms.RadioButton NICRaadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label SearchVictimLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddNewUserLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CancelLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label CloseLabel;
    }
}