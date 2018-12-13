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
    public partial class menu : Form
    {
        int count = 0;
        public menu()
        {
            InitializeComponent();
        }

        private void ex_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //выход из игры
        }

        private void btnlev_Click(object sender, EventArgs e)
        {
            this.Visible = false;//форма становиться невидимой
            lvl1 mylvl1;
            mylvl1 = new lvl1();
            mylvl1.ShowDialog(); //переход к первому уровню
            count += mylvl1.itog;
            mylvl1.Dispose();//при закрытии второй формы основная форма становиться видимой 
            this.Visible = true;
            btnlev.Enabled = false;
            proverca();//это фцнкция будет проверять количество очков для вывода финальной формы
        }

        private void btnprav_Click(object sender, EventArgs e)
        {
            this.Visible = false;//при закрытии второй формы основная форма становиться видимой 
            lvl2 mylvl2;
            mylvl2 = new lvl2();
            mylvl2.ShowDialog();//переход ко втророму уровню
            count += mylvl2.itog;
            mylvl2.Dispose();
            this.Visible = true;
            btnprav.Enabled = false;
            proverca();//это фцнкция будет проверять количество очков для вывода финальной формы
        }

        public void proverca()//функция проверки
        {
            if (count >= 50)
            {

                this.Visible = false;
                rezyltat myrezyltat;
                myrezyltat = new rezyltat();
                //заносим в финальную форму данные о победе и количесво очков 
                myrezyltat.lbltxt1.Text = "Молодец!!Ты прошел игру аленький цветочек!!";
                myrezyltat.lbltxt2.Text = "У тебя " + count.ToString() + " баллов";
                SoundPlayer aa = new SoundPlayer(Properties.Resources.fanfare1);
                aa.Play();//а также при открытие формы играет музыка
                myrezyltat.ShowDialog();
                myrezyltat.Dispose();//когда игрок хочет начать заново, он переходив главное меню
                this.Visible = true;
                btnprav.Enabled = true;
                btnlev.Enabled = true;
                count = 0;//количество его итоговых баллов обнуляется 
            }
            else//появляеться кнопка что бы начать игру заново
            {
                btnzanovo.Visible = true;
            }
        }

        private void btnzanovo_Click(object sender, EventArgs e)
        {
            btnlev.Enabled = true;//при нажатии на эту кнопку игрок сможет начать игру заново
            btnprav.Enabled = true;
            count = 0;
        }
    }
}
