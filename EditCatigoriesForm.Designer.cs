namespace RPI_kursovaya
{
    partial class EditCatigoriesForm
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addressStrTxtB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.storageTableAdapter = new RPI_kursovaya.StorageBDDataSetTableAdapters.StorageTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strCB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Склад: ";
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
            this.strCB.Size = new System.Drawing.Size(421, 24);
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
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CloseBtn.Location = new System.Drawing.Point(228, 60);
            this.CloseBtn.MaximumSize = new System.Drawing.Size(193, 23);
            this.CloseBtn.MinimumSize = new System.Drawing.Size(193, 23);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(193, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(6, 61);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(191, 22);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addressStrTxtB
            // 
            this.addressStrTxtB.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressStrTxtB.Location = new System.Drawing.Point(3, 18);
            this.addressStrTxtB.Name = "addressStrTxtB";
            this.addressStrTxtB.Size = new System.Drawing.Size(421, 22);
            this.addressStrTxtB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addressStrTxtB);
            this.groupBox2.Controls.Add(this.CloseBtn);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Название категории: ";
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // EditCatigoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 155);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(445, 202);
            this.MinimumSize = new System.Drawing.Size(445, 202);
            this.Name = "EditCatigoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа с категориями";
            this.Load += new System.EventHandler(this.EditCatigoriesForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBDDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.Button CloseBtn;
            private System.Windows.Forms.Button saveBtn;
            private System.Windows.Forms.TextBox addressStrTxtB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox strCB;
        private StorageBDDataSet storageBDDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private StorageBDDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
    }
    }