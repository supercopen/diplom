namespace Diolomnay_RABOTA
{
    partial class shag_two
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
            this.diplomDataSet = new Diolomnay_RABOTA.DiplomDataSet();
            this.работаTableAdapter = new Diolomnay_RABOTA.DiplomDataSetTableAdapters.РаботаTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.diplomDataSet1 = new Diolomnay_RABOTA.DiplomDataSet1();
            this.работаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работаTableAdapter1 = new Diolomnay_RABOTA.DiplomDataSet1TableAdapters.РаботаTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.описаниеРаботыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.описание_работыTableAdapter = new Diolomnay_RABOTA.DiplomDataSet1TableAdapters.Описание_работыTableAdapter();
            this.работаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.работаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.описаниеРаботыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.работаBindingSource;
            this.comboBox1.DisplayMember = "Вид";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 35);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работаTableAdapter
            // 
            this.работаTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.описаниеРаботыBindingSource;
            this.comboBox2.DisplayMember = "Тип";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(253, 95);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 35);
            this.comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diplomDataSet1
            // 
            this.diplomDataSet1.DataSetName = "DiplomDataSet1";
            this.diplomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работаBindingSource
            // 
            this.работаBindingSource.DataMember = "Работа";
            this.работаBindingSource.DataSource = this.diplomDataSet1;
            // 
            // работаTableAdapter1
            // 
            this.работаTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.работаBindingSource1;
            this.comboBox3.DisplayMember = "Стоимость";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(253, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(209, 35);
            this.comboBox3.TabIndex = 3;
            // 
            // описаниеРаботыBindingSource
            // 
            this.описаниеРаботыBindingSource.DataMember = "Описание работы";
            this.описаниеРаботыBindingSource.DataSource = this.diplomDataSet1;
            // 
            // описание_работыTableAdapter
            // 
            this.описание_работыTableAdapter.ClearBeforeFill = true;
            // 
            // работаBindingSource1
            // 
            this.работаBindingSource1.DataMember = "Работа";
            this.работаBindingSource1.DataSource = this.diplomDataSet1;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.работаBindingSource2;
            this.comboBox4.DisplayMember = "Время";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(253, 179);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(209, 35);
            this.comboBox4.TabIndex = 4;
            // 
            // работаBindingSource2
            // 
            this.работаBindingSource2.DataMember = "Работа";
            this.работаBindingSource2.DataSource = this.diplomDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вид:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Стоимость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Время:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 349);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шаг второй: Деятельность";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.описаниеРаботыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private DiplomDataSet diplomDataSet;
        private DiplomDataSetTableAdapters.РаботаTableAdapter работаTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private DiplomDataSet1 diplomDataSet1;
        private System.Windows.Forms.BindingSource работаBindingSource;
        private DiplomDataSet1TableAdapters.РаботаTableAdapter работаTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource описаниеРаботыBindingSource;
        private DiplomDataSet1TableAdapters.Описание_работыTableAdapter описание_работыTableAdapter;
        private System.Windows.Forms.BindingSource работаBindingSource1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource работаBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}