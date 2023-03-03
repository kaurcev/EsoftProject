using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject
{
    public partial class sign_in_client : Form
    {
        private string text = String.Empty;
        public sign_in_client()
        {
            InitializeComponent();
        }
        #region [Капча]

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black
            /* Brushes.Red,
             Brushes.RoyalBlue,
            Brushes.Green */
            };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Segoe Script", 12),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
        #endregion

        private void sign_in_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = this.CreateImage(pictureBox3.Width, pictureBox3.Height);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = this.CreateImage(pictureBox3.Width, pictureBox3.Height);
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            fas();
        }
        #region [Обработчики для определения цвета]
        void fas()
        {
            bool ds = false;
            if (UIComp.textcheck(email_enter.Texts))
            {
                email_enter.BorderColor = UIComp.Green;
            }
            else
            {
                email_enter.BorderColor = UIComp.Red;
                ds = true;
            }
            if (UIComp.textcheck(login_enter.Texts))
            {
                login_enter.BorderColor = UIComp.Green;
            }
            else
            {
                login_enter.BorderColor = UIComp.Red;
                ds = true;
            }
            if (UIComp.textcheck(password_enter.Texts))
            {
                password_enter.BorderColor = UIComp.Green;
            }
            else
            {
                password_enter.BorderColor = UIComp.Red;
                ds = true;
            }
            if (UIComp.textcheck(password2_enter.Texts))
            {
                password2_enter.BorderColor = UIComp.Green;
            }
            else
            {
                password2_enter.BorderColor = UIComp.Red;
                ds = true;
            }
            if (UIComp.textcheck(capcha_enter.Texts))
            {
                capcha_enter.BorderColor = UIComp.Green;
            }
            else
            {
                capcha_enter.BorderColor = UIComp.Red;
                ds = true;
            }
            if (UIComp.textcheck(phone_enter.Texts))
            {
                phone_enter.BorderColor = UIComp.Green;
            }
            else
            {
                phone_enter.BorderColor = UIComp.Red;
                ds = true;
            }

            if (ds)
            {
                error_log.Text = "Не все поля заполнены";
                error_log.Visible = true;
            }
            else
            {
                error_log.Visible = false;
                sig_in();
            }
        }
      

        private void email_enter_MouseClick(object sender, MouseEventArgs e)
        {
            email_enter.BorderColor = UIComp.Gray;
        }

        private void login_enter_MouseClick(object sender, MouseEventArgs e)
        {
            login_enter.BorderColor = UIComp.Gray;
        }

        private void password_enter_MouseClick(object sender, MouseEventArgs e)
        {
            password_enter.BorderColor = UIComp.Gray;
        }

        private void phone_enter_MouseClick(object sender, MouseEventArgs e)
        {
            phone_enter.BorderColor = UIComp.Gray;
        }

        private void capcha_enter_MouseClick(object sender, MouseEventArgs e)
        {
            capcha_enter.BorderColor = UIComp.Gray;
        }

        private void password2_enter_Click(object sender, EventArgs e)
        {
            password2_enter.BorderColor = UIComp.Gray;
        }
        #endregion

        void sig_in()
        {
            // Thread.Sleep(3000);
            UIComp.alerts("Аккаунт создан", alerts.enmType.Success);
            this.Close();
        }
    }
}
