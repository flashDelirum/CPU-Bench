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
        int score = 0;
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
            //prime number test

            Stopwatch w = new Stopwatch();
            w.Start();
            for (int i = 2; i < 100000; i++)
                for (int x = i - 1; x > 1; x--)
                    if (i % x == 0)
                        break;
            w.Stop();

            score = (int)w.ElapsedMilliseconds;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            result_label.Text = "" + 100000000 / score;
            result_panel.BringToFront();
        }
    }
}
