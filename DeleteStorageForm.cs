using RPI_kursovaya.utils;
using System;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class DeleteStorageForm : Form
    {
        public DeleteStorageForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
        }

        private void DeleteStorageForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись? ", "Удалить запись", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(StorageCB.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry(Constants.TableNames.StorageTableName, id);
                RefreshData();
            }
        }
    }
}
