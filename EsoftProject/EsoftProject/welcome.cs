using EsoftProject;
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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataBase.fromDB("select * from Клиенты");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][1].ToString() == login_enter.Text && dataTable.Rows[i][2].ToString() == password_enter.Text)
                {
                    login_enter.BorderColor = UIComp.Green;
                    password_enter.BorderColor = UIComp.Green;
                    UIComp.alerts("Успешный вход", alerts.enmType.Success);
                    Thread.Sleep(3000);
                    Form main_open = new clients();
                    main_open.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    if (i+1 == dataTable.Rows.Count)
                    {
                        UIComp.alerts("Ошибка входа", alerts.enmType.Danger);
                    }
                    error_log.Text = "Неправильный пароль или логин";
                    error_log.Visible = true;
                    login_enter.BorderColor = UIComp.Red;
                    password_enter.BorderColor = UIComp.Red;
                    
                }
              
            }
        }

        private void login_enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == '\'' || ch == '\"') 
            {
                e.Handled = true;
                UIComp.alerts("Запрещенный символ", alerts.enmType.Alert);
            }
        }

        private void login_enter_MouseClick(object sender, MouseEventArgs e)
        {
            login_enter.BorderColor = UIComp.Gray;
        }

        private void password_enter_MouseClick(object sender, MouseEventArgs e)
        {
            password_enter.BorderColor = UIComp.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in.one main_open = new sign_in.one();
            main_open.Show();
           
        }

        private void welcome_Load(object sender, EventArgs e)
        {
           
        }

        private void welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
