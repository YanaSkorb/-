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
    public partial class Карточки_маршрутов : Form
    {
        public Карточки_маршрутов()
        {
            InitializeComponent();
        }

        private void Карточки_маршрутовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.карточки_маршрутовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPPDBDataSet);

        }

        private void Карточки_маршрутов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPPDBDataSet.Карточки_маршрутов". При необходимости она может быть перемещена или удалена.
            this.карточки_маршрутовTableAdapter.Fill(this.oPPDBDataSet.Карточки_маршрутов);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Дабавить_карточку car = new Дабавить_карточку();
                car.Show();
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
