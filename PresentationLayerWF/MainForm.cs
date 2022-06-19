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
    public partial class MainForm : Form
    {
        private CRUDContext<Enemy, int> enemyContext;
        private CRUDContext<Weapon, int> weaponContext;
        private CRUDContext<Ammo, int> ammoContext;   

        public MainForm()
        {
            InitializeComponent();

            GameWikiDBContext context = new GameWikiDBContext();

            enemyContext = new CRUDContext<Enemy, int>(context.Enemies, context);
            weaponContext = new CRUDContext<Weapon, int>(context.Weapons, context);
            ammoContext = new CRUDContext<Ammo, int>(context.Ammo, context);

            
        }

        private void enemyBtn_Click(object sender, EventArgs e)
        {
            EnemiesForm enemyForm = new EnemiesForm(enemyContext, weaponContext);
            enemyForm.ShowDialog();
        }
        
        private void weaponBtn_Click(object sender, EventArgs e)
        {
            WeaponsForm weaponForm = new WeaponsForm(weaponContext, enemyContext, ammoContext);
            weaponForm.ShowDialog();
        }
        
        private void ammoBtn_Click(object sender, EventArgs e)
        {
            AmmoForm ammoForm = new AmmoForm(ammoContext);
            ammoForm.ShowDialog();  
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
