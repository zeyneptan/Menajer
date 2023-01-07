using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menajer
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peri peride = new peri();
            vlcControl1.Play(new Uri(peride.socialize(@"C:\Users\user\Desktop\ma sahneler\sosyal.mp4")));
        }
    }
}
