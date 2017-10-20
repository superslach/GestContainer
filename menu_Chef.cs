using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GestContainer
{
    public partial class menu_Chef : Form
    {
        public menu_Chef()
        {
            InitializeComponent();
        }

        private void menu_Chef_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new chef_Inspection()));
            t.Start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new chef_ConsulterInspection()));
            t.Start();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new chef_ConsulterProbleme()));
            t.Start();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new connexion()));
            t.Start();
            this.Close();
        }


    }
}
