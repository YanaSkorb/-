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
    public partial class Расписания : Form
    {
        public Расписания()
        {
            InitializeComponent();
        }

        private void РасписанияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.расписанияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPPDBDataSet);

        }

        private void Расписания_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPPDBDataSet.Расписания". При необходимости она может быть перемещена или удалена.
            this.расписанияTableAdapter.Fill(this.oPPDBDataSet.Расписания);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Добавить_расписание form = new Добавить_расписание();
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
