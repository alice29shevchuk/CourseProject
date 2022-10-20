
namespace CourseProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCloseEntryFirstForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonClient.FlatAppearance.BorderSize = 5;
            this.buttonClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClient.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClient.Location = new System.Drawing.Point(42, 339);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(332, 71);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonAdmin.FlatAppearance.BorderSize = 5;
            this.buttonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAdmin.Location = new System.Drawing.Point(42, 425);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(332, 75);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Администратор";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(112, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Войти как:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amel Dental Clinic";
            // 
            // labelCloseEntryFirstForm
            // 
            this.labelCloseEntryFirstForm.AutoSize = true;
            this.labelCloseEntryFirstForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelCloseEntryFirstForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloseEntryFirstForm.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelCloseEntryFirstForm.Location = new System.Drawing.Point(393, 0);
            this.labelCloseEntryFirstForm.Name = "labelCloseEntryFirstForm";
            this.labelCloseEntryFirstForm.Size = new System.Drawing.Size(27, 25);
            this.labelCloseEntryFirstForm.TabIndex = 5;
            this.labelCloseEntryFirstForm.Text = "X";
            this.labelCloseEntryFirstForm.Click += new System.EventHandler(this.labelCloseEntryFirstForm_Click);
            this.labelCloseEntryFirstForm.MouseEnter += new System.EventHandler(this.labelCloseEntryFirstForm_MouseEnter);
            this.labelCloseEntryFirstForm.MouseLeave += new System.EventHandler(this.labelCloseEntryFirstForm_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(421, 512);
            this.Controls.Add(this.labelCloseEntryFirstForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentistNote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCloseEntryFirstForm;
    }
}

