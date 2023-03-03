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
    public partial class client : Form
    {
        public client()
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
            one main_open = new one();
            main_open.Show();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            UIComp.alerts("Заполните все поля!", alerts.enmType.Danger);
        }
    }
}
