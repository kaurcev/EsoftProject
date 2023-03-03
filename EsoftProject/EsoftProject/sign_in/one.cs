using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject.sign_in
{
    public partial class one : Form
    {
        public one()
        {
            InitializeComponent();

        }

        private void step_one_Load(object sender, EventArgs e)
        {
            borderradius();
        }

        void borderradius()
        {
            this.Region = new Region(
                UIComp.RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height)
                    , 10
                )
            );
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome main_open = new welcome();
            main_open.Show();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            if(r_buttons1.Checked)
            {
                this.Close();
                client main_open = new client();
                main_open.Show();
            }
            else if(r_buttons2.Checked)
            {
                this.Close();
                agent main_open = new agent();
                main_open.Show();
            }
            else
            {
                UIComp.alerts("Вы не указали кто вы", alerts.enmType.Alert);
            }
        }
    }
}
