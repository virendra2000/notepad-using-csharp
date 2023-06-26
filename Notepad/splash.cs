using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            myprog.Value = startpos;
            if (myprog.Value == 2)
            {
                guna2HtmlLabel2.Text = "Starting ...";
            }
            guna2HtmlLabel2.Text = "Loading "+ startpos + "%";
            if (myprog.Value == 100)
            {
                startpos = 100;
                myprog.Value = 0;
                timer1.Stop();
                var notepad = new notepad();
                this.Hide();
                notepad.Show();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
