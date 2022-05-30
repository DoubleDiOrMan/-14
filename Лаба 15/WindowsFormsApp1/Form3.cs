using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3(Form1 f1)
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_4_КурьяковDataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this._319_4_КурьяковDataSet.Факультет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_4_КурьяковDataSet.Успеваемость". При необходимости она может быть перемещена или удалена.
            this.успеваемостьTableAdapter.Fill(this._319_4_КурьяковDataSet.Успеваемость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_4_КурьяковDataSet.Предмет". При необходимости она может быть перемещена или удалена.
            this.предметTableAdapter.Fill(this._319_4_КурьяковDataSet.Предмет);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
