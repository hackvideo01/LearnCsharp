using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnCSharp
{
    public partial class Form1 : Form
    {
        Timer timer1;
        public Form1()
        {
            InitializeComponent();

            CenterToScreen();
            //this.btnRunStop.Text = "STOP";
            Point locationOnForm = pictureBox1.FindForm().PointToClient(pictureBox1.Parent.PointToScreen(pictureBox1.Location));
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;
        }

        int i = 0;
        int j = 10;
        int x = 0;
        int y = 0;
        string name = "learnCSharp LEt LEar!";
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            j+=10;
           
            int n = name.Length;
            if (i < n)
            {
                this.lbRUNSTOPTEXT.Text += this.name[i].ToString();
            }else if (i>=n) 
            {
                this.lbRUNSTOPTEXT.ResetText();
                i = 0;
            }
            //this.lbRUNSTOPTEXT.Text = i.ToString();
            if (i%2==0)
            {
                // Get current working directory (..\bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // GEt the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                // Create specific path file
                string savePathFile1 = string.Format(@"{0}\images\pngwing.jpg", projectDirectory);

                    Bitmap bm1 = new Bitmap(savePathFile1);

                    this.pictureBox1.Image = bm1;
                    if (x<=0||y<=0)
                    {
                        x += 10;
                        y += 10;
                        this.pictureBox1.Location = new System.Drawing.Point(x, y);
                    }
                    else
                    {
                    x = 280 - j;
                    y = 276 - j;
                    this.pictureBox1.Location = new System.Drawing.Point(x, y);
                    }
                    var leftMostScreen = Screen.AllScreens.OrderBy(s => s.Bounds.Left).First();
                    var left = leftMostScreen.Bounds.Location;
            }
            else
            {
                // Get current working directory (..\bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // GEt the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                // Create specific path file
                string savePathFile2 = string.Format(@"{0}\images\pngwing.com2.png", projectDirectory);

                    Bitmap bm2 = new Bitmap(savePathFile2);

                    this.pictureBox1.Image = bm2;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string name = this.txbName.Text;

            if (this.rdbnt1.Checked == true)
            {
                this.txbResult.Text = name.ToLower();
            }else if (this.rdbnt2.Checked == true)
            {
                this.txbResult.Text = name.ToUpper();
            }
            else
            {
                MessageBox.Show("Checked!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txbResult.Clear();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (this.txbResult.CanUndo == true)
            {
                this.txbResult.Undo();
                this.txbResult.ClearUndo();
            }
        }

        private void btnRunStop_Click(object sender, EventArgs e)
        {
            //if (this.btnRunStop.Text == "STOP")
            //{
            //    this.btnRunStop.Text = "RUN";
            //}
            //else
            //{
            //    this.btnRunStop.Text = "STOP";
            //}


            timer1.Enabled = !timer1.Enabled;
            btnRunStop.Text = btnRunStop.Text == "STOP" ? "STRAT" : "STOP";
        }
    }
}
