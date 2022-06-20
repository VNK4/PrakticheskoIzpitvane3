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
            this.SuspendLayout();
            // 
            // enemyBtn
            // 
            this.enemyBtn.Location = new System.Drawing.Point(100, 51);
            this.enemyBtn.Name = "enemyBtn";
            this.enemyBtn.Size = new System.Drawing.Size(75, 23);
            this.enemyBtn.TabIndex = 0;
            this.enemyBtn.Text = "Enemy";
            this.enemyBtn.UseVisualStyleBackColor = true;
            this.enemyBtn.Click += new System.EventHandler(this.enemyBtn_Click);
            // 
            // weaponBtn
            // 
            this.weaponBtn.Location = new System.Drawing.Point(100, 153);
            this.weaponBtn.Name = "weaponBtn";
            this.weaponBtn.Size = new System.Drawing.Size(75, 23);
            this.weaponBtn.TabIndex = 1;
            this.weaponBtn.Text = "Weapon";
            this.weaponBtn.UseVisualStyleBackColor = true;
            this.weaponBtn.Click += new System.EventHandler(this.weaponBtn_Click);
            // 
            // ammoBtn
            // 
            this.ammoBtn.Location = new System.Drawing.Point(313, 51);
            this.ammoBtn.Name = "ammoBtn";
            this.ammoBtn.Size = new System.Drawing.Size(75, 23);
            this.ammoBtn.TabIndex = 2;
            this.ammoBtn.Text = "Ammo";
            this.ammoBtn.UseVisualStyleBackColor = true;
            this.ammoBtn.Click += new System.EventHandler(this.ammoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(313, 153);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.ammoBtn);
            this.Controls.Add(this.weaponBtn);
            this.Controls.Add(this.enemyBtn);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enemyBtn;
        private System.Windows.Forms.Button weaponBtn;
        private System.Windows.Forms.Button ammoBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}