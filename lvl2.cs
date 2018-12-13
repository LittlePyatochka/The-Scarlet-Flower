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
    public partial class lvl2 : Form
    {
        Random rnd = new Random();//случайное число
        List<string> mylist = new List<string>();//содаем облачный список для названий всех картинок 
        List<string> myris = new List<string>();//содаем облачный список для названий картинок, которые будут на экране
        List<string> myword = new List<string>();//создаем облачный список для слов которые будут находиться на панеле 
        List<string> myword2 = new List<string>();//создаем облачный список для слов которы будут на экане, но не будут упомянуты в задании 
        int chet = 0;//это число будет считать количество найденных предметов
        public int itog = 0;//это число будет считать сколько баллов набрал пользователь 
        int kol = 0;
        List<Color> mycolor = new List<Color>();
        public lvl2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//клик по кнопке "выход"
        {
            this.Dispose();

            //выход из уровня
        }

        private void btnvoprosik_Click(object sender, EventArgs e)//клик по кнопке "?"
        {
            MessageBox.Show("Нажми кнопку'Cтарт'и найди 10 предметов,указанныхъ внизу.\r\nОдин найденный предмет - 10 баллов,промах - минус 10 баллов.\r\nИспользование подсказки стоит 20 баллов.\r\nА также ты можешь начать уровень заново, но очки обнулятся\r\nУдачи!", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //правило уровня 
        }

        private void lvl2_Load(object sender, EventArgs e)
        {
            mylist.Add("шляпа"); //заносим все слова, которые будут в игре (19 слов)
            mylist.Add("книга");
            mylist.Add("шар");
            mylist.Add("яблоко");
            mylist.Add("очки");
            mylist.Add("зелье");
            mylist.Add("сапоги");
            mylist.Add("кольцо");
            mylist.Add("зеркало");
            mylist.Add("ручка");
            mylist.Add("мешок");
            mylist.Add("огниво");
            mylist.Add("перо");
            mylist.Add("клубок");
            mylist.Add("мышь");
            mylist.Add("ластик");
            mylist.Add("конфета");
            mylist.Add("часы");
            mylist.Add("заколка");
        }

        private void btnstart2_Click(object sender, EventArgs e)
        {
            itog = 0;
            btnstart2.Enabled = false;
            int rr = 0;
            string myw = "";//это слово будет искаться в облачных списках
            for (int i = 0; i < 10; i++)//определение случайных слов для задания
            {
                do
                {
                    rr = rnd.Next(0, 19);
                    myw = mylist[rr];
                } while (myword.Contains(myw));//проверка на повторение слов в списке
                myword.Add(myw);
                myris.Add(myw);
            }
            for (int i = 0; i < 4; i++)//добавляем еще 4 слова для усложнения уровня
            {
                do
                {
                    rr = rnd.Next(0, 19);
                    myw = mylist[rr];
                } while (myris.Contains(myw));//проверка на повторение слов в списке
                myword2.Add(myw);
                myris.Add(myw);
            }


            Font myfont = new Font("Segoe Print", 13, FontStyle.Regular);

            int x = 0, y = 0;
            for (int i = 1; i <= 2; i++)//запись загаданных слов в палель
            {
                for (int k = 1; k <= 5; k++)
                {
                    Label lbl = new Label();
                    kol++;
                    lbl.Name = "lbl" + kol.ToString();
                    lbl.Left = x;//определяем как слова будут распределяться по панели 
                    x += 105;
                    lbl.Top = y;
                    lbl.Height = 50;
                    lbl.Text = myword[kol - 1];
                    lbl.Tag = lbl.Text;
                    Color col = new Color();
                    do
                    {
                        col = Color.FromArgb(rnd.Next(225), rnd.Next(225), rnd.Next(225));



                    } while (mycolor.Contains(col));
                    mycolor.Add(col);
                    lbl.ForeColor = col;




                    lbl.Font = myfont;//устанавливаем шрифт и размер слов в панеле с заданием
                    pnlzadanie.Controls.Add(lbl);

                }
                x = 0;
                y += 38;
            }

            for (int i = 0; i < 14; i++) //этот цикл раскидвает картинки по панели 
            {

                PictureBox zel = new PictureBox();
                zel.Name = "zel" + i.ToString();//определяем название и размеры картинок
                zel.Width = 35;
                zel.Height = 35;
                zel.SizeMode = PictureBoxSizeMode.Zoom;
                zel.BackColor = Color.Transparent;
                zel.Left = rnd.Next(pnllev2.Width - 30);//описываем по какой части панели картинку будут разбрасываться 
                zel.Top = rnd.Next(pnllev2.Height - 30);
                string rm = myris[i];
                zel.Tag = rm;
                object mypic = Properties.Resources.ResourceManager.GetObject(rm);
                zel.Image = (Bitmap)mypic;
                pnllev2.Controls.Add(zel);//добавляем на случайно место напели картинку
                zel.Click += new System.EventHandler(this.zel_Click);

            }

        }


        private void zel_Click(object sender, EventArgs e)//клик по картинки
        {
            PictureBox nn = (PictureBox)sender;
            if (myword.Contains(nn.Tag.ToString()))
            {
                chet++;
                lblrez2.Text = chet.ToString() + " из  10"; //показывает сколько найдено предметов  
                itog += 10;
            }
            else
            {
                itog = itog - 10;
                MessageBox.Show("Промах!!Смотри список слов!\r\n-10 баллов", "Будь внимательней!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            foreach (Label rrr in pnlzadanie.Controls)//в этом цикле идет проверка по тэгу для того что бы зачеркнуть нужное слово в панели задания
            {
                if (rrr.Tag == nn.Tag)
                {
                    nn.Visible = false;
                    Font fn = new Font("Segoe Print", 13, FontStyle.Strikeout);//зачеркиваем найденое слово
                    rrr.Font = fn;

                    Color col2 = new Color();
                    do
                    {
                        col2 = Color.FromArgb(rnd.Next(225), rnd.Next(225), rnd.Next(225));



                    } while (mycolor.Contains(col2));
                    mycolor.Add(col2);
                    rrr.ForeColor = col2;
                }
            }
            if (chet == 10)//если игрок нашел все предметы, появляется  MessageBox и играет музыка
            {
                SoundPlayer aa = new SoundPlayer(Properties.Resources.звукпобеды);
                aa.Play();
                MessageBox.Show("Молодец!!!\r\nУ тебя " + itog.ToString() + " баллов.", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnllev2.Controls.Clear();//очищение панели с картинками
                btnstart2.Enabled = true;
                lblrez2.Text = "0 из  10";
                pnlzadanie.Controls.Clear();//очищение панели задания
                myword.Clear();
                myris.Clear();
                myword2.Clear();
                kol = 0;
                chet = 0;
                this.Dispose();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            itog -= 20;//за использование подсказки вычетаеться 20 баллов


            foreach (PictureBox rrr in pnllev2.Controls)//подсказка
            {
                if (myword.Contains(rrr.Tag.ToString()))
                {

                    rrr.BorderStyle = BorderStyle.Fixed3D;//изменяем вид графического объекта

                }
            }
        }



        private void pnllev2_Click(object sender, EventArgs e)
        {
            itog = itog - 10;//вычетаем баллы за промах
            MessageBox.Show("Промах!!Смотри список слов!\r\n-10 баллов", "Будь внимательней!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)//игрок может начать прохождение данного уровня заново
        {
            MessageBox.Show("У тебя " + itog.ToString() + " баллов.", "Как хочешь..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pnllev2.Controls.Clear();//очищение панели с картинками
            btnstart2.Enabled = true;
            itog = 0;
            lblrez2.Text = "0 из  10";
            pnlzadanie.Controls.Clear();//очищение панели задания
            myword.Clear();
            myris.Clear();
            myword2.Clear();
            kol = 0;
            chet = 0;
        }
    }
}
