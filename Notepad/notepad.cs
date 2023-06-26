using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Notepad
{
    public partial class notepad : Form
    {
        public notepad()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2TextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        public void SaveFile()
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc|HTML Document|*.html|Cascading Stylesheet|*.css|Javascript|*.js|Personal Homepage|*.php|Python|*.py|C Language|*.c|C Plus Plus|*.cpp|C Sharp|*.cs";
            DialogResult dr = saveFileDialog1.ShowDialog();
            try
            {
                if (string.IsNullOrEmpty(guna2TextBox1.Text))
                {
                    if (dr == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, guna2TextBox1.Text);
                    }
                }
            }
            catch
            {
               MessageBox.Show("File is Empty ! Write Some Data", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();

            }   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(guna2TextBox1.Text, guna2TextBox1.Font, Brushes.Black, 100, 100); 
        }

        private void guna2GradientButton18_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void guna2GradientButton19_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Cut();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            string cp = guna2TextBox1.Text;
            cp.Clone();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Paste();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            guna2TextBox1.SelectAll();
        }

        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {

            guna2TextBox1.Text = guna2TextBox1.Text + DateTime.Now.ToString();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2TextBox1.Font = fontDialog1.Font;
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2TextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void guna2GradientButton16_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Undo();
        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Modified == true)
            {

                DialogResult dr = MessageBox.Show("Do you want to save the file before exiting", "unsaved file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    SaveFile();

                    guna2TextBox1.Modified = false;

                    Application.Exit();

                }

            }
            else
            {
                guna2TextBox1.Modified = false;

                this.Close();
            }
        }

        private void notepad_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton17_Click(object sender, EventArgs e)
        {
            guna2TextBox1.WordWrap = true;
        }

        
    }
}
