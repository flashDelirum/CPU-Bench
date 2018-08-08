using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CPU__Bench
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_panel.BringToFront();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            load_panel.BringToFront();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //test to be done
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Random r = new Random();
            result_label.Text = "" + r.Next(1000, 9999);
            result_panel.BringToFront();
        }
    }
}
