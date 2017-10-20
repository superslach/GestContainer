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
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new menu_Chef()));
            t.Start();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
