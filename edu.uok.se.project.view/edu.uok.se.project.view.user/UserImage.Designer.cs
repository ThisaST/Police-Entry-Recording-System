namespace Police_Entry_Recording_System.edu.uok.se.project.view.edu.uok.se.project.view.user
{
    partial class UserImage
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
            System.Windows.Forms.Label image_IDLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label user_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserImage));
            this.entryDBDataSet = new Police_Entry_Recording_System.EntryDBDataSet();
            this.user_ImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ImageTableAdapter = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.User_ImageTableAdapter();
            this.tableAdapterManager = new Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager();
            this.user_ImageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.user_ImageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.image_IDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.user_idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TakePictureButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.UserImageChooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewUserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            image_IDLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ImageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ImageBindingNavigator)).BeginInit();
            this.user_ImageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // image_IDLabel
            // 
            image_IDLabel.AutoSize = true;
            image_IDLabel.BackColor = System.Drawing.Color.Transparent;
            image_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            image_IDLabel.ForeColor = System.Drawing.Color.White;
            image_IDLabel.Location = new System.Drawing.Point(48, 68);
            image_IDLabel.Name = "image_IDLabel";
            image_IDLabel.Size = new System.Drawing.Size(90, 20);
            image_IDLabel.TabIndex = 1;
            image_IDLabel.Text = "Image ID:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.BackColor = System.Drawing.Color.Transparent;
            imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageLabel.ForeColor = System.Drawing.Color.White;
            imageLabel.Location = new System.Drawing.Point(483, 48);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(65, 20);
            imageLabel.TabIndex = 3;
            imageLabel.Text = "Image:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.White;
            descriptionLabel.Location = new System.Drawing.Point(48, 173);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(112, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.BackColor = System.Drawing.Color.Transparent;
            user_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_idLabel.ForeColor = System.Drawing.Color.White;
            user_idLabel.Location = new System.Drawing.Point(48, 275);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(76, 20);
            user_idLabel.TabIndex = 7;
            user_idLabel.Text = "User id:";
            // 
            // entryDBDataSet
            // 
            this.entryDBDataSet.DataSetName = "EntryDBDataSet";
            this.entryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_ImageBindingSource
            // 
            this.user_ImageBindingSource.DataMember = "User_Image";
            this.user_ImageBindingSource.DataSource = this.entryDBDataSet;
            // 
            // user_ImageTableAdapter
            // 
            this.user_ImageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Court_CaseTableAdapter = null;
            this.tableAdapterManager.Entry_DescriptionTableAdapter = null;
            this.tableAdapterManager.Entry_SuspectTableAdapter = null;
            this.tableAdapterManager.EntryTableAdapter = null;
            this.tableAdapterManager.EvidenceTableAdapter = null;
            this.tableAdapterManager.SuspectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Police_Entry_Recording_System.EntryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_ImageTableAdapter = this.user_ImageTableAdapter;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VictimTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // user_ImageBindingNavigator
            // 
            this.user_ImageBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user_ImageBindingNavigator.BindingSource = this.user_ImageBindingSource;
            this.user_ImageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user_ImageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_ImageBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.user_ImageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.user_ImageBindingNavigatorSaveItem});
            this.user_ImageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user_ImageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.user_ImageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.user_ImageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.user_ImageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.user_ImageBindingNavigator.Name = "user_ImageBindingNavigator";
            this.user_ImageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user_ImageBindingNavigator.Size = new System.Drawing.Size(1173, 27);
            this.user_ImageBindingNavigator.TabIndex = 0;
            this.user_ImageBindingNavigator.Text = "bindingNavigator1";
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
            // user_ImageBindingNavigatorSaveItem
            // 
            this.user_ImageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_ImageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_ImageBindingNavigatorSaveItem.Image")));
            this.user_ImageBindingNavigatorSaveItem.Name = "user_ImageBindingNavigatorSaveItem";
            this.user_ImageBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.user_ImageBindingNavigatorSaveItem.Text = "Save Data";
            this.user_ImageBindingNavigatorSaveItem.Click += new System.EventHandler(this.user_ImageBindingNavigatorSaveItem_Click);
            // 
            // image_IDTextBox
            // 
            this.image_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_ImageBindingSource, "Image_ID", true));
            this.image_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_IDTextBox.Location = new System.Drawing.Point(170, 65);
            this.image_IDTextBox.Name = "image_IDTextBox";
            this.image_IDTextBox.Size = new System.Drawing.Size(100, 27);
            this.image_IDTextBox.TabIndex = 2;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_ImageBindingSource, "Description", true));
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(170, 170);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(264, 73);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // user_idMaskedTextBox
            // 
            this.user_idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_ImageBindingSource, "User_id", true));
            this.user_idMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_idMaskedTextBox.Location = new System.Drawing.Point(170, 268);
            this.user_idMaskedTextBox.Mask = "user-0000";
            this.user_idMaskedTextBox.Name = "user_idMaskedTextBox";
            this.user_idMaskedTextBox.Size = new System.Drawing.Size(123, 27);
            this.user_idMaskedTextBox.TabIndex = 8;
            // 
            // TakePictureButton
            // 
            this.TakePictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakePictureButton.Location = new System.Drawing.Point(487, 564);
            this.TakePictureButton.Name = "TakePictureButton";
            this.TakePictureButton.Size = new System.Drawing.Size(118, 37);
            this.TakePictureButton.TabIndex = 9;
            this.TakePictureButton.Text = "Take Picture";
            this.TakePictureButton.UseVisualStyleBackColor = true;
            this.TakePictureButton.Click += new System.EventHandler(this.TakePictureButton_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.Location = new System.Drawing.Point(680, 564);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(96, 37);
            this.UploadButton.TabIndex = 10;
            this.UploadButton.Text = "Choose";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.Silver;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.user_ImageBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(487, 102);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(441, 423);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            // 
            // UserImageChooseFileDialog
            // 
            this.UserImageChooseFileDialog.Filter = "Image Files | *.bmp; *.jpg; *.png; *.gif;";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764311_add_user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.AddNewUserLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1011, 102);
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
            this.panel6.Location = new System.Drawing.Point(1011, 231);
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
            this.SaveLabel.Click += new System.EventHandler(this.user_ImageBindingNavigatorSaveItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources._1468764647_cancel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.CancelLabel);
            this.panel3.Location = new System.Drawing.Point(1011, 353);
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
            this.panel8.Location = new System.Drawing.Point(1011, 557);
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
            // UserImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Police_Entry_Recording_System.Properties.Resources.security_codes_t3;
            this.ClientSize = new System.Drawing.Size(1173, 633);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.TakePictureButton);
            this.Controls.Add(image_IDLabel);
            this.Controls.Add(this.image_IDTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idMaskedTextBox);
            this.Controls.Add(this.user_ImageBindingNavigator);
            this.Name = "UserImage";
            this.Text = "UserImage";
            this.Load += new System.EventHandler(this.UserImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ImageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ImageBindingNavigator)).EndInit();
            this.user_ImageBindingNavigator.ResumeLayout(false);
            this.user_ImageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntryDBDataSet entryDBDataSet;
        private System.Windows.Forms.BindingSource user_ImageBindingSource;
        private EntryDBDataSetTableAdapters.User_ImageTableAdapter user_ImageTableAdapter;
        private EntryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_ImageBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton user_ImageBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox image_IDTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.MaskedTextBox user_idMaskedTextBox;
        private System.Windows.Forms.Button TakePictureButton;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.OpenFileDialog UserImageChooseFileDialog;
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