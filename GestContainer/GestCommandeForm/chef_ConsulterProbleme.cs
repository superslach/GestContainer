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
    public partial class chef_ConsulterProbleme : Form
    {
        public chef_ConsulterProbleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new menu_Chef()));
            t.Start();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new chef_Inspection()));
            t.Start();
            this.Close();
        }

        private void chef_ConsulterProbleme_Load(object sender, EventArgs e)
        {

        }
    }
}
