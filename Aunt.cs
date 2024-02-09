using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._09._2001
{
    public partial class Aunt : Form
    {
        bool is_aunt = false;
        private Form1 form1;
        public Aunt(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Aunt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!is_aunt)
            {
                Application.Exit();
            }

        }

        private void Button_Aunt_Click(object sender, EventArgs e)
        {
            string Log = "Моя";
            string Pas = "Зайка";
            if (Pas == Text_Password.Text && Log == Text_Login.Text)
            {
                is_aunt = true;
                form1.KataAunt();
                Close();
            }
            else
            {
                MessageBox.Show("Логин - Моя \nПароль - Зайка", "Ответ прост", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
