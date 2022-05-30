namespace WindowsFormsApp1
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерзачеткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерсеместраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаэкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПреподDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.успеваемостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._319_4_КурьяковDataSet = new WindowsFormsApp1._319_4_КурьяковDataSet();
            this.успеваемостьTableAdapter = new WindowsFormsApp1._319_4_КурьяковDataSetTableAdapters.УспеваемостьTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_4_КурьяковDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзачеткиDataGridViewTextBoxColumn,
            this.номерсеместраDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.датаэкзаменаDataGridViewTextBoxColumn,
            this.фамилияПреподDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.успеваемостьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // номерзачеткиDataGridViewTextBoxColumn
            // 
            this.номерзачеткиDataGridViewTextBoxColumn.DataPropertyName = "Номер_зачетки";
            this.номерзачеткиDataGridViewTextBoxColumn.HeaderText = "Номер_зачетки";
            this.номерзачеткиDataGridViewTextBoxColumn.Name = "номерзачеткиDataGridViewTextBoxColumn";
            this.номерзачеткиDataGridViewTextBoxColumn.Width = 112;
            // 
            // номерсеместраDataGridViewTextBoxColumn
            // 
            this.номерсеместраDataGridViewTextBoxColumn.DataPropertyName = "Номер_семестра";
            this.номерсеместраDataGridViewTextBoxColumn.HeaderText = "Номер_семестра";
            this.номерсеместраDataGridViewTextBoxColumn.Name = "номерсеместраDataGridViewTextBoxColumn";
            this.номерсеместраDataGridViewTextBoxColumn.Width = 121;
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            this.предметDataGridViewTextBoxColumn.Width = 77;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.Width = 70;
            // 
            // датаэкзаменаDataGridViewTextBoxColumn
            // 
            this.датаэкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Дата_экзамена";
            this.датаэкзаменаDataGridViewTextBoxColumn.HeaderText = "Дата_экзамена";
            this.датаэкзаменаDataGridViewTextBoxColumn.Name = "датаэкзаменаDataGridViewTextBoxColumn";
            this.датаэкзаменаDataGridViewTextBoxColumn.Width = 114;
            // 
            // фамилияПреподDataGridViewTextBoxColumn
            // 
            this.фамилияПреподDataGridViewTextBoxColumn.DataPropertyName = "Фамилия_Препод";
            this.фамилияПреподDataGridViewTextBoxColumn.HeaderText = "Фамилия_Препод";
            this.фамилияПреподDataGridViewTextBoxColumn.Name = "фамилияПреподDataGridViewTextBoxColumn";
            this.фамилияПреподDataGridViewTextBoxColumn.Width = 125;
            // 
            // успеваемостьBindingSource
            // 
            this.успеваемостьBindingSource.DataMember = "Успеваемость";
            this.успеваемостьBindingSource.DataSource = this._319_4_КурьяковDataSet;
            // 
            // _319_4_КурьяковDataSet
            // 
            this._319_4_КурьяковDataSet.DataSetName = "_319_4_КурьяковDataSet";
            this._319_4_КурьяковDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // успеваемостьTableAdapter
            // 
            this.успеваемостьTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(721, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_4_КурьяковDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _319_4_КурьяковDataSet _319_4_КурьяковDataSet;
        private System.Windows.Forms.BindingSource успеваемостьBindingSource;
        private _319_4_КурьяковDataSetTableAdapters.УспеваемостьTableAdapter успеваемостьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзачеткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерсеместраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаэкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПреподDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}