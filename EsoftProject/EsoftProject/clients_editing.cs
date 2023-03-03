using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace EsoftProject
{
    public partial class clients_editing : Form
    {
        public static int code { set; get; }
        public clients_editing()
        {
            InitializeComponent();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            if (UIComp.textcheck(inputs1.Texts) && UIComp.textcheck(inputs2.Texts) && UIComp.textcheck(inputs3.Texts) && (UIComp.textcheck(inputs4.Texts) || UIComp.textcheck(inputs5.Texts)))
            {
                error_color();
                texterorr_off();
            }
            else
            {

                error_color();
                texterorr_on();
            }
        }

        private void inputs1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void inputs2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void inputs3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void inputs4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
               
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void clients_editing_Load(object sender, EventArgs e)
        {
            if (code != -1)
            {
                DataTable dataTable = DataBase.fromDB($"select * from Клиенты where _id = '{code}'");
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    inputs1.Texts = dataTable.Rows[i][1].ToString();
                    inputs2.Texts = dataTable.Rows[i][2].ToString();
                    inputs3.Texts = dataTable.Rows[i][3].ToString();
                    inputs4.Texts = dataTable.Rows[i][4].ToString();
                    inputs5.Texts = dataTable.Rows[i][5].ToString();
                }
            } else
            {
      
            }
        }

        private void inputs5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        void texterorr_on()
        {
            error_log.Text = "Не все поля заполнены";
            error_log.Visible = true;
        }

        void texterorr_off()
        {
            error_log.Visible = false;
        }

        void error_color()
        {

        }
    }
}
