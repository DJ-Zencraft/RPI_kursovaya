using RPI_kursovaya.utils;
using System;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class DelCategForm : Form
    {
        public DelCategForm()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            this.categoriesTableAdapter.Fill(this.storageBDDataSet.Categories);
        }
        private void DelCategForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись? ", "Удалить запись", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(CategCB.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry(Constants.TableNames.CategoriesTableName, id);
                RefreshData();
            }
        }
    }
}
