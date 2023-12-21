using RPI_kursovaya.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class EditShipForm : Form
    {
        private bool _isEditMode = false;
        private int _id = 0;

        public EditShipForm()
        {
            InitializeComponent();
        }

        public EditShipForm(bool isEditMode, int id)
        {
            _isEditMode = isEditMode;
            _id = id;
            InitializeComponent();
        }

            private void EditShipForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.storageBDDataSet.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
          
            if (_isEditMode)
            {
                this.shipDataTableTableAdapter.Fill(this.shipmentsDataSet.ShipDataTable, _id);
                var shipData = shipDataTableTableAdapter.GetData(_id);
                if (shipData?.Count > 0)
                {
                    var catId = shipData.FirstOrDefault()?.CatId ?? 0;
                    categCB.SelectedValue = catId;
                }
            }
         }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            var shipFields = new Dictionary<string, TableField>();
            shipFields.Add(Constants.FieldsNames.ShipmentsTable.CatId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = categCB.SelectedValue.ToString()
            });
            shipFields.Add(Constants.FieldsNames.ShipmentsTable.Name, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = NameTB.Text

            });
            shipFields.Add(Constants.FieldsNames.ShipmentsTable.Count, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = countTB.Text
            });

            //
            //

            var charactFields = new Dictionary<string, TableField>();
            charactFields.Add(Constants.FieldsNames.CharacteristicsTable.ShipId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = string.Empty
            });
            charactFields.Add(Constants.FieldsNames.CharacteristicsTable.Mass, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = massTB.Text

            });
            charactFields.Add(Constants.FieldsNames.CharacteristicsTable.Size, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = sizeTB.Text
            });
            charactFields.Add(Constants.FieldsNames.CharacteristicsTable.Material, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = materialTB.Text
            });
            charactFields.Add(Constants.FieldsNames.CharacteristicsTable.Colour, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = colourTB.Text
            });

            if (_isEditMode)
            {

                charactFields[Constants.FieldsNames.CharacteristicsTable.ShipId].TableFieldValue
             = _id.ToString();     

                DBHelper.UpdateEntry(Constants.TableNames.ShipmentsTableName, _id, shipFields);
                DBHelper.UpdateEntry(Constants.TableNames.CharacteristicsTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsNames.CharacteristicsTable.ShipId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = _id.ToString()
                    }
                }, charactFields);               
                DialogResult = DialogResult.OK;
            }

            else
            {
                var catId = DBHelper.InsertEntry(Constants.TableNames.ShipmentsTableName, shipFields);
                charactFields[Constants.FieldsNames.CharacteristicsTable.ShipId].TableFieldValue
                    = catId.ToString();

                DBHelper.InsertEntry(Constants.TableNames.CharacteristicsTableName, charactFields);
                DialogResult = DialogResult.OK;
            }



        }
    }
}
