namespace CPU__Bench
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_button = new System.Windows.Forms.Button();
            this.start_panel = new System.Windows.Forms.Panel();
            this.load_panel = new System.Windows.Forms.Panel();
            this.load_picture = new System.Windows.Forms.PictureBox();
            this.result_panel = new System.Windows.Forms.Panel();
            this.result_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.start_panel.SuspendLayout();
            this.load_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_picture)).BeginInit();
            this.result_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Red;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.start_button.Location = new System.Drawing.Point(317, 194);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(161, 56);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // start_panel
            // 
            this.start_panel.BackColor = System.Drawing.Color.Black;
            this.start_panel.Controls.Add(this.start_button);
            this.start_panel.Location = new System.Drawing.Point(0, -1);
            this.start_panel.Name = "start_panel";
            this.start_panel.Size = new System.Drawing.Size(802, 454);
            this.start_panel.TabIndex = 0;
            // 
            // load_panel
            // 
            this.load_panel.BackColor = System.Drawing.Color.Black;
            this.load_panel.Controls.Add(this.load_picture);
            this.load_panel.Location = new System.Drawing.Point(0, 0);
            this.load_panel.Name = "load_panel";
            this.load_panel.Size = new System.Drawing.Size(802, 451);
            this.load_panel.TabIndex = 1;
            // 
            // load_picture
            // 
            this.load_picture.Image = global::CPU__Bench.Properties.Resources.load;
            this.load_picture.Location = new System.Drawing.Point(221, 97);
            this.load_picture.Name = "load_picture";
            this.load_picture.Size = new System.Drawing.Size(351, 233);
            this.load_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.load_picture.TabIndex = 0;
            this.load_picture.TabStop = false;
            // 
            // result_panel
            // 
            this.result_panel.BackColor = System.Drawing.Color.Black;
            this.result_panel.Controls.Add(this.result_label);
            this.result_panel.Location = new System.Drawing.Point(0, 0);
            this.result_panel.Name = "result_panel";
            this.result_panel.Size = new System.Drawing.Size(802, 451);
            this.result_panel.TabIndex = 1;
            // 
            // result_label
            // 
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.Location = new System.Drawing.Point(321, 175);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(129, 41);
            this.result_label.TabIndex = 0;
            this.result_label.Text = "....";
            this.result_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_panel);
            this.Controls.Add(this.load_panel);
            this.Controls.Add(this.result_panel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CPU BENCH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.start_panel.ResumeLayout(false);
            this.load_panel.ResumeLayout(false);
            this.load_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_picture)).EndInit();
            this.result_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Panel start_panel;
        private System.Windows.Forms.Panel load_panel;
        private System.Windows.Forms.PictureBox load_picture;
        private System.Windows.Forms.Panel result_panel;
        private System.Windows.Forms.Label result_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

