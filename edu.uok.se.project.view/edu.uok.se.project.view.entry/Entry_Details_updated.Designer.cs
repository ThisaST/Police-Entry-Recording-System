namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.entry
{
    partial class Entry_Details_updated
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
            System.Windows.Forms.Label entry_IDLabel;
            System.Windows.Forms.Label entry_TypeLabel;
            System.Windows.Forms.Label entry_Added_DateLabel;
            System.Windows.Forms.Label divisionLabel;
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label victim_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry_Details_updated));
            this.entryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
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
            this.entryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.entry_IDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.entry_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.entry_Added_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.divisionComboBox = new System.Windows.Forms.ComboBox();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.victim_idTextBox = new System.Windows.Forms.TextBox();
            this.entryTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.EntryTableAdapter();
            this.tableAdapterManager = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullNameRadioButton = new System.Windows.Forms.RadioButton();
            this.NICRaadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchVictimLabel = new System.Windows.Forms.Label();
            this.VictimDataGridView = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewUserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            entry_IDLabel = new System.Windows.Forms.Label();
            entry_TypeLabel = new System.Windows.Forms.Label();
            entry_Added_DateLabel = new System.Windows.Forms.Label();
            divisionLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            victim_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingNavigator)).BeginInit();
            this.entryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VictimDataGridView)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // entry_IDLabel
            // 
            entry_IDLabel.AutoSize = true;
            entry_IDLabel.BackColor = System.Drawing.Color.Transparent;
            entry_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            entry_IDLabel.Location = new System.Drawing.Point(51, 112);
            entry_IDLabel.Name = "entry_IDLabel";
            entry_IDLabel.Size = new System.Drawing.Size(84, 20);
            entry_IDLabel.TabIndex = 1;
            entry_IDLabel.Text = "Entry ID:";
            // 
            // entry_TypeLabel
            // 
            entry_TypeLabel.AutoSize = true;
            entry_TypeLabel.BackColor = System.Drawing.Color.Transparent;
            entry_TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_TypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            entry_TypeLabel.Location = new System.Drawing.Point(51, 167);
            entry_TypeLabel.Name = "entry_TypeLabel";
            entry_TypeLabel.Size = new System.Drawing.Size(105, 20);
            entry_TypeLabel.TabIndex = 3;
            entry_TypeLabel.Text = "Entry Type:";
            // 
            // entry_Added_DateLabel
            // 
            entry_Added_DateLabel.AutoSize = true;
            entry_Added_DateLabel.BackColor = System.Drawing.Color.Transparent;
            entry_Added_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_Added_DateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            entry_Added_DateLabel.Location = new System.Drawing.Point(47, 233);
            entry_Added_DateLabel.Name = "entry_Added_DateLabel";
            entry_Added_DateLabel.Size = new System.Drawing.Size(163, 20);
            entry_Added_DateLabel.TabIndex = 5;
            entry_Added_DateLabel.Text = "Entry Added Date:";
            // 
            // divisionLabel
            // 
            divisionLabel.AutoSize = true;
            divisionLabel.BackColor = System.Drawing.Color.Transparent;
            divisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            divisionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            divisionLabel.Location = new System.Drawing.Point(46, 294);
            divisionLabel.Name = "divisionLabel";
            divisionLabel.Size = new System.Drawing.Size(83, 20);
            divisionLabel.TabIndex = 7;
            divisionLabel.Text = "Division:";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.BackColor = System.Drawing.Color.Transparent;
            user_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            user_idLabel.Location = new System.Drawing.Point(47, 338);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(76, 20);
            user_idLabel.TabIndex = 9;
            user_idLabel.Text = "User id:";
            // 
            // victim_idLabel
            // 
            victim_idLabel.AutoSize = true;
            victim_idLabel.BackColor = System.Drawing.Color.Transparent;
            victim_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            victim_idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            victim_idLabel.Location = new System.Drawing.Point(46, 390);
            victim_idLabel.Name = "victim_idLabel";
            victim_idLabel.Size = new System.Drawing.Size(89, 20);
            victim_idLabel.TabIndex = 11;
            victim_idLabel.Text = "Victim id:";
            // 
            // entryBindingNavigator
            // 
            this.entryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.entryBindingNavigator.BindingSource = this.entryBindingSource;
            this.entryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.entryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.entryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.entryBindingNavigatorSaveItem});
            this.entryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entryBindingNavigator.Name = "entryBindingNavigator";
            this.entryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entryBindingNavigator.Size = new System.Drawing.Size(1403, 27);
            this.entryBindingNavigator.TabIndex = 0;
            this.entryBindingNavigator.Text = "bindingNavigator1";
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
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.entryDBDataSet;
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // entryBindingNavigatorSaveItem
            // 
            this.entryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entryBindingNavigatorSaveItem.Image")));
            this.entryBindingNavigatorSaveItem.Name = "entryBindingNavigatorSaveItem";
            this.entryBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.entryBindingNavigatorSaveItem.Text = "Save Data";
            this.entryBindingNavigatorSaveItem.Click += new System.EventHandler(this.entryBindingNavigatorSaveItem_Click);
            // 
            // entry_IDMaskedTextBox
            // 
            this.entry_IDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Entry_ID", true));
            this.entry_IDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_IDMaskedTextBox.Location = new System.Drawing.Point(181, 109);
            this.entry_IDMaskedTextBox.Name = "entry_IDMaskedTextBox";
            this.entry_IDMaskedTextBox.Size = new System.Drawing.Size(200, 27);
            this.entry_IDMaskedTextBox.TabIndex = 2;
            // 
            // entry_TypeComboBox
            // 
            this.entry_TypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Entry_Type", true));
            this.entry_TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entry_TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_TypeComboBox.FormattingEnabled = true;
            this.entry_TypeComboBox.Items.AddRange(new object[] {
            "Major Crimes ",
            "Minor Crimes ",
            "Child and Women ",
            "Environmental ",
            "Traffic "});
            this.entry_TypeComboBox.Location = new System.Drawing.Point(181, 164);
            this.entry_TypeComboBox.Name = "entry_TypeComboBox";
            this.entry_TypeComboBox.Size = new System.Drawing.Size(200, 28);
            this.entry_TypeComboBox.TabIndex = 4;
            // 
            // entry_Added_DateDateTimePicker
            // 
            this.entry_Added_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entryBindingSource, "Entry_Added_Date", true));
            this.entry_Added_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Added_DateDateTimePicker.Location = new System.Drawing.Point(246, 228);
            this.entry_Added_DateDateTimePicker.Name = "entry_Added_DateDateTimePicker";
            this.entry_Added_DateDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.entry_Added_DateDateTimePicker.TabIndex = 6;
            // 
            // divisionComboBox
            // 
            this.divisionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Division", true));
            this.divisionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.divisionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionComboBox.FormattingEnabled = true;
            this.divisionComboBox.Items.AddRange(new object[] {
            "Major Crimes Division",
            "Minor Crimes Division",
            "Child and Women Division",
            "Environmental Division",
            "Traffic Division"});
            this.divisionComboBox.Location = new System.Drawing.Point(181, 291);
            this.divisionComboBox.Name = "divisionComboBox";
            this.divisionComboBox.Size = new System.Drawing.Size(200, 28);
            this.divisionComboBox.TabIndex = 8;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "User_id", true));
            this.user_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_idTextBox.Location = new System.Drawing.Point(176, 338);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(200, 27);
            this.user_idTextBox.TabIndex = 10;
            // 
            // victim_idTextBox
            // 
            this.victim_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Victim_id", true));
            this.victim_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victim_idTextBox.Location = new System.Drawing.Point(176, 387);
            this.victim_idTextBox.Name = "victim_idTextBox";
            this.victim_idTextBox.Size = new System.Drawing.Size(200, 27);
            this.victim_idTextBox.TabIndex = 12;
            // 
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Court_CaseTableAdapter = null;
            this.tableAdapterManager.Entry_DescriptionTableAdapter = null;
            this.tableAdapterManager.Entry_SuspectTableAdapter = null;
            this.tableAdapterManager.EntryTableAdapter = this.entryTableAdapter;
            this.tableAdapterManager.EvidenceTableAdapter = null;
            this.tableAdapterManager.SuspectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_ImageTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VictimTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FullNameRadioButton);
            this.groupBox1.Controls.Add(this.NICRaadioButton);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(635, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search victims";
            // 
            // FullNameRadioButton
            // 
            this.FullNameRadioButton.AutoSize = true;
            this.FullNameRadioButton.Location = new System.Drawing.Point(25, 61);
            this.FullNameRadioButton.Name = "FullNameRadioButton";
            this.FullNameRadioButton.Size = new System.Drawing.Size(92, 21);
            this.FullNameRadioButton.TabIndex = 19;
            this.FullNameRadioButton.Text = "Full Name";
            this.FullNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // NICRaadioButton
            // 
            this.NICRaadioButton.AutoSize = true;
            this.NICRaadioButton.Checked = true;
            this.NICRaadioButton.Location = new System.Drawing.Point(25, 34);
            this.NICRaadioButton.Name = "NICRaadioButton";
            this.NICRaadioButton.Size = new System.Drawing.Size(51, 21);
            this.NICRaadioButton.TabIndex = 18;
            this.NICRaadioButton.TabStop = true;
            this.NICRaadioButton.Text = "NIC";
            this.NICRaadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(180, 42);
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
            this.panel4.Location = new System.Drawing.Point(553, 26);
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
            // VictimDataGridView
            // 
            this.VictimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VictimDataGridView.Location = new System.Drawing.Point(635, 268);
            this.VictimDataGridView.Name = "VictimDataGridView";
            this.VictimDataGridView.RowTemplate.Height = 24;
            this.VictimDataGridView.Size = new System.Drawing.Size(685, 166);
            this.VictimDataGridView.TabIndex = 20;
            this.VictimDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VictimDataGridView_CellContentClick);
            this.VictimDataGridView.SelectionChanged += new System.EventHandler(this.VictimDataGridView_SelectionChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1469032685_close;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.CloseLabel);
            this.panel8.Location = new System.Drawing.Point(1307, 471);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(64, 64);
            this.panel8.TabIndex = 37;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764647_cancel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.CancelLabel);
            this.panel3.Location = new System.Drawing.Point(574, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 64);
            this.panel3.TabIndex = 36;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764270_save;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.SaveLabel);
            this.panel6.Location = new System.Drawing.Point(463, 471);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 64);
            this.panel6.TabIndex = 32;
            // 
            // SaveLabel
            // 
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SaveLabel.Location = new System.Drawing.Point(0, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(64, 64);
            this.SaveLabel.TabIndex = 33;
            this.SaveLabel.Click += new System.EventHandler(this.entryBindingNavigatorSaveItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764311_add_user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.AddNewUserLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(345, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 64);
            this.panel2.TabIndex = 35;
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
            // Entry_Details_updated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t3;
            this.ClientSize = new System.Drawing.Size(1403, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.VictimDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(entry_IDLabel);
            this.Controls.Add(this.entry_IDMaskedTextBox);
            this.Controls.Add(entry_TypeLabel);
            this.Controls.Add(this.entry_TypeComboBox);
            this.Controls.Add(entry_Added_DateLabel);
            this.Controls.Add(this.entry_Added_DateDateTimePicker);
            this.Controls.Add(divisionLabel);
            this.Controls.Add(this.divisionComboBox);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(victim_idLabel);
            this.Controls.Add(this.victim_idTextBox);
            this.Controls.Add(this.entryBindingNavigator);
            this.Name = "Entry_Details_updated";
            this.Text = "Entry_Details_updated";
            this.Load += new System.EventHandler(this.Entry_Details_updated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingNavigator)).EndInit();
            this.entryBindingNavigator.ResumeLayout(false);
            this.entryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VictimDataGridView)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private EntryDBDataSetTableAdapters.EntryTableAdapter entryTableAdapter;
        private EntryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton entryBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox entry_IDMaskedTextBox;
        private System.Windows.Forms.ComboBox entry_TypeComboBox;
        private System.Windows.Forms.DateTimePicker entry_Added_DateDateTimePicker;
        private System.Windows.Forms.ComboBox divisionComboBox;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox victim_idTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FullNameRadioButton;
        private System.Windows.Forms.RadioButton NICRaadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label SearchVictimLabel;
        private System.Windows.Forms.DataGridView VictimDataGridView;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CancelLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddNewUserLabel;
        private System.Windows.Forms.Label label3;
    }
}