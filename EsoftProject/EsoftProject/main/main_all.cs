using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject.main
{
    public partial class main_all : Form
    {
        public main_all()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
        }

        void borderradius()
        {
            this.Region = new Region(
                UIComp.RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height)
                    , 3
                )
            );
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome main_open = new welcome();
            main_open.Show();
          
        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            agent_panel panelka = new agent_panel();
            panel2.Controls.Add(panelka);
            borderradius();
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            potreb_panel panelka = new potreb_panel();
            panel2.Controls.Add(panelka);
            borderradius();
        }
    }
}
