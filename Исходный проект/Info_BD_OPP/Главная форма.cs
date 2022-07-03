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
    public partial class Главная_форма : Form
    {
        int roleu;
        public Главная_форма(int idu)
        {
            roleu = idu;
            InitializeComponent();
        }

        private void Главная_форма_Load(object sender, EventArgs e)
        {
            if (roleu == 1)
            {
                Users.Visible = true;
            }
        }

        private void Per_Click(object sender, EventArgs e)
        {
            Перевозчики per = new Перевозчики();
            per.Show();
        }

        private void Главная_форма_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Dog_Click(object sender, EventArgs e)
        {
            Договора dogo = new Договора();
            dogo.Show();
        }

        private void Kar_Click(object sender, EventArgs e)
        {
            Карточки_маршрутов form = new Карточки_маршрутов();
            form.Show();
        }

        private void Rasp_Click(object sender, EventArgs e)
        {
            Расписания form = new Расписания();
            form.Show();
        }

        private void Car_Click(object sender, EventArgs e)
        {
            Транспортные_средства form = new Транспортные_средства();
            form.Show();
        }

        private void Rei_Click(object sender, EventArgs e)
        {
            Рейды form = new Рейды();
            form.Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Пользователи form = new Пользователи();
            form.Show();
        }
    }
}
