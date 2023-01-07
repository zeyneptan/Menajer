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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zeyna feris=new zeyna();
            vlcControl1.Play(new Uri(feris.eat(@"C:\Users\user\Desktop\ma sahneler\feris yemek.mp4")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zeyna feris = new zeyna();
            vlcControl1.Play(new Uri(feris.socialize(@"C:\Users\user\Desktop\ma sahneler\sosyal.mp4")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zeyna feris = new zeyna();
            vlcControl1.Play(new Uri(feris.cry(@"C:\Users\user\Desktop\ma sahneler\feris ağlamak.mp4")));
        }
    }
}
