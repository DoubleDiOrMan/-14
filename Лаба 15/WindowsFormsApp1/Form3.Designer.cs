namespace WindowsFormsApp1
{
    partial class Form3
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
            this.номерпредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._319_4_КурьяковDataSet = new WindowsFormsApp1._319_4_КурьяковDataSet();
            this.предметTableAdapter = new WindowsFormsApp1._319_4_КурьяковDataSetTableAdapters.ПредметTableAdapter();
            this.fKУспеваемостьПредметBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.успеваемостьTableAdapter = new WindowsFormsApp1._319_4_КурьяковDataSetTableAdapters.УспеваемостьTableAdapter();
            this.успеваемостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерфакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетTableAdapter = new WindowsFormsApp1._319_4_КурьяковDataSetTableAdapters.ФакультетTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_4_КурьяковDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKУспеваемостьПредметBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерпредметаDataGridViewTextBoxColumn,
            this.названиепредметаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.предметBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // номерпредметаDataGridViewTextBoxColumn
            // 
            this.номерпредметаDataGridViewTextBoxColumn.DataPropertyName = "Номер_предмета";
            this.номерпредметаDataGridViewTextBoxColumn.HeaderText = "Номер_предмета";
            this.номерпредметаDataGridViewTextBoxColumn.Name = "номерпредметаDataGridViewTextBoxColumn";
            this.номерпредметаDataGridViewTextBoxColumn.Width = 121;
            // 
            // названиепредметаDataGridViewTextBoxColumn
            // 
            this.названиепредметаDataGridViewTextBoxColumn.DataPropertyName = "Название_предмета";
            this.названиепредметаDataGridViewTextBoxColumn.HeaderText = "Название_предмета";
            this.названиепредметаDataGridViewTextBoxColumn.Name = "названиепредметаDataGridViewTextBoxColumn";
            this.названиепредметаDataGridViewTextBoxColumn.Width = 137;
            // 
            // предметBindingSource
            // 
            this.предметBindingSource.DataMember = "Предмет";
            this.предметBindingSource.DataSource = this._319_4_КурьяковDataSet;
            // 
            // _319_4_КурьяковDataSet
            // 
            this._319_4_КурьяковDataSet.DataSetName = "_319_4_КурьяковDataSet";
            this._319_4_КурьяковDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предметTableAdapter
            // 
            this.предметTableAdapter.ClearBeforeFill = true;
            // 
            // fKУспеваемостьПредметBindingSource
            // 
            this.fKУспеваемостьПредметBindingSource.DataMember = "FK_Успеваемость_Предмет";
            this.fKУспеваемостьПредметBindingSource.DataSource = this.предметBindingSource;
            // 
            // успеваемостьTableAdapter
            // 
            this.успеваемостьTableAdapter.ClearBeforeFill = true;
            // 
            // успеваемостьBindingSource
            // 
            this.успеваемостьBindingSource.DataMember = "Успеваемость";
            this.успеваемостьBindingSource.DataSource = this._319_4_КурьяковDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерфакультетаDataGridViewTextBoxColumn,
            this.названиефакультетаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.факультетBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(381, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(324, 320);
            this.dataGridView2.TabIndex = 1;
            // 
            // номерфакультетаDataGridViewTextBoxColumn
            // 
            this.номерфакультетаDataGridViewTextBoxColumn.DataPropertyName = "Номер_факультета";
            this.номерфакультетаDataGridViewTextBoxColumn.HeaderText = "Номер_факультета";
            this.номерфакультетаDataGridViewTextBoxColumn.Name = "номерфакультетаDataGridViewTextBoxColumn";
            this.номерфакультетаDataGridViewTextBoxColumn.Width = 131;
            // 
            // названиефакультетаDataGridViewTextBoxColumn
            // 
            this.названиефакультетаDataGridViewTextBoxColumn.DataPropertyName = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.HeaderText = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.Name = "названиефакультетаDataGridViewTextBoxColumn";
            this.названиефакультетаDataGridViewTextBoxColumn.Width = 147;
            // 
            // факультетBindingSource
            // 
            this.факультетBindingSource.DataMember = "Факультет";
            this.факультетBindingSource.DataSource = this._319_4_КурьяковDataSet;
            // 
            // факультетTableAdapter
            // 
            this.факультетTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(796, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Предмет и Факультет";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_4_КурьяковDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKУспеваемостьПредметBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _319_4_КурьяковDataSet _319_4_КурьяковDataSet;
        private System.Windows.Forms.BindingSource предметBindingSource;
        private _319_4_КурьяковDataSetTableAdapters.ПредметTableAdapter предметTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKУспеваемостьПредметBindingSource;
        private _319_4_КурьяковDataSetTableAdapters.УспеваемостьTableAdapter успеваемостьTableAdapter;
        private System.Windows.Forms.BindingSource успеваемостьBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource факультетBindingSource;
        private _319_4_КурьяковDataSetTableAdapters.ФакультетTableAdapter факультетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерфакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}