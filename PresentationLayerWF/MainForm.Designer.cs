namespace PresentationLayerWF
{
    partial class MainForm
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
            this.enemyBtn = new System.Windows.Forms.Button();
            this.weaponBtn = new System.Windows.Forms.Button();
            this.ammoBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enemyBtn
            // 
            this.enemyBtn.Location = new System.Drawing.Point(315, 117);
            this.enemyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enemyBtn.Name = "enemyBtn";
            this.enemyBtn.Size = new System.Drawing.Size(110, 47);
            this.enemyBtn.TabIndex = 0;
            this.enemyBtn.Text = "Enemy";
            this.enemyBtn.UseVisualStyleBackColor = true;
            this.enemyBtn.Click += new System.EventHandler(this.enemyBtn_Click);
            // 
            // weaponBtn
            // 
            this.weaponBtn.Location = new System.Drawing.Point(83, 117);
            this.weaponBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weaponBtn.Name = "weaponBtn";
            this.weaponBtn.Size = new System.Drawing.Size(110, 47);
            this.weaponBtn.TabIndex = 1;
            this.weaponBtn.Text = "Weapon";
            this.weaponBtn.UseVisualStyleBackColor = true;
            this.weaponBtn.Click += new System.EventHandler(this.weaponBtn_Click);
            // 
            // ammoBtn
            // 
            this.ammoBtn.Location = new System.Drawing.Point(199, 117);
            this.ammoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ammoBtn.Name = "ammoBtn";
            this.ammoBtn.Size = new System.Drawing.Size(110, 47);
            this.ammoBtn.TabIndex = 2;
            this.ammoBtn.Text = "Ammo";
            this.ammoBtn.UseVisualStyleBackColor = true;
            this.ammoBtn.Click += new System.EventHandler(this.ammoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(199, 186);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 47);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "GAME WIKI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.ammoBtn);
            this.Controls.Add(this.weaponBtn);
            this.Controls.Add(this.enemyBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enemyBtn;
        private System.Windows.Forms.Button weaponBtn;
        private System.Windows.Forms.Button ammoBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
    }
}