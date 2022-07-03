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
    public partial class Перевозчики : Form
    {
        public Перевозчики()
        {
            InitializeComponent();
        }

        private void ПеревозчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.перевозчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPPDBDataSet);

        }

        private void Перевозчики_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPPDBDataSet.Перевозчики". При необходимости она может быть перемещена или удалена.
            this.перевозчикиTableAdapter.Fill(this.oPPDBDataSet.Перевозчики);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Добавление_перевозчика form = new Добавление_перевозчика();
            form.Show();
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
