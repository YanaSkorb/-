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
    public partial class Пользователи : Form
    {
        public Пользователи()
        {
            InitializeComponent();
        }

        private void ПользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPPDBDataSet);

        }

        private void Пользователи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPPDBDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.oPPDBDataSet.Пользователи);

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

        private void пользователиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
