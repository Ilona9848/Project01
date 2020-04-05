using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project01DataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "project01DataBaseDataSet.Main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.project01DataBaseDataSet.Main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "project01DataBaseDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.project01DataBaseDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "project0DataBaseDataSet.Main". При необходимости она может быть перемещена или удалена.
            this.mainTableAdapter.Fill(this.project01DataBaseDataSet.Main);
            studentsDataGridView.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < studentsDataGridView.RowCount - 1; a++)
            {
                this.mainTableAdapter.Insert(DateTime.Now, new Guid("6c31cc1e-e147-478e-b5f2-194fd96c2b92"), true);
            }
        }
    }
}
