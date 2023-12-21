using RPI_kursovaya.utils;
using System;
using System.Windows.Forms;

namespace RPI_kursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void RefreshTrucks()
        {
            this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
            this.characteristicsTableAdapter.Fill(this.storageBDDataSet.Characteristics);
            this.shipmentsTableAdapter.Fill(this.storageBDDataSet.Shipments);
            this.trucksTableAdapter.Fill(this.storageBDDataSet.Trucks);
            this.categoriesTableAdapter.Fill(this.storageBDDataSet.Categories);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Characteristics". При необходимости она может быть перемещена или удалена.
            this.characteristicsTableAdapter.Fill(this.storageBDDataSet.Characteristics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Shipments". При необходимости она может быть перемещена или удалена.
            this.shipmentsTableAdapter.Fill(this.storageBDDataSet.Shipments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.storageBDDataSet.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Trucks". При необходимости она может быть перемещена или удалена.
            this.trucksTableAdapter.Fill(this.storageBDDataSet.Trucks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storageBDDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);


        }

        private void deleteStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdressStrCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсуствует склад");
                    return;
                }

                var id = 0;
                if (int.TryParse(AdressStrCB.SelectedValue.ToString(), out id) && MessageBox.Show($"Вы действительно хотите удалить выбранный склада ({AdressStrCB.Text})?", "Удаление выбранного склада", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.StorageTableName, id);
                    this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addStorageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (new EditStorageForm().ShowDialog() == DialogResult.OK)
                { this.storageTableAdapter.Fill(this.storageBDDataSet.Storage); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdressStrCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсуствует склад");
                    return;
                }

                var id = 0;
                if (int.TryParse(AdressStrCB.SelectedValue.ToString(), out id) && new EditStorageForm(true, id).ShowDialog() == DialogResult.OK)
                {
                    this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteStorageInListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new DeleteStorageForm().ShowDialog() == DialogResult.OK)
                {
                    this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void DeleteTruck()
        {
            try
            {
                if (TrucksDGV.Rows.Count == 0 || TrucksDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран ни один грузовик!");
                    return;
                }

                var id = 0;

                int.TryParse(TrucksDGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);

                var carNum = TrucksDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;

                if (id != 0 && MessageBox.Show($"Вы действительно хотите удалить грузовик {carNum} ?", "Удаление грузовика", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.TrucksTableName, id);
                    this.trucksTableAdapter.Fill(this.storageBDDataSet.Trucks);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void EditTruck(bool isEditMode = false)
        {
            if (isEditMode)
            {
                if (TrucksDGV.Rows.Count == 0 || TrucksDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран ни один грузовик!");
                    return;
                }

                var id = 0;

                int.TryParse(TrucksDGV.SelectedRows[0].Cells[0].Value ?.ToString(), out id);
                if (id != 0 && new EditTruckForm(true, id).ShowDialog() == DialogResult.OK)
                {
                    RefreshTrucks();
                }
            }
            else if (new EditTruckForm().ShowDialog() == DialogResult.OK)
            {
                RefreshTrucks();
            }

        }

        private void editTruckToolStripMenuItem_Click(object sender, EventArgs e)
         => EditTruck(true);

        private void addTruckToolStripMenuItem_Click(object sender, EventArgs e)
         => EditTruck();

        private void deleteTruckToolStripMenuItem_Click(object sender, EventArgs e)
        => DeleteTruck();

        private void addCategToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new EditCatigoriesForm().ShowDialog() == DialogResult.OK)
                { this.storageTableAdapter.Fill(this.storageBDDataSet.Storage);
                    RefreshTrucks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editCategToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсуствует категория!");
                    return;
                }

                var id = 0;
                if (int.TryParse(CategoriesCB.SelectedValue.ToString(), out id) && new EditCatigoriesForm(true, id).ShowDialog() == DialogResult.OK)
                {
                    RefreshTrucks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteCategToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new DelCategForm().ShowDialog() == DialogResult.OK)
                {
                    this.categoriesTableAdapter.Fill(this.storageBDDataSet.Categories);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void EditShipments(bool isEditMode = false)
        {
            if (isEditMode)
            {
                if (ShipDGV.Rows.Count == 0 || ShipDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран ни один товар!");
                    return;
                }

                var id = 0;

                int.TryParse(ShipDGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);
                if (id != 0 && new EditShipForm(true, id).ShowDialog() == DialogResult.OK)
                {
                    RefreshTrucks();
                }
            }
            else if (new EditShipForm().ShowDialog() == DialogResult.OK)
            {
                RefreshTrucks();
            }

        }

        private void addShipToolStripMenuItem_Click(object sender, EventArgs e)
        =>EditShipments();

        private void editShipToolStripMenuItem_Click(object sender, EventArgs e)
        => EditShipments(true);

        private void deleteShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShipDGV.Rows.Count == 0 || ShipDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран ни один товар!");
                    return;
                }

                var id = 0;

                int.TryParse(ShipDGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);

                var Num = ShipDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;
                

                if (id != 0 && MessageBox.Show($"Вы действительно хотите удалить {Num} ?", "Удаление товара", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.ShipmentsTableName, id);
                    this.shipmentsTableAdapter.Fill(this.storageBDDataSet.Shipments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
