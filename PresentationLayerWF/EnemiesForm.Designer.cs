namespace PresentationLayerWF
{
    partial class EnemiesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnemiesForm));
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.healthBox = new System.Windows.Forms.NumericUpDown();
            this.armorBox = new System.Windows.Forms.NumericUpDown();
            this.enemyDataGridView = new System.Windows.Forms.DataGridView();
            this.weaponsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addWeaponBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.isBossBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.weakAgainstBox = new System.Windows.Forms.ComboBox();
            this.behaviourBox = new System.Windows.Forms.ComboBox();
            this.enemyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enemyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.enemyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.enemyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(100, 205);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(131, 23);
            this.nameTxtBox.TabIndex = 0;
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(100, 234);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(131, 23);
            this.descriptionTxtBox.TabIndex = 1;
            // 
            // healthBox
            // 
            this.healthBox.Location = new System.Drawing.Point(100, 263);
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(131, 23);
            this.healthBox.TabIndex = 3;
            // 
            // armorBox
            // 
            this.armorBox.Location = new System.Drawing.Point(100, 292);
            this.armorBox.Name = "armorBox";
            this.armorBox.Size = new System.Drawing.Size(131, 23);
            this.armorBox.TabIndex = 4;
            // 
            // enemyDataGridView
            // 
            this.enemyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enemyDataGridView.Location = new System.Drawing.Point(384, 12);
            this.enemyDataGridView.Name = "enemyDataGridView";
            this.enemyDataGridView.ReadOnly = true;
            this.enemyDataGridView.RowHeadersWidth = 51;
            this.enemyDataGridView.Size = new System.Drawing.Size(592, 415);
            this.enemyDataGridView.TabIndex = 10;
            this.enemyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enemyDataGridView_CellClick);
            // 
            // weaponsListBox
            // 
            this.weaponsListBox.FormattingEnabled = true;
            this.weaponsListBox.ItemHeight = 15;
            this.weaponsListBox.Location = new System.Drawing.Point(237, 33);
            this.weaponsListBox.Name = "weaponsListBox";
            this.weaponsListBox.Size = new System.Drawing.Size(140, 394);
            this.weaponsListBox.TabIndex = 13;
            this.weaponsListBox.SelectedValueChanged += new System.EventHandler(this.weaponsListBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Armor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Is Boss";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Weak Against";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(75, 404);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(156, 404);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addWeaponBtn
            // 
            this.addWeaponBtn.Location = new System.Drawing.Point(269, 433);
            this.addWeaponBtn.Name = "addWeaponBtn";
            this.addWeaponBtn.Size = new System.Drawing.Size(75, 23);
            this.addWeaponBtn.TabIndex = 14;
            this.addWeaponBtn.Text = "Add weapon";
            this.addWeaponBtn.UseVisualStyleBackColor = true;
            this.addWeaponBtn.Click += new System.EventHandler(this.addWeaponBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(156, 433);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(901, 433);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // isBossBox
            // 
            this.isBossBox.AutoSize = true;
            this.isBossBox.Location = new System.Drawing.Point(100, 321);
            this.isBossBox.Name = "isBossBox";
            this.isBossBox.Size = new System.Drawing.Size(48, 19);
            this.isBossBox.TabIndex = 5;
            this.isBossBox.Text = "True";
            this.isBossBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Behaviour";
            // 
            // weakAgainstBox
            // 
            this.weakAgainstBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weakAgainstBox.FormattingEnabled = true;
            this.weakAgainstBox.Location = new System.Drawing.Point(100, 375);
            this.weakAgainstBox.Name = "weakAgainstBox";
            this.weakAgainstBox.Size = new System.Drawing.Size(131, 23);
            this.weakAgainstBox.TabIndex = 7;
            // 
            // behaviourBox
            // 
            this.behaviourBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.enemyBindingSource, "Behaviour", true));
            this.behaviourBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.enemyBindingSource, "Behaviour", true));
            this.behaviourBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enemyBindingSource2, "Behaviour", true));
            this.behaviourBox.DataSource = this.enemyBindingSource3;
            this.behaviourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviourBox.FormattingEnabled = true;
            this.behaviourBox.Location = new System.Drawing.Point(100, 346);
            this.behaviourBox.Name = "behaviourBox";
            this.behaviourBox.Size = new System.Drawing.Size(131, 23);
            this.behaviourBox.TabIndex = 6;
            // 
            // enemyBindingSource
            // 
            this.enemyBindingSource.DataSource = typeof(BusinessLayer.Enemy);
            // 
            // enemyBindingSource2
            // 
            this.enemyBindingSource2.DataSource = typeof(BusinessLayer.Enemy);
            // 
            // enemyBindingSource3
            // 
            this.enemyBindingSource3.DataSource = typeof(BusinessLayer.Enemy);
            // 
            // enemyBindingSource1
            // 
            this.enemyBindingSource1.DataSource = typeof(BusinessLayer.Enemy);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Weapons";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(75, 433);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // EnemiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.behaviourBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.isBossBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addWeaponBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weaponsListBox);
            this.Controls.Add(this.enemyDataGridView);
            this.Controls.Add(this.weakAgainstBox);
            this.Controls.Add(this.armorBox);
            this.Controls.Add(this.healthBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "EnemiesForm";
            this.Text = "Enemies";
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.NumericUpDown healthBox;
        private System.Windows.Forms.NumericUpDown armorBox;
        private System.Windows.Forms.DataGridView enemyDataGridView;
        private System.Windows.Forms.ListBox weaponsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addWeaponBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox isBossBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox weakAgainstBox;
        private System.Windows.Forms.ComboBox behaviourBox;
        private System.Windows.Forms.BindingSource enemyBindingSource;
        private System.Windows.Forms.BindingSource enemyBindingSource2;
        private System.Windows.Forms.BindingSource enemyBindingSource1;
        private System.Windows.Forms.BindingSource enemyBindingSource3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
