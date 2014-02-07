namespace StudentMaintenance
{
    partial class frmStudentMaintenance
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
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleInitialLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentMaintenance));
            this.expStudentsAndMajorsDataSet = new StudentMaintenance.ExpStudentsAndMajorsDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new StudentMaintenance.ExpStudentsAndMajorsDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new StudentMaintenance.ExpStudentsAndMajorsDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.findByIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findByIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.LastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FindByLastNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FindAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.studentMajorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMajorTableAdapter = new StudentMaintenance.ExpStudentsAndMajorsDataSetTableAdapters.StudentMajorTableAdapter();
            this.studentMajorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleInitialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expStudentsAndMajorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            this.findByIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentMajorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMajorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(12, 275);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(61, 13);
            studentIDLabel.TabIndex = 1;
            studentIDLabel.Text = "Student ID:";
            studentIDLabel.Click += new System.EventHandler(this.studentIDLabel_Click);
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 301);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 327);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // middleInitialLabel
            // 
            middleInitialLabel.AutoSize = true;
            middleInitialLabel.Location = new System.Drawing.Point(12, 353);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new System.Drawing.Size(68, 13);
            middleInitialLabel.TabIndex = 7;
            middleInitialLabel.Text = "Middle Initial:";
            middleInitialLabel.Click += new System.EventHandler(this.middleInitialLabel_Click);
            // 
            // expStudentsAndMajorsDataSet
            // 
            this.expStudentsAndMajorsDataSet.DataSetName = "ExpStudentsAndMajorsDataSet";
            this.expStudentsAndMajorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.expStudentsAndMajorsDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MajorTableAdapter = null;
            this.tableAdapterManager.StudentMajorTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentMaintenance.ExpStudentsAndMajorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            this.studentBindingNavigator.RefreshItems += new System.EventHandler(this.studentBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Visible = false;
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(86, 272);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 2;
            this.studentIDTextBox.TextChanged += new System.EventHandler(this.studentIDTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(86, 298);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(86, 324);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "MiddleInitial", true));
            this.middleInitialTextBox.Location = new System.Drawing.Point(86, 350);
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleInitialTextBox.TabIndex = 8;
            this.middleInitialTextBox.TextChanged += new System.EventHandler(this.middleInitialTextBox_TextChanged);
            // 
            // findByIDToolStrip
            // 
            this.findByIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentIDToolStripLabel,
            this.studentIDToolStripTextBox,
            this.findByIDToolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.LastNameToolStripLabel,
            this.LastNameToolStripTextBox,
            this.FindByLastNameToolStripButton,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.FindAllToolStripButton});
            this.findByIDToolStrip.Location = new System.Drawing.Point(0, 25);
            this.findByIDToolStrip.Name = "findByIDToolStrip";
            this.findByIDToolStrip.Size = new System.Drawing.Size(641, 25);
            this.findByIDToolStrip.TabIndex = 9;
            this.findByIDToolStrip.Text = "findByIDToolStrip";
            // 
            // studentIDToolStripLabel
            // 
            this.studentIDToolStripLabel.Name = "studentIDToolStripLabel";
            this.studentIDToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.studentIDToolStripLabel.Text = "StudentID:";
            // 
            // studentIDToolStripTextBox
            // 
            this.studentIDToolStripTextBox.Name = "studentIDToolStripTextBox";
            this.studentIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // findByIDToolStripButton
            // 
            this.findByIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findByIDToolStripButton.Name = "findByIDToolStripButton";
            this.findByIDToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.findByIDToolStripButton.Text = "FindByID";
            this.findByIDToolStripButton.Click += new System.EventHandler(this.findByIDToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // LastNameToolStripLabel
            // 
            this.LastNameToolStripLabel.Name = "LastNameToolStripLabel";
            this.LastNameToolStripLabel.Size = new System.Drawing.Size(66, 22);
            this.LastNameToolStripLabel.Text = "Last Name:";
            // 
            // LastNameToolStripTextBox
            // 
            this.LastNameToolStripTextBox.Name = "LastNameToolStripTextBox";
            this.LastNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // FindByLastNameToolStripButton
            // 
            this.FindByLastNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FindByLastNameToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FindByLastNameToolStripButton.Image")));
            this.FindByLastNameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindByLastNameToolStripButton.Name = "FindByLastNameToolStripButton";
            this.FindByLastNameToolStripButton.Size = new System.Drawing.Size(79, 22);
            this.FindByLastNameToolStripButton.Text = "FindByName";
            this.FindByLastNameToolStripButton.Click += new System.EventHandler(this.FindByLastNameToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // FindAllToolStripButton
            // 
            this.FindAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FindAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FindAllToolStripButton.Image")));
            this.FindAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindAllToolStripButton.Name = "FindAllToolStripButton";
            this.FindAllToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.FindAllToolStripButton.Text = "Find All";
            this.FindAllToolStripButton.Click += new System.EventHandler(this.FindAllToolStripButton_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(213, 272);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(137, 23);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add a student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Location = new System.Drawing.Point(213, 296);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(137, 23);
            this.btnModifyStudent.TabIndex = 11;
            this.btnModifyStudent.Text = "Modify this Student";
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(213, 321);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Delete this Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(379, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // studentMajorBindingSource
            // 
            this.studentMajorBindingSource.DataMember = "FK__StudentMa__Stude__7AB3A8DA";
            this.studentMajorBindingSource.DataSource = this.studentBindingSource;
            // 
            // studentMajorTableAdapter
            // 
            this.studentMajorTableAdapter.ClearBeforeFill = true;
            // 
            // studentMajorDataGridView
            // 
            this.studentMajorDataGridView.AllowUserToAddRows = false;
            this.studentMajorDataGridView.AllowUserToDeleteRows = false;
            this.studentMajorDataGridView.AllowUserToOrderColumns = true;
            this.studentMajorDataGridView.AutoGenerateColumns = false;
            this.studentMajorDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.studentMajorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentMajorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.studentMajorDataGridView.DataSource = this.studentMajorBindingSource;
            this.studentMajorDataGridView.Location = new System.Drawing.Point(69, 409);
            this.studentMajorDataGridView.Name = "studentMajorDataGridView";
            this.studentMajorDataGridView.ReadOnly = true;
            this.studentMajorDataGridView.Size = new System.Drawing.Size(300, 142);
            this.studentMajorDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MajorCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Major";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // frmStudentMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 641);
            this.Controls.Add(this.studentMajorDataGridView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnModifyStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.findByIDToolStrip);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(middleInitialLabel);
            this.Controls.Add(this.middleInitialTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "frmStudentMaintenance";
            this.Text = "Student Maintenance";
            this.Load += new System.EventHandler(this.frmStudentMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expStudentsAndMajorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            this.findByIDToolStrip.ResumeLayout(false);
            this.findByIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentMajorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMajorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExpStudentsAndMajorsDataSet expStudentsAndMajorsDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ExpStudentsAndMajorsDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private ExpStudentsAndMajorsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleInitialTextBox;
        private System.Windows.Forms.ToolStrip findByIDToolStrip;
        private System.Windows.Forms.ToolStripLabel studentIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findByIDToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel LastNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox LastNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton FindByLastNameToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton FindAllToolStripButton;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnModifyStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource studentMajorBindingSource;
        private ExpStudentsAndMajorsDataSetTableAdapters.StudentMajorTableAdapter studentMajorTableAdapter;
        private System.Windows.Forms.DataGridView studentMajorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

