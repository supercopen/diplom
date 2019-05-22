namespace Diolomnay_RABOTA
{
    partial class vibor
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplomDataSet2 = new Diolomnay_RABOTA.DiplomDataSet2();
            this.пользователиTableAdapter = new Diolomnay_RABOTA.DiplomDataSet2TableAdapters.ПользователиTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.работаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работаTableAdapter = new Diolomnay_RABOTA.DiplomDataSet2TableAdapters.РаботаTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.описаниеРаботыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.описание_работыTableAdapter = new Diolomnay_RABOTA.DiplomDataSet2TableAdapters.Описание_работыTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.работаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.описаниеРаботыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.пользователиBindingSource;
            this.comboBox1.DisplayMember = "Фамилия";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 35);
            this.comboBox1.TabIndex = 0;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.diplomDataSet2;
            // 
            // diplomDataSet2
            // 
            this.diplomDataSet2.DataSetName = "DiplomDataSet2";
            this.diplomDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.работаBindingSource;
            this.comboBox2.DisplayMember = "Вид";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(243, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 35);
            this.comboBox2.TabIndex = 1;
            // 
            // работаBindingSource
            // 
            this.работаBindingSource.DataMember = "Работа";
            this.работаBindingSource.DataSource = this.diplomDataSet2;
            // 
            // работаTableAdapter
            // 
            this.работаTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.описаниеРаботыBindingSource;
            this.comboBox3.DisplayMember = "Тип";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(243, 193);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(208, 35);
            this.comboBox3.TabIndex = 2;
            // 
            // описаниеРаботыBindingSource
            // 
            this.описаниеРаботыBindingSource.DataMember = "Описание работы";
            this.описаниеРаботыBindingSource.DataSource = this.diplomDataSet2;
            // 
            // описание_работыTableAdapter
            // 
            this.описание_работыTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.работаBindingSource1;
            this.comboBox4.DisplayMember = "Стоимость";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(243, 255);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(208, 35);
            this.comboBox4.TabIndex = 3;
            // 
            // работаBindingSource1
            // 
            this.работаBindingSource1.DataMember = "Работа";
            this.работаBindingSource1.DataSource = this.diplomDataSet2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стоимость:";
            // 
            // vibor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vibor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vibor_FormClosing);
            this.Load += new System.EventHandler(this.vibor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.описаниеРаботыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private DiplomDataSet2 diplomDataSet2;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private DiplomDataSet2TableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource работаBindingSource;
        private DiplomDataSet2TableAdapters.РаботаTableAdapter работаTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource описаниеРаботыBindingSource;
        private DiplomDataSet2TableAdapters.Описание_работыTableAdapter описание_работыTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource работаBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}