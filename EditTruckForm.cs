using RPI_kursovaya.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class EditTruckForm : Form
    {

        private bool _editMode = false;
        private int _id = 0;
        public EditTruckForm()
        {
            InitializeComponent();
        }

        public EditTruckForm(bool editMode, int id)
        {
            _editMode = editMode;
            _id = id;
            InitializeComponent();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            var truckFields = new Dictionary<string, TableField>();

            truckFields.Add(Constants.FieldsNames.TrucksTable.StoragId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = strCB.SelectedValue.ToString(),
            });


            truckFields.Add(Constants.FieldsNames.TrucksTable.CarNum, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = numTxtB.Text,
            });

            truckFields.Add(Constants.FieldsNames.TrucksTable.Status, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = statusTxtB.Text,
            });

            truckFields.Add(Constants.FieldsNames.TrucksTable.Model, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = modelTxtB.Text,
            });

            truckFields.Add(Constants.FieldsNames.TrucksTable.MaxLoad, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = maxLoadTxtB.Text,
            });

            if (_editMode)
            {
                DBHelper.UpdateEntry(Constants.TableNames.TrucksTableName, _id, truckFields);
                
                DialogResult = DialogResult.OK;
            }
            else
            {
                 DBHelper.InsertEntry(Constants.TableNames.TrucksTableName, truckFields);
                DialogResult = DialogResult.OK;
            }
        }

        private void EditTruckForm_Load(object sender, EventArgs e)
        {
            this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);

            if (_editMode)
            {

                this.mergedTrucksTableAdapter.Fill(this.truckDataSet.MergedTrucks, _id);
                var truckeData = mergedTrucksTableAdapter.GetData( _id );

                if (truckeData?.Count > 0)
                {

                    var storagId = truckeData.FirstOrDefault()?.StoragId ?? 0;
                    strCB.SelectedValue = storagId;

                }

                //mergedDataTableTableAdapter.GetData(_id)[0].StoragId
            }
        }
    }
}
