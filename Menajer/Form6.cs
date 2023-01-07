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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peri cinar = new peri();
            vlcControl1.Play(new Uri(cinar.socialize(@"C:\Users\user\Desktop\ma sahneler\sosyal.mp4")));
        }
    }
}
