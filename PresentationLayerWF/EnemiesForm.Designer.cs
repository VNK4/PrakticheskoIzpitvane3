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
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(86, 30);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(131, 23);
            this.nameTxtBox.TabIndex = 0;
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(86, 59);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(131, 23);
            this.descriptionTxtBox.TabIndex = 1;
            // 
            // healthBox
            // 
            this.healthBox.Location = new System.Drawing.Point(86, 90);
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(131, 23);
            this.healthBox.TabIndex = 3;
            // 
            // armorBox
            // 
            this.armorBox.Location = new System.Drawing.Point(86, 119);
            this.armorBox.Name = "armorBox";
            this.armorBox.Size = new System.Drawing.Size(131, 23);
            this.armorBox.TabIndex = 4;
            // 
            // enemyDataGridView
            // 
            this.enemyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enemyDataGridView.Location = new System.Drawing.Point(384, 30);
            this.enemyDataGridView.Name = "enemyDataGridView";
            this.enemyDataGridView.Size = new System.Drawing.Size(388, 334);
            this.enemyDataGridView.TabIndex = 7;
            this.enemyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enemyDataGridView_CellClick);
            // 
            // weaponsListBox
            // 
            this.weaponsListBox.FormattingEnabled = true;
            this.weaponsListBox.ItemHeight = 15;
            this.weaponsListBox.Location = new System.Drawing.Point(237, 30);
            this.weaponsListBox.Name = "weaponsListBox";
            this.weaponsListBox.Size = new System.Drawing.Size(140, 334);
            this.weaponsListBox.TabIndex = 8;
            this.weaponsListBox.SelectedValueChanged += new System.EventHandler(this.weaponsListBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
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
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Armor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Is Boss";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Weak Against";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(37, 342);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 17;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(142, 342);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addWeaponBtn
            // 
            this.addWeaponBtn.Location = new System.Drawing.Point(266, 370);
            this.addWeaponBtn.Name = "addWeaponBtn";
            this.addWeaponBtn.Size = new System.Drawing.Size(75, 23);
            this.addWeaponBtn.TabIndex = 19;
            this.addWeaponBtn.Text = "Add weapon";
            this.addWeaponBtn.UseVisualStyleBackColor = true;
            this.addWeaponBtn.Click += new System.EventHandler(this.addWeaponBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(86, 370);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(696, 376);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 21;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // isBossBox
            // 
            this.isBossBox.AutoSize = true;
            this.isBossBox.Location = new System.Drawing.Point(86, 150);
            this.isBossBox.Name = "isBossBox";
            this.isBossBox.Size = new System.Drawing.Size(48, 19);
            this.isBossBox.TabIndex = 22;
            this.isBossBox.Text = "True";
            this.isBossBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Behaviour";
            
            // 
            // weakAgainstBox
            // 
            this.weakAgainstBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weakAgainstBox.FormattingEnabled = true;
            this.weakAgainstBox.Location = new System.Drawing.Point(86, 204);
            this.weakAgainstBox.Name = "weakAgainstBox";
            this.weakAgainstBox.Size = new System.Drawing.Size(131, 23);
            this.weakAgainstBox.TabIndex = 6;
            // 
            // behaviourBox
            // 
            this.behaviourBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.enemyBindingSource, "Behaviour", true));
            this.behaviourBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.enemyBindingSource, "Behaviour", true));
            this.behaviourBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enemyBindingSource2, "Behaviour", true));
            this.behaviourBox.DataSource = this.enemyBindingSource3;
            this.behaviourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.behaviourBox.FormattingEnabled = true;
            this.behaviourBox.Location = new System.Drawing.Point(86, 175);
            this.behaviourBox.Name = "behaviourBox";
            this.behaviourBox.Size = new System.Drawing.Size(131, 23);
            this.behaviourBox.TabIndex = 24;
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
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(37, 313);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 25;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // EnemiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 411);
            this.Controls.Add(this.resetBtn);
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
            this.Text = "EnemyForm";
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button resetBtn;
    }
}