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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zeyna dicle = new zeyna();
            vlcControl1.Play(new Uri(dicle.socialize((@"C:\Users\user\Desktop\ma sahneler\sosyal.mp4"))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zeyna dicle=new zeyna();
            vlcControl1.Play(new Uri(dicle.eat((@"C:\Users\user\Desktop\ma sahneler\dicle yemek.mp4"))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
           zeyna dicle = new zeyna();
            vlcControl1.Play(new Uri(dicle.cry((@"C:\Users\user\Desktop\ma sahneler\dicle ağlamak.mp4"))));
        }
    }
}
