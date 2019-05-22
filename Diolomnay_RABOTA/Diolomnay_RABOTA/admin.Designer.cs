namespace Diolomnay_RABOTA
{
    partial class admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учётИКонтрольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборToolStripMenuItem,
            this.учётИКонтрольToolStripMenuItem});
            this.функцииToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(131, 33);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // выборToolStripMenuItem
            // 
            this.выборToolStripMenuItem.Name = "выборToolStripMenuItem";
            this.выборToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.выборToolStripMenuItem.Text = "выбор";
            this.выборToolStripMenuItem.Click += new System.EventHandler(this.выборToolStripMenuItem_Click);
            // 
            // учётИКонтрольToolStripMenuItem
            // 
            this.учётИКонтрольToolStripMenuItem.Name = "учётИКонтрольToolStripMenuItem";
            this.учётИКонтрольToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.учётИКонтрольToolStripMenuItem.Text = "Учёт и контроль";
            this.учётИКонтрольToolStripMenuItem.Click += new System.EventHandler(this.учётИКонтрольToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать, администратор!";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 449);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Форма для \"Администратора\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учётИКонтрольToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}