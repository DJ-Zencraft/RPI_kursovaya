namespace RPI_kursovaya
{
    partial class EditTruckForm
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
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.numTxtB = new System.Windows.Forms.TextBox();
           // this.mergedDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.mergeredDataSetEditForm = new RPI_kursovaya.MergeredDataSetEditForm();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusTxtB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.strCB = new System.Windows.Forms.ComboBox();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBDDataSet = new RPI_kursovaya.StorageBDDataSet();
            this.modelTxtB = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.maxLoadTxtB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.storageTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.StorageTableAdapter();
            //this.mergedDataTableTableAdapter = new RPI_kursovaya.MergeredDataSetEditFormTableAdapters.MergedDataTableTableAdapter();
            this.truckDataSet = new RPI_kursovaya.TruckDataSet();
            this.mergedTrucksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mergedTrucksTableAdapter = new RPI_kursovaya.TruckDataSetTableAdapters.MergedTrucksTableAdapter();
            this.groupBox0.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.mergedDataTableBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.mergeredDataSetEditForm)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mergedTrucksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox0
            // 
            this.groupBox0.Controls.Add(this.numTxtB);
            this.groupBox0.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox0.Location = new System.Drawing.Point(3, 68);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.Size = new System.Drawing.Size(340, 51);
            this.groupBox0.TabIndex = 0;
            this.groupBox0.TabStop = false;
            this.groupBox0.Text = "Номер машины: ";
            // 
            // numTxtB
            // 
            this.numTxtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mergedTrucksBindingSource, "CarNum", true));
            this.numTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTxtB.Location = new System.Drawing.Point(3, 18);
            this.numTxtB.Name = "numTxtB";
            this.numTxtB.Size = new System.Drawing.Size(334, 22);
            this.numTxtB.TabIndex = 0;
            // 
            // mergedDataTableBindingSource
            // 
           // this.mergedDataTableBindingSource.DataMember = "MergedDataTable";
           // this.mergedDataTableBindingSource.DataSource = this.mergeredDataSetEditForm;
            // 
            // mergeredDataSetEditForm
            // 
           // this.mergeredDataSetEditForm.DataSetName = "MergeredDataSetEditForm";
           // this.mergeredDataSetEditForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusTxtB);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статус: ";
            // 
            // statusTxtB
            // 
            this.statusTxtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mergedTrucksBindingSource, "Status", true));
            this.statusTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusTxtB.Location = new System.Drawing.Point(3, 18);
            this.statusTxtB.Name = "statusTxtB";
            this.statusTxtB.Size = new System.Drawing.Size(334, 22);
            this.statusTxtB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.strCB);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 50);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Склад: ";
            // 
            // strCB
            // 
            this.strCB.DataSource = this.storageBindingSource;
            this.strCB.DisplayMember = "Address";
            this.strCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strCB.FormattingEnabled = true;
            this.strCB.Location = new System.Drawing.Point(3, 18);
            this.strCB.Name = "strCB";
            this.strCB.Size = new System.Drawing.Size(334, 24);
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
            // modelTxtB
            // 
            this.modelTxtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mergedTrucksBindingSource, "Model", true));
            this.modelTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelTxtB.Location = new System.Drawing.Point(3, 18);
            this.modelTxtB.Name = "modelTxtB";
            this.modelTxtB.Size = new System.Drawing.Size(334, 22);
            this.modelTxtB.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.modelTxtB);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 50);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Модель: ";
            // 
            // maxLoadTxtB
            // 
            this.maxLoadTxtB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mergedTrucksBindingSource, "MaxLoad", true));
            this.maxLoadTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLoadTxtB.Location = new System.Drawing.Point(3, 18);
            this.maxLoadTxtB.Name = "maxLoadTxtB";
            this.maxLoadTxtB.Size = new System.Drawing.Size(334, 22);
            this.maxLoadTxtB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox0);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные грузовика";
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(230, 273);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(104, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(13, 274);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(103, 22);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maxLoadTxtB);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 219);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 48);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Максимальная нагрузка: ";
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // mergedDataTableTableAdapter
            // 
           // this.mergedDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // truckDataSet
            // 
            this.truckDataSet.DataSetName = "TruckDataSet";
            this.truckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mergedTrucksBindingSource
            // 
            this.mergedTrucksBindingSource.DataMember = "MergedTrucks";
            this.mergedTrucksBindingSource.DataSource = this.truckDataSet;
            // 
            // mergedTrucksTableAdapter
            // 
            this.mergedTrucksTableAdapter.ClearBeforeFill = true;
            // 
            // EditTruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 322);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTruckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа с грузовиками";
            this.Load += new System.EventHandler(this.EditTruckForm_Load);
            this.groupBox0.ResumeLayout(false);
            this.groupBox0.PerformLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.mergedDataTableBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.mergeredDataSetEditForm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mergedTrucksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox0;
        private System.Windows.Forms.TextBox numTxtB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox statusTxtB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox modelTxtB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox maxLoadTxtB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox strCB;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private StorageBDDataSet storageBDDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private StorageBDDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
       // private System.Windows.Forms.BindingSource mergedDataTableBindingSource;
        //private MergeredDataSetEditForm mergeredDataSetEditForm;
        //private MergeredDataSetEditFormTableAdapters.MergedDataTableTableAdapter mergedDataTableTableAdapter;
        private System.Windows.Forms.BindingSource mergedTrucksBindingSource;
        private TruckDataSet truckDataSet;
        private TruckDataSetTableAdapters.MergedTrucksTableAdapter mergedTrucksTableAdapter;
    }
}