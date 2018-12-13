using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class lvl1 : Form
    {
        Random rnd = new Random();//случайное число
        int shet = 0;//это число будет счтиать сколько картинок нашли
        public int itog = 0; //это число будет считать количество баллов
        public lvl1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            //выход из уровня
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажми кнопку'Cтарт'и найди 10 листочков.\r\nОдин найденный листочек - 10 баллов,промах - минус 10 баллов.\r\nИспользование подсказки стоит 20 баллов.\r\nА также ты можешь начать уровень заново, но очки обнулятся\r\nУдачи!", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //правило уровня
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnllev1.Controls.Clear();//очищаем список, останавлиаем таймер и обнуляем очки
            timer1.Stop();
            prgbar.Value = 0;
            lblrez.Text = "0 из  10";
            btnstart1.Enabled = false;
            timer1.Start();//запуск таймера
            for (int i = 1; i <= 10; i++) //раскидывает картинки по панели
            {
                PictureBox zel = new PictureBox();
                zel.Name = "zel" + i.ToString();
                zel.Width = 25;
                zel.Height = 25;
                zel.SizeMode = PictureBoxSizeMode.Zoom;
                zel.BackColor = Color.Transparent;
                int tip = rnd.Next(1, 3);//выбор картинки для разбораса по панели 
               
                if (tip == 1)//разброс светлого листочка
                {
                    zel.Left = rnd.Next(pnllev1.Width - 30);//записываем по какой части поля будет разбрасываться листок
                    zel.Top = rnd.Next(300, 450);
                    zel.Image = Properties.Resources.listlight;
                    pnllev1.Controls.Add(zel);
                }
                else//разброс светлого листочка
                {
                    zel.Left = rnd.Next(500, 750);//записываем по какой части поля будет разбрасываться листок
                    zel.Top = rnd.Next(0, 400);
                    zel.Image = Properties.Resources.listdark;
                    pnllev1.Controls.Add(zel);

                }
                zel.Click += new System.EventHandler(this.zel_Click);
             
            }
        }
        private void zel_Click(object sender, EventArgs e)
        {
            PictureBox nn = (PictureBox)sender;
            nn.Visible = false;//кнопка старт в этот момент игры будет не доступна
            shet++;//считаем количество найденных листков
            lblrez.Text = shet.ToString() + " из  10"; //показывает сколько найдено листков
            itog = itog + 10;//подсчет баллов
            if (shet == 10)//если пользователь нашел все 10 листочов, то появляеться окно с победой и игра начинается заново
            {
                SoundPlayer aa = new SoundPlayer(Properties.Resources.звукпобеды);
                aa.Play();
                timer1.Stop();
                MessageBox.Show("Молодец!!!\r\nУ тебя " + itog.ToString() + " баллов.", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
             }
        }
        private void button1_Click(object sender, EventArgs e)//подсказка
        {
            foreach (PictureBox pict in pnllev1.Controls) 
            {
                pict.BorderStyle = BorderStyle.Fixed3D;//изменяем вид картинок 
            }
            itog = itog - 20;//за использование подсказки у игрока вычитаеться 20 очков
        }



        private void timer1_Tick(object sender, EventArgs e)//управление таймером
        {
            prgbar.Value += 1;
            if (prgbar.Value == prgbar.Maximum)
            {
                timer1.Stop();//остановка таймера
                MessageBox.Show("Прости, но время вышло :(\r\nУ тебя " + itog.ToString() + " баллов.", "Тик-так", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void pmllev1_Click(object sender, EventArgs e)//промах игрока
        {
            itog = itog - 10;
            MessageBox.Show("Промах!!\r\n-10 баллов", "Будь внимательней!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnzak_Click(object sender, EventArgs e)//если игрока не устраивает прохождение, он может наччать заново
        {
            timer1.Stop();
            MessageBox.Show("У тебя " + itog.ToString() + " баллов.", "Как хочешь..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pnllev1.Controls.Clear();//очищаем список, останавлиаем таймер и обнуляем очки
            prgbar.Value = 0;
            btnstart1.Enabled = true;
            itog = 0;
            lblrez.Text = "0 из  10";
        }


    }
}
