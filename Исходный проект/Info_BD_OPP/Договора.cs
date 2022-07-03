using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_BD_OPP
{
    public partial class Договора : Form
    {
        public Договора()
        {
            InitializeComponent();
        }

        private void ДоговораBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договораBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPPDBDataSet);

        }

        private void Договора_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPPDBDataSet.Договора". При необходимости она может быть перемещена или удалена.
            this.договораTableAdapter.Fill(this.oPPDBDataSet.Договора);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Добавить_договор form = new Добавить_договор();
            form.Show();
        }

        private void Договора_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bindingNavigatorDeleteItem.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
