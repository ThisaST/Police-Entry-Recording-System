namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.courtcase
{
    partial class CourtCaseDetails
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
            System.Windows.Forms.Label case_idLabel;
            System.Windows.Forms.Label last_Court_DateLabel;
            System.Windows.Forms.Label next_Court_DateLabel;
            System.Windows.Forms.Label entry_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourtCaseDetails));
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
            this.court_CaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.court_CaseTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.Court_CaseTableAdapter();
            this.tableAdapterManager = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager();
            this.entryTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.EntryTableAdapter();
            this.court_CaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.court_CaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.case_idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.last_Court_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.next_Court_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entry_IDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.court_CaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryAddedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewUserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            case_idLabel = new System.Windows.Forms.Label();
            last_Court_DateLabel = new System.Windows.Forms.Label();
            next_Court_DateLabel = new System.Windows.Forms.Label();
            entry_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.court_CaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.court_CaseBindingNavigator)).BeginInit();
            this.court_CaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.court_CaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // case_idLabel
            // 
            case_idLabel.AutoSize = true;
            case_idLabel.BackColor = System.Drawing.Color.Transparent;
            case_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            case_idLabel.ForeColor = System.Drawing.Color.White;
            case_idLabel.Location = new System.Drawing.Point(39, 117);
            case_idLabel.Name = "case_idLabel";
            case_idLabel.Size = new System.Drawing.Size(93, 25);
            case_idLabel.TabIndex = 1;
            case_idLabel.Text = "Case id:";
            // 
            // last_Court_DateLabel
            // 
            last_Court_DateLabel.AutoSize = true;
            last_Court_DateLabel.BackColor = System.Drawing.Color.Transparent;
            last_Court_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_Court_DateLabel.ForeColor = System.Drawing.Color.White;
            last_Court_DateLabel.Location = new System.Drawing.Point(39, 166);
            last_Court_DateLabel.Name = "last_Court_DateLabel";
            last_Court_DateLabel.Size = new System.Drawing.Size(170, 25);
            last_Court_DateLabel.TabIndex = 3;
            last_Court_DateLabel.Text = "Last Court Date:";
            // 
            // next_Court_DateLabel
            // 
            next_Court_DateLabel.AutoSize = true;
            next_Court_DateLabel.BackColor = System.Drawing.Color.Transparent;
            next_Court_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            next_Court_DateLabel.ForeColor = System.Drawing.Color.White;
            next_Court_DateLabel.Location = new System.Drawing.Point(39, 231);
            next_Court_DateLabel.Name = "next_Court_DateLabel";
            next_Court_DateLabel.Size = new System.Drawing.Size(173, 25);
            next_Court_DateLabel.TabIndex = 5;
            next_Court_DateLabel.Text = "Next Court Date:";
            // 
            // entry_IDLabel
            // 
            entry_IDLabel.AutoSize = true;
            entry_IDLabel.BackColor = System.Drawing.Color.Transparent;
            entry_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_IDLabel.ForeColor = System.Drawing.Color.White;
            entry_IDLabel.Location = new System.Drawing.Point(39, 308);
            entry_IDLabel.Name = "entry_IDLabel";
            entry_IDLabel.Size = new System.Drawing.Size(96, 25);
            entry_IDLabel.TabIndex = 7;
            entry_IDLabel.Text = "Entry ID:";
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // court_CaseBindingSource
            // 
            this.court_CaseBindingSource.DataMember = "Court_Case";
            this.court_CaseBindingSource.DataSource = this.entryDBDataSet;
            // 
            // court_CaseTableAdapter
            // 
            this.court_CaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Court_CaseTableAdapter = this.court_CaseTableAdapter;
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
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // court_CaseBindingNavigator
            // 
            this.court_CaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.court_CaseBindingNavigator.BindingSource = this.court_CaseBindingSource;
            this.court_CaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.court_CaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.court_CaseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.court_CaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.court_CaseBindingNavigatorSaveItem});
            this.court_CaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.court_CaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.court_CaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.court_CaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.court_CaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.court_CaseBindingNavigator.Name = "court_CaseBindingNavigator";
            this.court_CaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.court_CaseBindingNavigator.Size = new System.Drawing.Size(1368, 27);
            this.court_CaseBindingNavigator.TabIndex = 0;
            this.court_CaseBindingNavigator.Text = "bindingNavigator1";
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
            // court_CaseBindingNavigatorSaveItem
            // 
            this.court_CaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.court_CaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("court_CaseBindingNavigatorSaveItem.Image")));
            this.court_CaseBindingNavigatorSaveItem.Name = "court_CaseBindingNavigatorSaveItem";
            this.court_CaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.court_CaseBindingNavigatorSaveItem.Text = "Save Data";
            this.court_CaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.court_CaseBindingNavigatorSaveItem_Click);
            // 
            // case_idMaskedTextBox
            // 
            this.case_idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.court_CaseBindingSource, "Case_id", true));
            this.case_idMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.case_idMaskedTextBox.Location = new System.Drawing.Point(157, 114);
            this.case_idMaskedTextBox.Name = "case_idMaskedTextBox";
            this.case_idMaskedTextBox.Size = new System.Drawing.Size(200, 30);
            this.case_idMaskedTextBox.TabIndex = 0;
            // 
            // last_Court_DateDateTimePicker
            // 
            this.last_Court_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.court_CaseBindingSource, "Last_Court_Date", true));
            this.last_Court_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_Court_DateDateTimePicker.Location = new System.Drawing.Point(246, 161);
            this.last_Court_DateDateTimePicker.Name = "last_Court_DateDateTimePicker";
            this.last_Court_DateDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.last_Court_DateDateTimePicker.TabIndex = 1;
            // 
            // next_Court_DateDateTimePicker
            // 
            this.next_Court_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.court_CaseBindingSource, "Next_Court_Date", true));
            this.next_Court_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_Court_DateDateTimePicker.Location = new System.Drawing.Point(246, 231);
            this.next_Court_DateDateTimePicker.Name = "next_Court_DateDateTimePicker";
            this.next_Court_DateDateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.next_Court_DateDateTimePicker.TabIndex = 2;
            // 
            // entry_IDMaskedTextBox
            // 
            this.entry_IDMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.court_CaseBindingSource, "Entry_ID", true));
            this.entry_IDMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_IDMaskedTextBox.Location = new System.Drawing.Point(157, 303);
            this.entry_IDMaskedTextBox.Name = "entry_IDMaskedTextBox";
            this.entry_IDMaskedTextBox.Size = new System.Drawing.Size(200, 30);
            this.entry_IDMaskedTextBox.TabIndex = 3;
            // 
            // court_CaseDataGridView
            // 
            this.court_CaseDataGridView.AutoGenerateColumns = false;
            this.court_CaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.court_CaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.court_CaseDataGridView.DataSource = this.court_CaseBindingSource;
            this.court_CaseDataGridView.Location = new System.Drawing.Point(624, 81);
            this.court_CaseDataGridView.Name = "court_CaseDataGridView";
            this.court_CaseDataGridView.RowTemplate.Height = 24;
            this.court_CaseDataGridView.Size = new System.Drawing.Size(649, 151);
            this.court_CaseDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Case_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Case_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Last_Court_Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last_Court_Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Next_Court_Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Next_Court_Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Entry_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Entry_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryIDDataGridViewTextBoxColumn,
            this.entryTypeDataGridViewTextBoxColumn,
            this.entryAddedDateDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.victimidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(624, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // entryIDDataGridViewTextBoxColumn
            // 
            this.entryIDDataGridViewTextBoxColumn.DataPropertyName = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.HeaderText = "Entry_ID";
            this.entryIDDataGridViewTextBoxColumn.Name = "entryIDDataGridViewTextBoxColumn";
            this.entryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryTypeDataGridViewTextBoxColumn
            // 
            this.entryTypeDataGridViewTextBoxColumn.DataPropertyName = "Entry_Type";
            this.entryTypeDataGridViewTextBoxColumn.HeaderText = "Entry_Type";
            this.entryTypeDataGridViewTextBoxColumn.Name = "entryTypeDataGridViewTextBoxColumn";
            this.entryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryAddedDateDataGridViewTextBoxColumn
            // 
            this.entryAddedDateDataGridViewTextBoxColumn.DataPropertyName = "Entry_Added_Date";
            this.entryAddedDateDataGridViewTextBoxColumn.HeaderText = "Entry_Added_Date";
            this.entryAddedDateDataGridViewTextBoxColumn.Name = "entryAddedDateDataGridViewTextBoxColumn";
            this.entryAddedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "User_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // victimidDataGridViewTextBoxColumn
            // 
            this.victimidDataGridViewTextBoxColumn.DataPropertyName = "Victim_id";
            this.victimidDataGridViewTextBoxColumn.HeaderText = "Victim_id";
            this.victimidDataGridViewTextBoxColumn.Name = "victimidDataGridViewTextBoxColumn";
            this.victimidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.entryDBDataSet;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel8.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1469032685_close;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.CloseLabel);
            this.panel8.Location = new System.Drawing.Point(1292, 529);
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
            this.panel3.Location = new System.Drawing.Point(462, 505);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764270_save;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.SaveLabel);
            this.panel6.Location = new System.Drawing.Point(326, 505);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 64);
            this.panel6.TabIndex = 39;
            // 
            // SaveLabel
            // 
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SaveLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveLabel.Location = new System.Drawing.Point(0, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(64, 64);
            this.SaveLabel.TabIndex = 33;
            this.SaveLabel.Click += new System.EventHandler(this.court_CaseBindingNavigatorSaveItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764311_add_user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.AddNewUserLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(199, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 64);
            this.panel2.TabIndex = 40;
            // 
            // AddNewUserLabel
            // 
            this.AddNewUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddNewUserLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddNewUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // CourtCaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t31;
            this.ClientSize = new System.Drawing.Size(1368, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.court_CaseDataGridView);
            this.Controls.Add(case_idLabel);
            this.Controls.Add(this.case_idMaskedTextBox);
            this.Controls.Add(last_Court_DateLabel);
            this.Controls.Add(this.last_Court_DateDateTimePicker);
            this.Controls.Add(next_Court_DateLabel);
            this.Controls.Add(this.next_Court_DateDateTimePicker);
            this.Controls.Add(entry_IDLabel);
            this.Controls.Add(this.entry_IDMaskedTextBox);
            this.Controls.Add(this.court_CaseBindingNavigator);
            this.Name = "CourtCaseDetails";
            this.Text = "CourtCaseDetails";
            this.Load += new System.EventHandler(this.CourtCaseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.court_CaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.court_CaseBindingNavigator)).EndInit();
            this.court_CaseBindingNavigator.ResumeLayout(false);
            this.court_CaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.court_CaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource court_CaseBindingSource;
        private EntryDBDataSetTableAdapters.Court_CaseTableAdapter court_CaseTableAdapter;
        private EntryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator court_CaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton court_CaseBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox case_idMaskedTextBox;
        private System.Windows.Forms.DateTimePicker last_Court_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker next_Court_DateDateTimePicker;
        private System.Windows.Forms.MaskedTextBox entry_IDMaskedTextBox;
        private EntryDBDataSetTableAdapters.EntryTableAdapter entryTableAdapter;
        private System.Windows.Forms.DataGridView court_CaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryAddedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimidDataGridViewTextBoxColumn;
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