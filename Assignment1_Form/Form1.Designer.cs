namespace Assignment1_Form
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
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnMp3Stop = new System.Windows.Forms.Button();
            this.lblNOW = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmp3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnDisplayStop = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRotStop = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.panTriangle = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.Hits = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 71);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(88, 71);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMp3Stop
            // 
            this.btnMp3Stop.Location = new System.Drawing.Point(169, 71);
            this.btnMp3Stop.Name = "btnMp3Stop";
            this.btnMp3Stop.Size = new System.Drawing.Size(75, 23);
            this.btnMp3Stop.TabIndex = 2;
            this.btnMp3Stop.Text = "Stop";
            this.btnMp3Stop.UseVisualStyleBackColor = true;
            this.btnMp3Stop.Click += new System.EventHandler(this.btnMp3Stop_Click);
            // 
            // lblNOW
            // 
            this.lblNOW.AutoSize = true;
            this.lblNOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOW.Location = new System.Drawing.Point(128, 16);
            this.lblNOW.Name = "lblNOW";
            this.lblNOW.Size = new System.Drawing.Size(120, 20);
            this.lblNOW.TabIndex = 3;
            this.lblNOW.Text = "Now Playing...";
            this.lblNOW.Click += new System.EventHandler(this.lblNOW_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Audio Files(*.wav ; *.mp3)|*.wav; *.mp3";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblmp3);
            this.groupBox1.Controls.Add(this.lblNOW);
            this.groupBox1.Controls.Add(this.btnMp3Stop);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Music Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loaded Audio File:";
            // 
            // lblmp3
            // 
            this.lblmp3.AutoSize = true;
            this.lblmp3.Location = new System.Drawing.Point(115, 44);
            this.lblmp3.Name = "lblmp3";
            this.lblmp3.Size = new System.Drawing.Size(16, 13);
            this.lblmp3.TabIndex = 4;
            this.lblmp3.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblClock);
            this.groupBox2.Controls.Add(this.btnDisplayStop);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 269);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Thread";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(29, 102);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(159, 39);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClock.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDisplayStop
            // 
            this.btnDisplayStop.Location = new System.Drawing.Point(135, 226);
            this.btnDisplayStop.Name = "btnDisplayStop";
            this.btnDisplayStop.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayStop.TabIndex = 2;
            this.btnDisplayStop.Text = "Stop";
            this.btnDisplayStop.UseVisualStyleBackColor = true;
            this.btnDisplayStop.Click += new System.EventHandler(this.btnDisplayStop_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(10, 226);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(121, 23);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Start Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRotStop);
            this.groupBox3.Controls.Add(this.btnRotate);
            this.groupBox3.Controls.Add(this.panTriangle);
            this.groupBox3.Location = new System.Drawing.Point(240, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 269);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Triangle Thread";
            // 
            // btnRotStop
            // 
            this.btnRotStop.Location = new System.Drawing.Point(135, 225);
            this.btnRotStop.Name = "btnRotStop";
            this.btnRotStop.Size = new System.Drawing.Size(75, 23);
            this.btnRotStop.TabIndex = 2;
            this.btnRotStop.Text = "Stop";
            this.btnRotStop.UseVisualStyleBackColor = true;
            this.btnRotStop.Click += new System.EventHandler(this.btnRotStop_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(10, 225);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(121, 23);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = "Start Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // panTriangle
            // 
            this.panTriangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTriangle.Location = new System.Drawing.Point(10, 19);
            this.panTriangle.Name = "panTriangle";
            this.panTriangle.Size = new System.Drawing.Size(200, 200);
            this.panTriangle.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.txtHits);
            this.groupBox4.Controls.Add(this.Hits);
            this.groupBox4.Controls.Add(this.btnGo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbSkill);
            this.groupBox4.Location = new System.Drawing.Point(468, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 375);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Catch Me";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hit Image with Mouse";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(19, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 283);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(233, 42);
            this.txtHits.Name = "txtHits";
            this.txtHits.ReadOnly = true;
            this.txtHits.Size = new System.Drawing.Size(71, 20);
            this.txtHits.TabIndex = 4;
            // 
            // Hits
            // 
            this.Hits.AutoSize = true;
            this.Hits.Location = new System.Drawing.Point(244, 21);
            this.Hits.Name = "Hits";
            this.Hits.Size = new System.Drawing.Size(25, 13);
            this.Hits.TabIndex = 3;
            this.Hits.Text = "Hits";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(129, 41);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skill";
            // 
            // cmbSkill
            // 
            this.cmbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSkill.Location = new System.Drawing.Point(19, 41);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(61, 21);
            this.cmbSkill.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(803, 399);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple thread demonstator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnMp3Stop;
        private System.Windows.Forms.Label lblNOW;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblmp3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplayStop;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRotStop;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Panel panTriangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.Label Hits;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
    }
}

