
namespace CourseProject
{
    partial class AdminKeyEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminKeyEntry));
            this.labelAdminLogin = new System.Windows.Forms.Label();
            this.buttonOKAdminEntry = new System.Windows.Forms.Button();
            this.labelAdminKey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBackAdminEntry = new System.Windows.Forms.Button();
            this.labelCloseAdminKeyEntry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminLogin
            // 
            this.labelAdminLogin.AutoSize = true;
            this.labelAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminLogin.Location = new System.Drawing.Point(31, 246);
            this.labelAdminLogin.Name = "labelAdminLogin";
            this.labelAdminLogin.Size = new System.Drawing.Size(80, 25);
            this.labelAdminLogin.TabIndex = 0;
            this.labelAdminLogin.Text = "Логин:";
            // 
            // buttonOKAdminEntry
            // 
            this.buttonOKAdminEntry.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonOKAdminEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOKAdminEntry.FlatAppearance.BorderSize = 5;
            this.buttonOKAdminEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonOKAdminEntry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonOKAdminEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOKAdminEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOKAdminEntry.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonOKAdminEntry.Location = new System.Drawing.Point(225, 433);
            this.buttonOKAdminEntry.Name = "buttonOKAdminEntry";
            this.buttonOKAdminEntry.Size = new System.Drawing.Size(184, 66);
            this.buttonOKAdminEntry.TabIndex = 1;
            this.buttonOKAdminEntry.Text = "Далее";
            this.buttonOKAdminEntry.UseVisualStyleBackColor = false;
            // 
            // labelAdminKey
            // 
            this.labelAdminKey.AutoSize = true;
            this.labelAdminKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminKey.Location = new System.Drawing.Point(31, 333);
            this.labelAdminKey.Name = "labelAdminKey";
            this.labelAdminKey.Size = new System.Drawing.Size(73, 25);
            this.labelAdminKey.TabIndex = 2;
            this.labelAdminKey.Text = "Ключ:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(133, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 30);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(133, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBackAdminEntry
            // 
            this.buttonBackAdminEntry.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBackAdminEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonBackAdminEntry.FlatAppearance.BorderSize = 5;
            this.buttonBackAdminEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackAdminEntry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonBackAdminEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackAdminEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackAdminEntry.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonBackAdminEntry.Location = new System.Drawing.Point(12, 433);
            this.buttonBackAdminEntry.Name = "buttonBackAdminEntry";
            this.buttonBackAdminEntry.Size = new System.Drawing.Size(184, 66);
            this.buttonBackAdminEntry.TabIndex = 6;
            this.buttonBackAdminEntry.Text = "Назад";
            this.buttonBackAdminEntry.UseVisualStyleBackColor = false;
            this.buttonBackAdminEntry.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCloseAdminKeyEntry
            // 
            this.labelCloseAdminKeyEntry.AutoSize = true;
            this.labelCloseAdminKeyEntry.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelCloseAdminKeyEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloseAdminKeyEntry.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelCloseAdminKeyEntry.Location = new System.Drawing.Point(394, 0);
            this.labelCloseAdminKeyEntry.Name = "labelCloseAdminKeyEntry";
            this.labelCloseAdminKeyEntry.Size = new System.Drawing.Size(27, 25);
            this.labelCloseAdminKeyEntry.TabIndex = 10;
            this.labelCloseAdminKeyEntry.Text = "X";
            this.labelCloseAdminKeyEntry.Click += new System.EventHandler(this.labelCloseAdminKeyEntry_Click);
            this.labelCloseAdminKeyEntry.MouseEnter += new System.EventHandler(this.labelCloseAdminKeyEntry_MouseEnter);
            this.labelCloseAdminKeyEntry.MouseLeave += new System.EventHandler(this.labelCloseAdminKeyEntry_MouseLeave);
            // 
            // AdminKeyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(421, 511);
            this.Controls.Add(this.labelCloseAdminKeyEntry);
            this.Controls.Add(this.buttonBackAdminEntry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAdminKey);
            this.Controls.Add(this.buttonOKAdminEntry);
            this.Controls.Add(this.labelAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminKeyEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор: Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminLogin;
        private System.Windows.Forms.Button buttonOKAdminEntry;
        private System.Windows.Forms.Label labelAdminKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBackAdminEntry;
        private System.Windows.Forms.Label labelCloseAdminKeyEntry;
    }
}