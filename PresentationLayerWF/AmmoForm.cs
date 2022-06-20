using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace PresentationLayerWF
{
    public partial class AmmoForm : Form
    {
        private CRUDContext<Ammo, int> ammoContext;
        private Ammo selectedAmmo;
        private List<Ammo> ammo;
        int selectedRowIndex = -1;

        public AmmoForm(CRUDContext<Ammo, int> ammoContext)
        {
            InitializeComponent();

            this.ammoContext = ammoContext;

            damageTypeBox.DataSource = Enum.GetValues(typeof(DamageTypes));

            LoadHeaderRow();
            LoadAmmo();

        }
        #region Events

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAmmo != null)
                {
                    MessageBox.Show("You can't create duplicated Ammo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValidateData())
                {
                    string name = nameBox.Text;
                    string description = descriptionBox.Text;
                    double damage = Convert.ToDouble(damageBox.Text);

                    DamageTypes damageType;
                    Enum.TryParse(damageTypeBox.SelectedValue.ToString(), out damageType);

                    Ammo ammo = new Ammo(name, description, damage, damageType);

                    ammoContext.Create(ammo);
                    MessageBox.Show("Ammo created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddAmmoRow(ammo);
                    ClearData();

                    nameBox.Focus();
                }
                else
                {
                    MessageBox.Show("TODO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("TODO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() && selectedAmmo != null)
                {
                    selectedAmmo.Name = nameBox.Text;
                    selectedAmmo.Description = descriptionBox.Text;
                    selectedAmmo.Damage = Convert.ToDouble(damageBox.Value);
                    selectedAmmo.DamageType = (DamageTypes)Enum.Parse(typeof(DamageTypes), damageTypeBox.SelectedItem.ToString());


                    ammoContext.Update(selectedAmmo);

                    MessageBox.Show("Ammo updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateAmmoRow();

                    ClearData();

                }
                else
                {
                    MessageBox.Show("All options need to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error: broke", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAmmo != null)
                {
                    ammoContext.Delete(selectedAmmo.ID);

                    MessageBox.Show("Ammo deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeleteAmmoRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select Ammo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ammoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string name = ammoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string description = ammoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                double damage = Convert.ToDouble(ammoDataGridView.Rows[e.RowIndex].Cells[2].Value);
                DamageTypes damageType = (DamageTypes)ammoDataGridView.Rows[e.RowIndex].Cells[3].Value;

                selectedAmmo = ammo.Find(p => p.Name == name);
                

                nameBox.Text = name;
                descriptionBox.Text = description;
                damageBox.Value = Convert.ToDecimal(damage);
                damageTypeBox.SelectedItem = damageType;

                selectedRowIndex = e.RowIndex;

                
                
            }
        }

        #endregion

        #region Helper Methods
        private void LoadHeaderRow() 
        {
            ammoDataGridView.Columns.Add("name", "Name");
            ammoDataGridView.Columns.Add("description", "Description");
            ammoDataGridView.Columns.Add("damage", "Damage");
            ammoDataGridView.Columns.Add("damagetype", "Damage Type");
            ammoDataGridView.Columns.Add("weapons", "Weapons");
        }

        private void LoadAmmo() 
        {
            ammo = ammoContext.ReadAll(true).ToList();

            foreach (Ammo item in ammo)
            {
                DataGridViewRow row = (DataGridViewRow)ammoDataGridView.Rows[0].Clone();

                row.Cells[0].Value = item.Name;
                row.Cells[1].Value = item.Description;
                row.Cells[2].Value = item.Damage;
                row.Cells[3].Value = item.DamageType;

                if (item.Weapons != null)
                {
                    row.Cells[4].Value = string.Join(", ", item.Weapons.Select(c => c.Name));
                }
                ammoDataGridView.Rows.Add(row);
            }
        }

        private void AddAmmoRow(Ammo item) 
        {
            DataGridViewRow row = (DataGridViewRow)ammoDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item.Name;
            row.Cells[1].Value = item.Description;
            row.Cells[2].Value = item.Damage;
            row.Cells[3].Value = item.DamageType;

            if (item.Weapons != null)
            {
                row.Cells[4].Value = string.Join(", ", item.Weapons);
            }
            ammoDataGridView.Rows.Add(row);
        }

        private void UpdateAmmoRow() 
        {
            ammoDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedAmmo.Name;
            ammoDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedAmmo.Description;
            ammoDataGridView.Rows[selectedRowIndex].Cells[2].Value = selectedAmmo.Damage;
            ammoDataGridView.Rows[selectedRowIndex].Cells[3].Value = selectedAmmo.DamageType;
            ammoDataGridView.Rows[selectedRowIndex].Cells[4].Value = selectedAmmo.Weapons;
        }

        private void DeleteAmmoRow() 
        {
            ammoDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData() 
        {
            if (nameBox.Text != string.Empty && descriptionBox.Text != string.Empty) 
            {
                return true;
            }       
            return false; 
        }

        private void ClearData() 
        {
            nameBox.Text = string.Empty;
            descriptionBox.Text = string.Empty;
            damageBox.Value = damageBox.Minimum;
            damageTypeBox.Text = string.Empty;

            selectedAmmo = null;
            selectedRowIndex = -1;


        }

        #endregion
    }
}
