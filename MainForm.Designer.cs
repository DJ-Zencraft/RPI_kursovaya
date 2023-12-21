namespace RPI_kursovaya
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StorageManagemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStorageInListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addTruckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTruckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTruckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TrucksDGV = new System.Windows.Forms.DataGridView();
            this.fKTrucksStorageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBDDataSet = new RPI_kursovaya.StorageBDDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AdressStrCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fKShipmentsCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKCategoriesStorageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.fKCharacteristicsShipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ShipDGV = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.storageTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.StorageTableAdapter();
            this.trucksTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.TrucksTableAdapter();
            this.categoriesTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.CategoriesTableAdapter();
            this.shipmentsTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.ShipmentsTableAdapter();
            this.characteristicsTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.CharacteristicsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrucksDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTrucksStorageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKShipmentsCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCategoriesStorageBindingSource)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKCharacteristicsShipmentsBindingSource)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipDGV)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StorageManagemntToolStripMenuItem,
            this.CategoriesToolStripMenuItem,
            this.ProductsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StorageManagemntToolStripMenuItem
            // 
            this.StorageManagemntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStorageToolStripMenuItem,
            this.editStorageToolStripMenuItem,
            this.deleteStorageToolStripMenuItem,
            this.deleteStorageInListToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addTruckToolStripMenuItem,
            this.editTruckToolStripMenuItem,
            this.deleteTruckToolStripMenuItem});
            this.StorageManagemntToolStripMenuItem.Name = "StorageManagemntToolStripMenuItem";
            this.StorageManagemntToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.StorageManagemntToolStripMenuItem.Text = "Управление складами";
            // 
            // addStorageToolStripMenuItem
            // 
            this.addStorageToolStripMenuItem.Name = "addStorageToolStripMenuItem";
            this.addStorageToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addStorageToolStripMenuItem.Text = "Добавить склад";
            this.addStorageToolStripMenuItem.Click += new System.EventHandler(this.addStorageToolStripMenuItem_Click_1);
            // 
            // editStorageToolStripMenuItem
            // 
            this.editStorageToolStripMenuItem.Name = "editStorageToolStripMenuItem";
            this.editStorageToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.editStorageToolStripMenuItem.Text = "Изменить склад";
            this.editStorageToolStripMenuItem.Click += new System.EventHandler(this.editStorageToolStripMenuItem_Click);
            // 
            // deleteStorageToolStripMenuItem
            // 
            this.deleteStorageToolStripMenuItem.Name = "deleteStorageToolStripMenuItem";
            this.deleteStorageToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.deleteStorageToolStripMenuItem.Text = "Удалить склад";
            this.deleteStorageToolStripMenuItem.Click += new System.EventHandler(this.deleteStorageToolStripMenuItem_Click);
            // 
            // deleteStorageInListToolStripMenuItem
            // 
            this.deleteStorageInListToolStripMenuItem.Name = "deleteStorageInListToolStripMenuItem";
            this.deleteStorageInListToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.deleteStorageInListToolStripMenuItem.Text = "Удалить склад из списка";
            this.deleteStorageInListToolStripMenuItem.Click += new System.EventHandler(this.deleteStorageInListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // addTruckToolStripMenuItem
            // 
            this.addTruckToolStripMenuItem.Name = "addTruckToolStripMenuItem";
            this.addTruckToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addTruckToolStripMenuItem.Text = "Добавить грузовик";
            this.addTruckToolStripMenuItem.Click += new System.EventHandler(this.addTruckToolStripMenuItem_Click);
            // 
            // editTruckToolStripMenuItem
            // 
            this.editTruckToolStripMenuItem.Name = "editTruckToolStripMenuItem";
            this.editTruckToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.editTruckToolStripMenuItem.Text = "Изменить ";
            this.editTruckToolStripMenuItem.Click += new System.EventHandler(this.editTruckToolStripMenuItem_Click);
            // 
            // deleteTruckToolStripMenuItem
            // 
            this.deleteTruckToolStripMenuItem.Name = "deleteTruckToolStripMenuItem";
            this.deleteTruckToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.deleteTruckToolStripMenuItem.Text = "Удалить грузовик";
            this.deleteTruckToolStripMenuItem.Click += new System.EventHandler(this.deleteTruckToolStripMenuItem_Click);
            // 
            // CategoriesToolStripMenuItem
            // 
            this.CategoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategToolStripMenuItem,
            this.editCategToolStripMenuItem,
            this.deleteCategToolStripMenuItem});
            this.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem";
            this.CategoriesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.CategoriesToolStripMenuItem.Text = "Категории";
            // 
            // addCategToolStripMenuItem
            // 
            this.addCategToolStripMenuItem.Name = "addCategToolStripMenuItem";
            this.addCategToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.addCategToolStripMenuItem.Text = "Добавить категорию";
            this.addCategToolStripMenuItem.Click += new System.EventHandler(this.addCategToolStripMenuItem_Click);
            // 
            // editCategToolStripMenuItem
            // 
            this.editCategToolStripMenuItem.Name = "editCategToolStripMenuItem";
            this.editCategToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.editCategToolStripMenuItem.Text = "Изменить категорию";
            this.editCategToolStripMenuItem.Click += new System.EventHandler(this.editCategToolStripMenuItem_Click);
            // 
            // deleteCategToolStripMenuItem
            // 
            this.deleteCategToolStripMenuItem.Name = "deleteCategToolStripMenuItem";
            this.deleteCategToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.deleteCategToolStripMenuItem.Text = "Удалить категорию";
            this.deleteCategToolStripMenuItem.Click += new System.EventHandler(this.deleteCategToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShipToolStripMenuItem,
            this.editShipToolStripMenuItem,
            this.deleteShipToolStripMenuItem});
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ProductsToolStripMenuItem.Text = "Товары";
            // 
            // addShipToolStripMenuItem
            // 
            this.addShipToolStripMenuItem.Name = "addShipToolStripMenuItem";
            this.addShipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addShipToolStripMenuItem.Text = "Добавить товар";
            this.addShipToolStripMenuItem.Click += new System.EventHandler(this.addShipToolStripMenuItem_Click);
            // 
            // editShipToolStripMenuItem
            // 
            this.editShipToolStripMenuItem.Name = "editShipToolStripMenuItem";
            this.editShipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editShipToolStripMenuItem.Text = "Изменить товар";
            this.editShipToolStripMenuItem.Click += new System.EventHandler(this.editShipToolStripMenuItem_Click);
            // 
            // deleteShipToolStripMenuItem
            // 
            this.deleteShipToolStripMenuItem.Name = "deleteShipToolStripMenuItem";
            this.deleteShipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteShipToolStripMenuItem.Text = "Удалить товар";
            this.deleteShipToolStripMenuItem.Click += new System.EventHandler(this.deleteShipToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 674);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Склады: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TrucksDGV);
            this.groupBox4.Location = new System.Drawing.Point(7, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 585);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Грузовики склада: ";
            // 
            // TrucksDGV
            // 
            this.TrucksDGV.AllowUserToAddRows = false;
            this.TrucksDGV.AllowUserToDeleteRows = false;
            this.TrucksDGV.AutoGenerateColumns = false;
            this.TrucksDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TrucksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrucksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.storagIdDataGridViewTextBoxColumn,
            this.carNumDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.maxLoadDataGridViewTextBoxColumn});
            this.TrucksDGV.DataSource = this.fKTrucksStorageBindingSource;
            this.TrucksDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrucksDGV.Location = new System.Drawing.Point(3, 18);
            this.TrucksDGV.Name = "TrucksDGV";
            this.TrucksDGV.ReadOnly = true;
            this.TrucksDGV.RowHeadersVisible = false;
            this.TrucksDGV.RowHeadersWidth = 51;
            this.TrucksDGV.RowTemplate.Height = 24;
            this.TrucksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrucksDGV.Size = new System.Drawing.Size(446, 564);
            this.TrucksDGV.TabIndex = 0;
            // 
            // fKTrucksStorageBindingSource
            // 
            this.fKTrucksStorageBindingSource.DataMember = "FK_Trucks_Storage";
            this.fKTrucksStorageBindingSource.DataSource = this.storageBindingSource;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.storageBDDataSet;
            // 
            // storageBDDataSet
            // 
            this.storageBDDataSet.DataSetName = "StorageBDDataSet";
            this.storageBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdressStrCB);
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 54);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Адрес склада: ";
            // 
            // AdressStrCB
            // 
            this.AdressStrCB.DataSource = this.storageBindingSource;
            this.AdressStrCB.DisplayMember = "Address";
            this.AdressStrCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressStrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdressStrCB.FormattingEnabled = true;
            this.AdressStrCB.Location = new System.Drawing.Point(3, 18);
            this.AdressStrCB.Name = "AdressStrCB";
            this.AdressStrCB.Size = new System.Drawing.Size(449, 24);
            this.AdressStrCB.TabIndex = 0;
            this.AdressStrCB.ValueMember = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(487, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 674);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Товары: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox12, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(328, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 646);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBox1);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(314, 123);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Название товара: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKShipmentsCategoriesBindingSource, "Name", true));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 102);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // fKShipmentsCategoriesBindingSource
            // 
            this.fKShipmentsCategoriesBindingSource.DataMember = "FK_Shipments_Categories";
            this.fKShipmentsCategoriesBindingSource.DataSource = this.fKCategoriesStorageBindingSource;
            // 
            // fKCategoriesStorageBindingSource
            // 
            this.fKCategoriesStorageBindingSource.DataMember = "FK_Categories_Storage";
            this.fKCategoriesStorageBindingSource.DataSource = this.storageBindingSource;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.richTextBox2);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 132);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(314, 123);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Масса: ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCharacteristicsShipmentsBindingSource, "Mass", true));
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 18);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(308, 102);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // fKCharacteristicsShipmentsBindingSource
            // 
            this.fKCharacteristicsShipmentsBindingSource.DataMember = "FK_Characteristics_Shipments";
            this.fKCharacteristicsShipmentsBindingSource.DataSource = this.fKShipmentsCategoriesBindingSource;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.richTextBox3);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 261);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(314, 123);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Размер: ";
            // 
            // richTextBox3
            // 
            this.richTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCharacteristicsShipmentsBindingSource, "Size", true));
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(3, 18);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(308, 102);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.richTextBox4);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 390);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(314, 123);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Материал: ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCharacteristicsShipmentsBindingSource, "Material", true));
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.Location = new System.Drawing.Point(3, 18);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(308, 102);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.richTextBox5);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 519);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(314, 124);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Цвет: ";
            // 
            // richTextBox5
            // 
            this.richTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKCharacteristicsShipmentsBindingSource, "Colour", true));
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox5.Location = new System.Drawing.Point(3, 18);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(308, 103);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(7, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 646);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Типы товраов: ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ShipDGV);
            this.groupBox7.Location = new System.Drawing.Point(10, 79);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(295, 561);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Разновидность: ";
            // 
            // ShipDGV
            // 
            this.ShipDGV.AllowUserToAddRows = false;
            this.ShipDGV.AllowUserToDeleteRows = false;
            this.ShipDGV.AutoGenerateColumns = false;
            this.ShipDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ShipDGV.ColumnHeadersHeight = 29;
            this.ShipDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.catIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.ShipDGV.DataSource = this.fKShipmentsCategoriesBindingSource;
            this.ShipDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShipDGV.Location = new System.Drawing.Point(3, 18);
            this.ShipDGV.Name = "ShipDGV";
            this.ShipDGV.ReadOnly = true;
            this.ShipDGV.RowHeadersVisible = false;
            this.ShipDGV.RowHeadersWidth = 51;
            this.ShipDGV.RowTemplate.Height = 24;
            this.ShipDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShipDGV.Size = new System.Drawing.Size(289, 540);
            this.ShipDGV.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CategoriesCB);
            this.groupBox6.Location = new System.Drawing.Point(7, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 49);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Категории: ";
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DataSource = this.fKCategoriesStorageBindingSource;
            this.CategoriesCB.DisplayMember = "CatName";
            this.CategoriesCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(3, 18);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(295, 24);
            this.CategoriesCB.TabIndex = 0;
            this.CategoriesCB.ValueMember = "Id";
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // trucksTableAdapter
            // 
            this.trucksTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // shipmentsTableAdapter
            // 
            this.shipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // characteristicsTableAdapter
            // 
            this.characteristicsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // storagIdDataGridViewTextBoxColumn
            // 
            this.storagIdDataGridViewTextBoxColumn.DataPropertyName = "StoragId";
            this.storagIdDataGridViewTextBoxColumn.HeaderText = "StoragId";
            this.storagIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storagIdDataGridViewTextBoxColumn.Name = "storagIdDataGridViewTextBoxColumn";
            this.storagIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.storagIdDataGridViewTextBoxColumn.Visible = false;
            this.storagIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // carNumDataGridViewTextBoxColumn
            // 
            this.carNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carNumDataGridViewTextBoxColumn.DataPropertyName = "CarNum";
            this.carNumDataGridViewTextBoxColumn.HeaderText = "Номер машины";
            this.carNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNumDataGridViewTextBoxColumn.Name = "carNumDataGridViewTextBoxColumn";
            this.carNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус машины";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxLoadDataGridViewTextBoxColumn
            // 
            this.maxLoadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxLoadDataGridViewTextBoxColumn.DataPropertyName = "MaxLoad";
            this.maxLoadDataGridViewTextBoxColumn.HeaderText = "Макс загрузка";
            this.maxLoadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxLoadDataGridViewTextBoxColumn.Name = "maxLoadDataGridViewTextBoxColumn";
            this.maxLoadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            this.catIdDataGridViewTextBoxColumn.DataPropertyName = "CatId";
            this.catIdDataGridViewTextBoxColumn.HeaderText = "CatId";
            this.catIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            this.catIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.catIdDataGridViewTextBoxColumn.Visible = false;
            this.catIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о складах";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrucksDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTrucksStorageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKShipmentsCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCategoriesStorageBindingSource)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKCharacteristicsShipmentsBindingSource)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShipDGV)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StorageManagemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox AdressStrCB;
        private System.Windows.Forms.DataGridView TrucksDGV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.ToolStripMenuItem addStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCategToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteShipToolStripMenuItem;
        private System.Windows.Forms.DataGridView ShipDGV;
        private StorageBDDataSet storageBDDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private StorageBDDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource fKTrucksStorageBindingSource;
        private StorageBDDataSetTableAdapters.TrucksTableAdapter trucksTableAdapter;
        private System.Windows.Forms.BindingSource fKCategoriesStorageBindingSource;
        private StorageBDDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource fKShipmentsCategoriesBindingSource;
        private StorageBDDataSetTableAdapters.ShipmentsTableAdapter shipmentsTableAdapter;
        private System.Windows.Forms.BindingSource fKCharacteristicsShipmentsBindingSource;
        private StorageBDDataSetTableAdapters.CharacteristicsTableAdapter characteristicsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem deleteStorageInListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTruckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTruckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTruckToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}

