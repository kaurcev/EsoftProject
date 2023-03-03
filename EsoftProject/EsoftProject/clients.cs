using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject
{
    public partial class clients : Form
    {
        int code = -1;
        public clients()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void updatetable()
        {
            DataTable dataTable = DataBase.fromDB($"select * from Клиенты");
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["_id"].Visible = false;
            code = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatetable();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            if (inputs1.Texts.Trim() == "")
            {
                texterorr_on();
                updatetable();
            }
            else
            {
                texterorr_off();
                DataTable dataTable = DataBase.fromDB($"select * from Клиенты where Фамилия LIKE '{inputs1.Texts}%' or Имя LIKE '{inputs1.Texts}%' or Отчество LIKE '{inputs1.Texts}%' ");
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["_id"].Visible = false;
            }

        }

        void texterorr_on()
        {
            inputs1.BorderColor = Color.FromArgb(255, 23, 68);
            inputs1.PlaceholderColor = Color.FromArgb(255, 23, 68);
            error_log.Text = "Вы не ввели данные для поиска";
            error_log.Visible = true;
        }

        void texterorr_off()
        {
            inputs1.BorderColor = Color.FromArgb(207, 216, 220);
            inputs1.PlaceholderColor = Color.FromArgb(207, 216, 220);
            error_log.Text = "Вы не ввели данные для поиска";
            error_log.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            code = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void buttons2_MouseHover(object sender, EventArgs e)
        {
            buttons2.BackColor = Color.FromArgb(34, 59, 74);
        }

        private void buttons2_MouseLeave(object sender, EventArgs e)
        {
            buttons2.BackColor = Color.FromArgb(38, 50, 56);
        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            if (code != -1)
            {
                DataBase.toDB($"DELETE FROM Клиенты WHERE _id IN(SELECT _id FROM Клиенты WHERE _id = '{code}')");
                updatetable();
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент");
            }
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            if (code != -1)
            {
                clients_editing.code = code;
                Form open = new clients_editing();
                open.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали элемент");
            }
           
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            clients_editing.code = -1;
            Form open = new clients_editing();
            open.Show();
        }
    }
}
