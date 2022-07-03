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
    public partial class Авторизация : Form
    {
        int idu=1;
        public Авторизация()
        {
            InitializeComponent();
        }


        private void Авторизация_Load(object sender, EventArgs e)
        {

        }

        private void Pass_Click(object sender, EventArgs e)
        {
            Pass.Text = "";
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex == 0 && Pass.Text.ToString() == "111")
            {
                Главная_форма main = new Главная_форма(0);
                main.Show();
                this.Visible = false;
            }
            else if (NameList.SelectedIndex == 1 && Pass.Text.ToString() == "222")
            {
                Главная_форма main = new Главная_форма(idu);
                main.Show();
                this.Visible = false;
            }
            else if (NameList.SelectedIndex == 2 && Pass.Text.ToString() == "333")
            {
                Главная_форма main = new Главная_форма(0);
                main.Show();
                this.Visible = false;
            }
            else if (NameList.SelectedIndex == 3 && Pass.Text.ToString() == "444")
            {
                Главная_форма main = new Главная_форма(0);
                main.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Не верный пароль!");
            }
        }

    }
}
