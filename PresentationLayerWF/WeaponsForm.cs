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
    public partial class WeaponsForm : Form
    {
        private CRUDContext<Weapon, int> weaponContext;
        private CRUDContext<Enemy, int> enemyContext;
        private CRUDContext<Ammo, int> ammoContext;
        private Weapon selectedWeapon;
        private Ammo selectedAmmo;
        private List<Weapon> weapons;
        int selectedRowIndex = -1;


        public WeaponsForm(CRUDContext<Weapon, int> weaponContext, CRUDContext<Enemy, int> enemyContext, CRUDContext<Ammo, int> ammoContext)
        {
            InitializeComponent();

            this.weaponContext = weaponContext;
            this.enemyContext = enemyContext;
            this.ammoContext = ammoContext;

            LoadHeaderRow();
            LoadWeapons();
            LoadAmmo();

            
        }

        #region Events
        private void createBtn_Click(object sender, EventArgs e) 
        {
            try
            {

                if (selectedWeapon != null)
                {
                    MessageBox.Show("You can't create duplicated Weapon!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string description = descriptionTxtBox.Text;
                    float damageMultiplier = (float)damageMultiplierBox.Value;

                    Weapon weapon = new Weapon(name, description, damageMultiplier);

                    weaponContext.Create(weapon);

                    MessageBox.Show("Weapon created successfully!", "Succsess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddWeaponRow(weapon);

                    ClearData();

                    nameTxtBox.Focus();
                }
                else
                {
                    MessageBox.Show("You must fill all of the things!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Счупи са!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e) 
        {
            try
            {
                if (ValidateData() && selectedWeapon != null)
                {
                    selectedWeapon.Name = nameTxtBox.Text;
                    selectedWeapon.Description = descriptionTxtBox.Text;
                    selectedWeapon.DamageMultiplier = (float)damageMultiplierBox.Value;

                    weaponContext.Update(selectedWeapon);

                    MessageBox.Show("Weapon updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateWeaponRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("All boxes need to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedWeapon != null)
                {
                    weaponContext.Delete(selectedWeapon.ID);

                    MessageBox.Show("Weapon deleted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeleteWeaponRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select Weapon!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        private void addAmmoBtn_Click(object sender, EventArgs e) 
        {
            try
            {
                if (selectedWeapon != null && selectedAmmo != null)
                {
                    if (!((HashSet<Ammo>)selectedWeapon.Ammo).Contains(selectedAmmo)) 
                    {
                        ((HashSet<Ammo>)selectedWeapon.Ammo).Add(selectedAmmo);

                        weaponContext.Update(selectedWeapon);

                        MessageBox.Show(string.Format("{0} added successfully!", selectedAmmo.Name),
                            ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This ammo is added to this weapon!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Weapon and Ammo are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void weaponDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string name = weaponDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string description = weaponDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                float damageMultiplier = (float)weaponDataGridView.Rows[e.RowIndex].Cells[2].Value;


                selectedWeapon = weapons.Find(p => p.Name == name);

                nameTxtBox.Text = name;
                descriptionTxtBox.Text = description;
                damageMultiplierBox.Value = (decimal)damageMultiplier;

                selectedRowIndex = e.RowIndex;

            }
        }

        private void ammoListBox_SelectedValueChanged(object sender, EventArgs e) 
        {
            if (ammoListBox.SelectedValue != null)
            {
                selectedAmmo = ammoListBox.SelectedItem as Ammo;
            }
        }

        #endregion

        #region Helper Methods

        private void LoadHeaderRow() 
        {
            weaponDataGridView.Columns.Add("name", "Name");
            weaponDataGridView.Columns.Add("description", "Description");
            weaponDataGridView.Columns.Add("damageMultiplier", "Damage Multiplier");
            weaponDataGridView.Columns.Add("ammo", "Ammo");
            weaponDataGridView.Columns.Add("enemy", "Enemy");
        }

        private void LoadWeapons() 
        { 
            weapons = weaponContext.ReadAll(true).ToList();

            foreach (Weapon item in weapons)
            {
                DataGridViewRow row = (DataGridViewRow)weaponDataGridView.Rows[0].Clone();

                row.Cells[0].Value = item.Name;
                row.Cells[1].Value = item.Description;
                row.Cells[2].Value = item.DamageMultiplier;

                if (item.Ammo != null)
                {
                    row.Cells[3].Value = string.Join(", ",item.Ammo.Select(c => c.Name));
                    
                }

                if (item.Enemies != null)
                {
                    row.Cells[4].Value = string.Join(", ", item.Enemies.Select(c => c.Name));
                }

                weaponDataGridView.Rows.Add(row);
            }
        }
        private void LoadAmmo()
        {
            ammoListBox.DataSource = ammoContext.ReadAll(true);

            ammoListBox.DisplayMember = "Name";
            ammoListBox.ValueMember = "ID";
        }

        private void AddWeaponRow(Weapon item) 
        {
            DataGridViewRow row = (DataGridViewRow)weaponDataGridView.Rows[0].Clone();

            row.Cells[0].Value = item.Name;
            row.Cells[1].Value = item.Description;
            row.Cells[2].Value = item.DamageMultiplier;

            if (item.Ammo != null)
            {
                row.Cells[3].Value = string.Join(", ", item.Ammo);
                //Dali taka shte stane
            }

            if (item.Enemies != null)
            {
                row.Cells[4].Value = string.Join(", ", item.Enemies);
            }

            weaponDataGridView.Rows.Add(row);
        }

        private void UpdateWeaponRow() 
        {
            weaponDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedWeapon.Name;
            weaponDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedWeapon.Description;
            weaponDataGridView.Rows[selectedRowIndex].Cells[2].Value = selectedWeapon.DamageMultiplier;
            weaponDataGridView.Rows[selectedRowIndex].Cells[3].Value = selectedWeapon.Ammo;
        }

        private void DeleteWeaponRow() 
        {
            weaponDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        public bool ValidateData() 
        {
            if (nameTxtBox.Text != string.Empty && descriptionTxtBox.Text != string.Empty)
            {
                return true;
            }
            return false;
        }

        public void ClearData() 
        { 
            nameTxtBox.Text = string.Empty;
            descriptionTxtBox.Text = string.Empty;
            damageMultiplierBox.Value = damageMultiplierBox.Minimum;

            selectedWeapon = null;
            selectedRowIndex = -1;
            

        }


        #endregion
    }
}
