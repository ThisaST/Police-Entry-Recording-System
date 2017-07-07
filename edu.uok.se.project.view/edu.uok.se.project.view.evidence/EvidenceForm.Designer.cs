namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.evidence
{
    partial class EvidenceForm
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
            System.Windows.Forms.Label evidence_idLabel;
            System.Windows.Forms.Label equipmentsLabel;
            System.Windows.Forms.Label entry_idLabel;
            System.Windows.Forms.Label evidence_DescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidenceForm));
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
            this.evidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evidenceTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.EvidenceTableAdapter();
            this.tableAdapterManager = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager();
            this.evidenceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.evidenceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.evidence_idTextBox = new System.Windows.Forms.TextBox();
            this.equipmentsTextBox = new System.Windows.Forms.TextBox();
            this.entry_idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.evidence_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EntryIDDataDridView = new System.Windows.Forms.DataGridView();
            this.entryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryAddedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.EntryTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewUserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            evidence_idLabel = new System.Windows.Forms.Label();
            equipmentsLabel = new System.Windows.Forms.Label();
            entry_idLabel = new System.Windows.Forms.Label();
            evidence_DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingNavigator)).BeginInit();
            this.evidenceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryIDDataDridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // evidence_idLabel
            // 
            evidence_idLabel.AutoSize = true;
            evidence_idLabel.BackColor = System.Drawing.Color.Transparent;
            evidence_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            evidence_idLabel.ForeColor = System.Drawing.Color.White;
            evidence_idLabel.Location = new System.Drawing.Point(44, 102);
            evidence_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            evidence_idLabel.Name = "evidence_idLabel";
            evidence_idLabel.Size = new System.Drawing.Size(119, 25);
            evidence_idLabel.TabIndex = 1;
            evidence_idLabel.Text = "Evidence id:";
            evidence_idLabel.Click += new System.EventHandler(this.evidence_idLabel_Click);
            // 
            // equipmentsLabel
            // 
            equipmentsLabel.AutoSize = true;
            equipmentsLabel.BackColor = System.Drawing.Color.Transparent;
            equipmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentsLabel.ForeColor = System.Drawing.Color.White;
            equipmentsLabel.Location = new System.Drawing.Point(44, 146);
            equipmentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            equipmentsLabel.Name = "equipmentsLabel";
            equipmentsLabel.Size = new System.Drawing.Size(121, 25);
            equipmentsLabel.TabIndex = 3;
            equipmentsLabel.Text = "Equipments:";
            equipmentsLabel.Click += new System.EventHandler(this.equipmentsLabel_Click);
            // 
            // entry_idLabel
            // 
            entry_idLabel.AutoSize = true;
            entry_idLabel.BackColor = System.Drawing.Color.Transparent;
            entry_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_idLabel.ForeColor = System.Drawing.Color.White;
            entry_idLabel.Location = new System.Drawing.Point(776, 62);
            entry_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            entry_idLabel.Name = "entry_idLabel";
            entry_idLabel.Size = new System.Drawing.Size(83, 25);
            entry_idLabel.TabIndex = 5;
            entry_idLabel.Text = "Entry id:";
            entry_idLabel.Click += new System.EventHandler(this.entry_idLabel_Click);
            // 
            // evidence_DescriptionLabel
            // 
            evidence_DescriptionLabel.AutoSize = true;
            evidence_DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            evidence_DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            evidence_DescriptionLabel.ForeColor = System.Drawing.Color.White;
            evidence_DescriptionLabel.Location = new System.Drawing.Point(44, 233);
            evidence_DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            evidence_DescriptionLabel.Name = "evidence_DescriptionLabel";
            evidence_DescriptionLabel.Size = new System.Drawing.Size(201, 25);
            evidence_DescriptionLabel.TabIndex = 7;
            evidence_DescriptionLabel.Text = "Evidence Description:";
            evidence_DescriptionLabel.Click += new System.EventHandler(this.evidence_DescriptionLabel_Click);
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evidenceBindingSource
            // 
            this.evidenceBindingSource.DataMember = "Evidence";
            this.evidenceBindingSource.DataSource = this.entryDBDataSet;
            // 
            // evidenceTableAdapter
            // 
            this.evidenceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Court_CaseTableAdapter = null;
            this.tableAdapterManager.Entry_DescriptionTableAdapter = null;
            this.tableAdapterManager.Entry_SuspectTableAdapter = null;
            this.tableAdapterManager.EntryTableAdapter = null;
            this.tableAdapterManager.EvidenceTableAdapter = this.evidenceTableAdapter;
            this.tableAdapterManager.SuspectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_ImageTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VictimTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // evidenceBindingNavigator
            // 
            this.evidenceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.evidenceBindingNavigator.BindingSource = this.evidenceBindingSource;
            this.evidenceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.evidenceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.evidenceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.evidenceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.evidenceBindingNavigatorSaveItem});
            this.evidenceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.evidenceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.evidenceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.evidenceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.evidenceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.evidenceBindingNavigator.Name = "evidenceBindingNavigator";
            this.evidenceBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.evidenceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.evidenceBindingNavigator.Size = new System.Drawing.Size(1344, 27);
            this.evidenceBindingNavigator.TabIndex = 0;
            this.evidenceBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 27);
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
            // evidenceBindingNavigatorSaveItem
            // 
            this.evidenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.evidenceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("evidenceBindingNavigatorSaveItem.Image")));
            this.evidenceBindingNavigatorSaveItem.Name = "evidenceBindingNavigatorSaveItem";
            this.evidenceBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.evidenceBindingNavigatorSaveItem.Text = "Save Data";
            this.evidenceBindingNavigatorSaveItem.Click += new System.EventHandler(this.evidenceBindingNavigatorSaveItem_Click);
            // 
            // evidence_idTextBox
            // 
            this.evidence_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidenceBindingSource, "Evidence_id", true));
            this.evidence_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidence_idTextBox.Location = new System.Drawing.Point(271, 97);
            this.evidence_idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evidence_idTextBox.Name = "evidence_idTextBox";
            this.evidence_idTextBox.Size = new System.Drawing.Size(148, 30);
            this.evidence_idTextBox.TabIndex = 0;
            this.evidence_idTextBox.TextChanged += new System.EventHandler(this.evidence_idTextBox_TextChanged);
            // 
            // equipmentsTextBox
            // 
            this.equipmentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidenceBindingSource, "Equipments", true));
            this.equipmentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentsTextBox.Location = new System.Drawing.Point(271, 141);
            this.equipmentsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.equipmentsTextBox.Name = "equipmentsTextBox";
            this.equipmentsTextBox.Size = new System.Drawing.Size(148, 30);
            this.equipmentsTextBox.TabIndex = 1;
            this.equipmentsTextBox.TextChanged += new System.EventHandler(this.equipmentsTextBox_TextChanged);
            // 
            // entry_idMaskedTextBox
            // 
            this.entry_idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidenceBindingSource, "Entry_id", true));
            this.entry_idMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_idMaskedTextBox.Location = new System.Drawing.Point(947, 57);
            this.entry_idMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entry_idMaskedTextBox.Name = "entry_idMaskedTextBox";
            this.entry_idMaskedTextBox.Size = new System.Drawing.Size(204, 30);
            this.entry_idMaskedTextBox.TabIndex = 3;
            this.entry_idMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.entry_idMaskedTextBox_MaskInputRejected);
            // 
            // evidence_DescriptionTextBox
            // 
            this.evidence_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evidenceBindingSource, "Evidence_Description", true));
            this.evidence_DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidence_DescriptionTextBox.Location = new System.Drawing.Point(271, 228);
            this.evidence_DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evidence_DescriptionTextBox.Name = "evidence_DescriptionTextBox";
            this.evidence_DescriptionTextBox.Size = new System.Drawing.Size(148, 30);
            this.evidence_DescriptionTextBox.TabIndex = 2;
            this.evidence_DescriptionTextBox.TextChanged += new System.EventHandler(this.evidence_DescriptionTextBox_TextChanged);
            // 
            // EntryIDDataDridView
            // 
            this.EntryIDDataDridView.AutoGenerateColumns = false;
            this.EntryIDDataDridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntryIDDataDridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryIDDataGridViewTextBoxColumn,
            this.entryTypeDataGridViewTextBoxColumn,
            this.entryAddedDateDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.victimidDataGridViewTextBoxColumn});
            this.EntryIDDataDridView.DataSource = this.entryBindingSource;
            this.EntryIDDataDridView.Location = new System.Drawing.Point(639, 157);
            this.EntryIDDataDridView.Name = "EntryIDDataDridView";
            this.EntryIDDataDridView.RowTemplate.Height = 24;
            this.EntryIDDataDridView.Size = new System.Drawing.Size(654, 150);
            this.EntryIDDataDridView.TabIndex = 9;
            this.EntryIDDataDridView.SelectionChanged += new System.EventHandler(this.EntryIDDataDridView_SelectionChanged);
            // 
            // entryIDDataGridViewTextBoxColumn
            // 
            this.entryIDDataGridViewTextBoxColumn.DataPropertyName = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.HeaderText = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.Name = "entryIDDataGridViewTextBoxColumn";
            // 
            // entryTypeDataGridViewTextBoxColumn
            // 
            this.entryTypeDataGridViewTextBoxColumn.DataPropertyName = "Entry_Type";
            this.entryTypeDataGridViewTextBoxColumn.HeaderText = "Entry_Type";
            this.entryTypeDataGridViewTextBoxColumn.Name = "entryTypeDataGridViewTextBoxColumn";
            // 
            // entryAddedDateDataGridViewTextBoxColumn
            // 
            this.entryAddedDateDataGridViewTextBoxColumn.DataPropertyName = "Entry_Added_Date";
            this.entryAddedDateDataGridViewTextBoxColumn.HeaderText = "Entry_Added_Date";
            this.entryAddedDateDataGridViewTextBoxColumn.Name = "entryAddedDateDataGridViewTextBoxColumn";
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "User_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // victimidDataGridViewTextBoxColumn
            // 
            this.victimidDataGridViewTextBoxColumn.DataPropertyName = "Victim_id";
            this.victimidDataGridViewTextBoxColumn.HeaderText = "Victim_id";
            this.victimidDataGridViewTextBoxColumn.Name = "victimidDataGridViewTextBoxColumn";
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.entryDBDataSet;
            // 
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764311_add_user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.AddNewUserLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(456, 345);
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
            this.panel6.Location = new System.Drawing.Point(584, 345);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 64);
            this.panel6.TabIndex = 33;
            // 
            // SaveLabel
            // 
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SaveLabel.Location = new System.Drawing.Point(0, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(64, 64);
            this.SaveLabel.TabIndex = 33;
            this.SaveLabel.Click += new System.EventHandler(this.evidenceBindingNavigatorSaveItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764647_cancel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.CancelLabel);
            this.panel3.Location = new System.Drawing.Point(716, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 64);
            this.panel3.TabIndex = 37;
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
            this.panel8.Location = new System.Drawing.Point(1246, 345);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(64, 64);
            this.panel8.TabIndex = 38;
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
            // EvidenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t31;
            this.ClientSize = new System.Drawing.Size(1344, 434);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EntryIDDataDridView);
            this.Controls.Add(evidence_idLabel);
            this.Controls.Add(this.evidence_idTextBox);
            this.Controls.Add(equipmentsLabel);
            this.Controls.Add(this.equipmentsTextBox);
            this.Controls.Add(entry_idLabel);
            this.Controls.Add(this.entry_idMaskedTextBox);
            this.Controls.Add(evidence_DescriptionLabel);
            this.Controls.Add(this.evidence_DescriptionTextBox);
            this.Controls.Add(this.evidenceBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EvidenceForm";
            this.Text = "EvidenceForm";
            this.Load += new System.EventHandler(this.EvidenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingNavigator)).EndInit();
            this.evidenceBindingNavigator.ResumeLayout(false);
            this.evidenceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryIDDataDridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource evidenceBindingSource;
        private EntryDBDataSetTableAdapters.EvidenceTableAdapter evidenceTableAdapter;
        private EntryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator evidenceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton evidenceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox evidence_idTextBox;
        private System.Windows.Forms.TextBox equipmentsTextBox;
        private System.Windows.Forms.MaskedTextBox entry_idMaskedTextBox;
        private System.Windows.Forms.TextBox evidence_DescriptionTextBox;
        private System.Windows.Forms.DataGridView EntryIDDataDridView;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private EntryDBDataSetTableAdapters.EntryTableAdapter entryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryAddedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimidDataGridViewTextBoxColumn;
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