using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Animation : Form
    {
        public Animation()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Animation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
                label2.Text = progressBar1.Value.ToString() + " %";

            }

            else
            {
                timer1.Stop();
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();

            }
        }
    }
}
