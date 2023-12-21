namespace RPI_kursovaya
{
    partial class EditShipForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.strCB = new System.Windows.Forms.ComboBox();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBDDataSet = new RPI_kursovaya.StorageBDDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categCB = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countTB = new System.Windows.Forms.TextBox();
            this.shipDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentsDataSet = new RPI_kursovaya.ShipmentsDataSet();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colourTB = new System.Windows.Forms.RichTextBox();
            this.materialTB = new System.Windows.Forms.RichTextBox();
            this.sizeTB = new System.Windows.Forms.RichTextBox();
            this.massTB = new System.Windows.Forms.RichTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.storageTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.StorageTableAdapter();
            this.categoriesTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.CategoriesTableAdapter();
            this.shipDataTableTableAdapter = new RPI_kursovaya.ShipmentsDataSetTableAdapters.ShipDataTableTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strCB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Склад: ";
            // 
            // strCB
            // 
            this.strCB.DataSource = this.storageBindingSource;
            this.strCB.DisplayMember = "Address";
            this.strCB.FormattingEnabled = true;
            this.strCB.Location = new System.Drawing.Point(7, 22);
            this.strCB.Name = "strCB";
            this.strCB.Size = new System.Drawing.Size(187, 24);
            this.strCB.TabIndex = 0;
            this.strCB.ValueMember = "Id";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categCB);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Категория: ";
            // 
            // categCB
            // 
            this.categCB.DataSource = this.categoriesBindingSource;
            this.categCB.DisplayMember = "CatName";
            this.categCB.FormattingEnabled = true;
            this.categCB.Location = new System.Drawing.Point(7, 21);
            this.categCB.Name = "categCB";
            this.categCB.Size = new System.Drawing.Size(187, 24);
            this.categCB.TabIndex = 0;
            this.categCB.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.storageBDDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.countTB);
            this.groupBox3.Controls.Add(this.NameTB);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Товар: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название товара:";
            // 
            // countTB
            // 
            this.countTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipDataTableBindingSource, "Count", true));
            this.countTB.Location = new System.Drawing.Point(7, 87);
            this.countTB.Name = "countTB";
            this.countTB.Size = new System.Drawing.Size(193, 22);
            this.countTB.TabIndex = 1;
            // 
            // shipDataTableBindingSource
            // 
            this.shipDataTableBindingSource.DataMember = "ShipDataTable";
            this.shipDataTableBindingSource.DataSource = this.shipmentsDataSet;
            // 
            // shipmentsDataSet
            // 
            this.shipmentsDataSet.DataSetName = "ShipmentsDataSet";
            this.shipmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameTB
            // 
            this.NameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipDataTableBindingSource, "Name", true));
            this.NameTB.Location = new System.Drawing.Point(7, 43);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(193, 22);
            this.NameTB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.colourTB);
            this.groupBox4.Controls.Add(this.materialTB);
            this.groupBox4.Controls.Add(this.sizeTB);
            this.groupBox4.Controls.Add(this.massTB);
            this.groupBox4.Location = new System.Drawing.Point(220, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 313);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Данные о товаре";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Цвет: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Материал: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Размер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Масса (целое в кг): ";
            // 
            // colourTB
            // 
            this.colourTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipDataTableBindingSource, "Colour", true));
            this.colourTB.Location = new System.Drawing.Point(292, 194);
            this.colourTB.Name = "colourTB";
            this.colourTB.Size = new System.Drawing.Size(270, 112);
            this.colourTB.TabIndex = 7;
            this.colourTB.Text = "";
            // 
            // materialTB
            // 
            this.materialTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipDataTableBindingSource, "Material", true));
            this.materialTB.Location = new System.Drawing.Point(6, 194);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(271, 112);
            this.materialTB.TabIndex = 6;
            this.materialTB.Text = "";
            // 
            // sizeTB
            // 
            this.sizeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipDataTableBindingSource, "Size", true));
            this.sizeTB.Location = new System.Drawing.Point(292, 43);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(270, 119);
            this.sizeTB.TabIndex = 5;
            this.sizeTB.Text = "";
            // 
            // massTB
            // 
            this.massTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipDataTableBindingSource, "Mass", true));
            this.massTB.Location = new System.Drawing.Point(6, 43);
            this.massTB.Name = "massTB";
            this.massTB.Size = new System.Drawing.Size(271, 119);
            this.massTB.TabIndex = 4;
            this.massTB.Text = "";
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(69, 343);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(96, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(634, 343);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // shipDataTableTableAdapter
            // 
            this.shipDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // EditShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditShipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карточка товара";
            this.Load += new System.EventHandler(this.EditShipForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox strCB;
        private System.Windows.Forms.ComboBox categCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox colourTB;
        private System.Windows.Forms.RichTextBox materialTB;
        private System.Windows.Forms.RichTextBox sizeTB;
        private System.Windows.Forms.RichTextBox massTB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private StorageBDDataSet storageBDDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private StorageBDDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private StorageBDDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource shipDataTableBindingSource;
        private ShipmentsDataSet shipmentsDataSet;
        private ShipmentsDataSetTableAdapters.ShipDataTableTableAdapter shipDataTableTableAdapter;
    }
}