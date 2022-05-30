namespace WindowsFormsApp1
{
    partial class Form4
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
            this.кодспециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеспециальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._319_4_КурьяковDataSet = new WindowsFormsApp1._319_4_КурьяковDataSet();
            this.специальностьTableAdapter = new WindowsFormsApp1._319_4_КурьяковDataSetTableAdapters.СпециальностьTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_4_КурьяковDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодспециальностиDataGridViewTextBoxColumn,
            this.названиеспециальностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.специальностьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодспециальностиDataGridViewTextBoxColumn
            // 
            this.кодспециальностиDataGridViewTextBoxColumn.DataPropertyName = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn.HeaderText = "Код_специальности";
            this.кодспециальностиDataGridViewTextBoxColumn.Name = "кодспециальностиDataGridViewTextBoxColumn";
            this.кодспециальностиDataGridViewTextBoxColumn.Width = 134;
            // 
            // названиеспециальностиDataGridViewTextBoxColumn
            // 
            this.названиеспециальностиDataGridViewTextBoxColumn.DataPropertyName = "Название_специальности";
            this.названиеспециальностиDataGridViewTextBoxColumn.HeaderText = "Название_специальности";
            this.названиеспециальностиDataGridViewTextBoxColumn.Name = "названиеспециальностиDataGridViewTextBoxColumn";
            this.названиеспециальностиDataGridViewTextBoxColumn.Width = 165;
            // 
            // специальностьBindingSource
            // 
            this.специальностьBindingSource.DataMember = "Специальность";
            this.специальностьBindingSource.DataSource = this._319_4_КурьяковDataSet;
            // 
            // _319_4_КурьяковDataSet
            // 
            this._319_4_КурьяковDataSet.DataSetName = "_319_4_КурьяковDataSet";
            this._319_4_КурьяковDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // специальностьTableAdapter
            // 
            this.специальностьTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(386, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Специальность";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._319_4_КурьяковDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _319_4_КурьяковDataSet _319_4_КурьяковDataSet;
        private System.Windows.Forms.BindingSource специальностьBindingSource;
        private _319_4_КурьяковDataSetTableAdapters.СпециальностьTableAdapter специальностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеспециальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}