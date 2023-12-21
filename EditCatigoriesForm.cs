using RPI_kursovaya.utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class EditCatigoriesForm : Form
    {
        private bool _editMode = false;
        private int _catId = 0;
        public EditCatigoriesForm()
        {
            InitializeComponent();
        }

        public EditCatigoriesForm(bool editMode, int storageId)
        {
            _editMode = editMode;
            _catId = storageId;
            InitializeComponent();
        }

        private void EditCatigoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);

            if (_editMode)
            {
                var fieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.CategoriesTableName, _catId);
                addressStrTxtB.Text = fieldsValues[2];
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fields = new Dictionary<string, TableField>();

                fields.Add(Constants.FieldsNames.CategoriesTable.StorageId, new TableField
                {
                    TableFieldType = TableFieldTypes.integer,
                    TableFieldValue = strCB.SelectedValue.ToString(),
                });

                fields.Add(Constants.FieldsNames.CategoriesTable.CatName, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = addressStrTxtB.Text,
                });
                DBHelper.UpdateEntry(Constants.TableNames.CategoriesTableName, _catId, fields);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var fields = new Dictionary<string, TableField>();

                fields.Add(Constants.FieldsNames.CategoriesTable.StorageId, new TableField
                {
                    TableFieldType = TableFieldTypes.integer,
                    TableFieldValue = strCB.SelectedValue.ToString(),
                });

                fields.Add(Constants.FieldsNames.CategoriesTable.CatName, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = addressStrTxtB.Text,
                });
                DBHelper.InsertEntry(Constants.TableNames.CategoriesTableName, fields);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
