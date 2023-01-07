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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ego kirac=new ego();
            vlcControl1.Play(new Uri(kirac.eat(@"C:\Users\user\Desktop\ma sahneler\kıraç yemek.mp4")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ego kirac = new ego();
            vlcControl1.Play(new Uri(kirac.eat(@"C:\Users\user\Desktop\ma sahneler\sosyal.mp4")));

        }
    }
}
