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
    public partial class Рейды : Form
    {
        public Рейды()
        {
            InitializeComponent();
        }

        private void РейдыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейдыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPPDBDataSet);

        }

        private void Рейды_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPPDBDataSet.Рейды". При необходимости она может быть перемещена или удалена.
            this.рейдыTableAdapter.Fill(this.oPPDBDataSet.Рейды);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Добавить_рейд form = new Добавить_рейд();
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
