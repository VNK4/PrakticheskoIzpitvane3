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
using System.Media;

namespace PresentationLayerWF
{
    public partial class EnemiesForm : Form
    {
        private CRUDContext<Enemy, int> enemyContext;
        private CRUDContext<Weapon, int> weaponContext;
        private Enemy selectedEnemy;
        private Weapon selectedWeapon;

        private List<Enemy> enemies;
        int selectedRowIndex = -1;


        public EnemiesForm(CRUDContext<Enemy, int> enemyContext, CRUDContext<Weapon, int> weaponContext)
        {
            InitializeComponent();

            this.enemyContext = enemyContext;
            this.weaponContext = weaponContext;

            behaviourBox.DataSource = Enum.GetValues(typeof(Behaviours));
            weakAgainstBox.DataSource = Enum.GetValues(typeof(DamageTypes));

            LoadHeaderRow();
            LoadEnemies();
            LoadWeapon();

            SoundPlayer enterSound = new SoundPlayer(@"C:\Users\Ivan\Desktop\Testizpit\Sound\enemyFormSound.wav");
            enterSound.Play();

        }

        #region Events

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEnemy != null)
                {
                    MessageBox.Show("You can't create duplicated enemy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string name = nameTxtBox.Text;
                    string description = descriptionTxtBox.Text;
                    double health = Convert.ToDouble(healthBox.Value);
                    double armour = Convert.ToDouble(armorBox.Value);
                    bool isBoss = isBossBox.Checked;

                    Behaviours behaviour;
                    Enum.TryParse(behaviourBox.SelectedValue.ToString(), out behaviour);

                    DamageTypes weakAgainst;
                    Enum.TryParse(weakAgainstBox.SelectedValue.ToString(), out weakAgainst);

                    Enemy enemy = new Enemy(name, description, health, armour, isBoss, behaviour, weakAgainst);

                    enemyContext.Create(enemy);
                    MessageBox.Show("Enemy created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddEnemyRow(enemy);

                    ClearData();

                    nameTxtBox.Focus();

                }
                else
                {
                    MessageBox.Show("You must fill all of the things!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() && selectedEnemy != null)
                {
                    selectedEnemy.Name = nameTxtBox.Text;
                    selectedEnemy.Description = descriptionTxtBox.Text;
                    selectedEnemy.Health = Convert.ToDouble(healthBox.Value);
                    selectedEnemy.Armor = Convert.ToDouble(armorBox.Value);
                    selectedEnemy.IsBoss = isBossBox.Checked;
                    selectedEnemy.Behaviour = (Behaviours)Enum.Parse(typeof(Behaviours), behaviourBox.SelectedItem.ToString());
                    selectedEnemy.WeakAgainst = (DamageTypes)Enum.Parse(typeof(DamageTypes), weakAgainstBox.SelectedItem.ToString());

                    enemyContext.Update(selectedEnemy);

                    MessageBox.Show("Enemy updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateEnemyRow();

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
                if (selectedEnemy != null)
                {
                    enemyContext.Delete(selectedEnemy.ID);

                    DeleteEnemyRow();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select Enemy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void addWeaponBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEnemy != null && selectedWeapon != null)
                {

                    if (!((HashSet<Weapon>)selectedEnemy.Weapons).Contains(selectedWeapon))
                    {
                        ((HashSet<Weapon>)selectedEnemy.Weapons).Add(selectedWeapon);

                        enemyContext.Update(selectedEnemy);
                        

                        MessageBox.Show(string.Format("{0} added successfully!", selectedWeapon.Name), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This weapon is already added to favourites!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    MessageBox.Show("You must choose Enemy and weapon!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
            
        }

        private void enemyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    string name = enemyDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string description = enemyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    double health = Convert.ToDouble(enemyDataGridView.Rows[e.RowIndex].Cells[2].Value);
                    double armor = Convert.ToDouble(enemyDataGridView.Rows[e.RowIndex].Cells[3].Value);
                    bool isBoss = Convert.ToBoolean(enemyDataGridView.Rows[e.RowIndex].Cells[4].Value);

                    Behaviours behaviour = (Behaviours)enemyDataGridView.Rows[e.RowIndex].Cells[5].Value;
                    DamageTypes weakAgainst = (DamageTypes)enemyDataGridView.Rows[e.RowIndex].Cells[6].Value;

                    selectedEnemy = enemies.Find(p => p.Name == name);

                    nameTxtBox.Text = name;
                    descriptionTxtBox.Text = description;
                    healthBox.Value = Convert.ToDecimal(health);
                    armorBox.Value = Convert.ToDecimal(armor);
                    isBossBox.Checked = isBoss;
                    behaviourBox.SelectedItem = behaviour;
                    weakAgainstBox.SelectedItem = weakAgainst;


                    selectedRowIndex = e.RowIndex;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
            

        }

        private void weaponsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (weaponsListBox.SelectedValue != null)
            {
                selectedWeapon = weaponsListBox.SelectedItem as Weapon;
            }
        }

        #endregion

        #region Helper Methods


        private void LoadHeaderRow()
        {
            enemyDataGridView.Columns.Add("name", "Name");
            enemyDataGridView.Columns.Add("description", "Description");
            enemyDataGridView.Columns.Add("health", "Health");
            enemyDataGridView.Columns.Add("armour", "Armour");
            enemyDataGridView.Columns.Add("isBoss", "Is Boss");
            enemyDataGridView.Columns.Add("behaviour", "Behaviour");
            enemyDataGridView.Columns.Add("weakAgainst", "Weak Against");
            enemyDataGridView.Columns.Add("weapon", "Weapon");
        }

        private void LoadEnemies()
        {
            enemies = enemyContext.ReadAll(true).ToList();

            foreach (Enemy item in enemies)
            {
                DataGridViewRow row = (DataGridViewRow)enemyDataGridView.Rows[0].Clone();

                row.Cells[0].Value = item.Name;
                row.Cells[1].Value = item.Description;
                row.Cells[2].Value = item.Health;
                row.Cells[3].Value = item.Armor;
                row.Cells[4].Value = item.IsBoss;
                row.Cells[5].Value = item.Behaviour;
                row.Cells[6].Value = item.WeakAgainst;

                if (item.Weapons != null)
                {
                    row.Cells[7].Value = string.Join(", ", item.Weapons.Select(c => c.Name));
                }

                enemyDataGridView.Rows.Add(row);
            }
        }

        private void LoadWeapon()
        {
            weaponsListBox.DataSource = weaponContext.ReadAll(true);

            weaponsListBox.DisplayMember = "Name";
            weaponsListBox.ValueMember = "ID";
        }

        private void AddEnemyRow(Enemy item)
        {
            DataGridViewRow row = (DataGridViewRow)enemyDataGridView.Rows[0].Clone();


            row.Cells[0].Value = item.Name;
            row.Cells[1].Value = item.Description;
            row.Cells[2].Value = item.Health;
            row.Cells[3].Value = item.Armor;
            row.Cells[4].Value = item.IsBoss;
            row.Cells[5].Value = item.Behaviour;
            row.Cells[6].Value = item.WeakAgainst;

            if (item.Weapons != null)
            {
                row.Cells[7].Value = string.Join(", ", item.Weapons);
            }

            enemyDataGridView.Rows.Add(row);
        }

        private void UpdateEnemyRow()
        {
            enemyDataGridView.Rows[selectedRowIndex].Cells[0].Value = selectedEnemy.Name;
            enemyDataGridView.Rows[selectedRowIndex].Cells[1].Value = selectedEnemy.Description;
            enemyDataGridView.Rows[selectedRowIndex].Cells[2].Value = selectedEnemy.Health;
            enemyDataGridView.Rows[selectedRowIndex].Cells[3].Value = selectedEnemy.Armor;
            enemyDataGridView.Rows[selectedRowIndex].Cells[4].Value = selectedEnemy.IsBoss;
            enemyDataGridView.Rows[selectedRowIndex].Cells[5].Value = selectedEnemy.Behaviour;
            enemyDataGridView.Rows[selectedRowIndex].Cells[6].Value = selectedEnemy.WeakAgainst;
        }

        private void DeleteEnemyRow()
        {
            enemyDataGridView.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData()
        {
            if (nameTxtBox.Text != string.Empty && descriptionTxtBox.Text != string.Empty)
            {
                return true;
            }
            return false;
        }

        private void ClearData()
        {
            nameTxtBox.Text = string.Empty;
            descriptionTxtBox.Text = string.Empty;
            healthBox.Value = healthBox.Minimum;
            armorBox.Value = armorBox.Minimum;
            isBossBox.Checked = false;
            behaviourBox.Text = string.Empty;
            weakAgainstBox.Text = string.Empty;


            selectedEnemy = null;
            selectedRowIndex = -1;
        }


        #endregion


        #region TODO: Delete these here
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        #endregion

        
    }
}
