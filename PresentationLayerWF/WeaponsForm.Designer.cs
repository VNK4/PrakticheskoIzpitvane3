namespace PresentationLayerWF
{
    partial class WeaponsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.damageMultiplierBox = new System.Windows.Forms.NumericUpDown();
            this.ammoListBox = new System.Windows.Forms.ListBox();
            this.weaponDataGridView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addAmmoBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.damageMultiplierBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Damage \r\nMultiplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ammo";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(96, 354);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(143, 23);
            this.nameTxtBox.TabIndex = 0;
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(96, 383);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(143, 23);
            this.descriptionTxtBox.TabIndex = 1;
            // 
            // damageMultiplierBox
            // 
            this.damageMultiplierBox.Location = new System.Drawing.Point(96, 412);
            this.damageMultiplierBox.Name = "damageMultiplierBox";
            this.damageMultiplierBox.Size = new System.Drawing.Size(143, 23);
            this.damageMultiplierBox.TabIndex = 2;
            // 
            // ammoListBox
            // 
            this.ammoListBox.FormattingEnabled = true;
            this.ammoListBox.ItemHeight = 15;
            this.ammoListBox.Location = new System.Drawing.Point(245, 31);
            this.ammoListBox.Name = "ammoListBox";
            this.ammoListBox.Size = new System.Drawing.Size(131, 439);
            this.ammoListBox.TabIndex = 7;
            this.ammoListBox.SelectedValueChanged += new System.EventHandler(this.ammoListBox_SelectedValueChanged);
            // 
            // weaponDataGridView
            // 
            this.weaponDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weaponDataGridView.Location = new System.Drawing.Point(382, 12);
            this.weaponDataGridView.Name = "weaponDataGridView";
            this.weaponDataGridView.RowHeadersWidth = 51;
            this.weaponDataGridView.RowTemplate.Height = 25;
            this.weaponDataGridView.Size = new System.Drawing.Size(557, 458);
            this.weaponDataGridView.TabIndex = 8;
            this.weaponDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weaponDataGridView_CellClick);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(83, 447);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(164, 447);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addAmmoBtn
            // 
            this.addAmmoBtn.Location = new System.Drawing.Point(270, 476);
            this.addAmmoBtn.Name = "addAmmoBtn";
            this.addAmmoBtn.Size = new System.Drawing.Size(75, 23);
            this.addAmmoBtn.TabIndex = 11;
            this.addAmmoBtn.Text = "Add";
            this.addAmmoBtn.UseVisualStyleBackColor = true;
            this.addAmmoBtn.Click += new System.EventHandler(this.addAmmoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(164, 476);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(864, 476);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(83, 476);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // WeaponsForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 517);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addAmmoBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.weaponDataGridView);
            this.Controls.Add(this.ammoListBox);
            this.Controls.Add(this.damageMultiplierBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeaponsForm";
            this.Text = "Weapons";
            ((System.ComponentModel.ISupportInitialize)(this.damageMultiplierBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.NumericUpDown damageMultiplierBox;
        private System.Windows.Forms.ListBox ammoListBox;
        private System.Windows.Forms.DataGridView weaponDataGridView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addAmmoBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearBtn;
    }
}