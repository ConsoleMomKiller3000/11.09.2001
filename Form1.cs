using System.Diagnostics;


namespace _11._09._2001
{
    public partial class Form1 : Form
    {
        public int count = 1;
        public int count_roze = 0;
        private bool is_aunt = false;
        public Form1()
        {
            InitializeComponent();
            Opacity = 0;
            ShowInTaskbar = false;
        }
        public void KataAunt()
        {
            Opacity = 1;
            ShowInTaskbar = true;
            is_aunt = true;
            Activate();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string kod = VVodKod.Text;
            switch (kod)
            {
                case "111":
                    pictureBox_roza.Image = Image.FromFile("E:\\OP\\For 14.02\\L.png");
                    count_roze++;
                    break;
                case "222":
                    pictureBox_roza2.Image = Image.FromFile("E:\\OP\\For 14.02\\O.png");
                    count_roze++;
                    break;
                case "333":
                    pictureBox_roza3.Image = Image.FromFile("E:\\OP\\For 14.02\\V.png");
                    count_roze++;
                    break;
                case "444":
                    pictureBox_roza4.Image = Image.FromFile("E:\\OP\\For 14.02\\E.png");
                    count_roze++;
                    break;
                default:
                    MessageBox.Show("Введи код!", "Кого ты тут хочешь обмануть", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
            if (count_roze == 4)
            {
                button_game.Visible = true;
            }


        }

        private void button_Help_Click_1(object sender, EventArgs e)
        {


            switch (count)
            {
                case 1:
                    count++;
                    MessageBox.Show("1");
                    break;
                case 2:
                    count++;
                    MessageBox.Show("2");

                    break;
                case 3:
                    count++;
                    MessageBox.Show("3");

                    break;
                case 4:
                    count = 1;
                    MessageBox.Show("4");

                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_aunt)
            {
                DialogResult dial = MessageBox.Show("ВЫБЕРИ НЕТ", "ТЫ ЧЁ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dial == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    MessageBox.Show("Не надо так");
                }
            }
        }

        private void button_game_Click(object sender, EventArgs e)
        {
          
            Process.Start("E:\\OP\\Kursach\\WinFormsApp\\WinFormsApp\\bin\\Debug\\net6.0-windows\\WinFormsApp.exe");

        }
    }
}