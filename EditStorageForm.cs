using RPI_kursovaya.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class EditStorageForm : Form
    {

        private bool _editMode = false;
        private int _storageId = 0;

        public EditStorageForm()
        {
            InitializeComponent();
        }

        public EditStorageForm(bool editMode, int storageId)
        {
            _editMode = editMode;
            _storageId = storageId;
            InitializeComponent();
        }

        private void EditStorageForm_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.StorageTableName, _storageId);
                addressStrTxtB.Text = fieldsValues[1];
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fields = new Dictionary<string, TableField>();
                fields.Add(Constants.FieldsNames.StorageTable.Address, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = addressStrTxtB.Text,
                });
                DBHelper.UpdateEntry(Constants.TableNames.StorageTableName, _storageId, fields);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var fields = new Dictionary<string, TableField>();
                fields.Add(Constants.FieldsNames.StorageTable.Address, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = addressStrTxtB.Text,
                });
                DBHelper.InsertEntry(Constants.TableNames.StorageTableName, fields);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
