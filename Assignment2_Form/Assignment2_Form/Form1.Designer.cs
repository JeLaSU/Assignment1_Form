
namespace Assignment2_Form
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
            this.lblscore = new System.Windows.Forms.Label();
            this.write_box = new System.Windows.Forms.TextBox();
            this.lblopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.word1 = new System.Windows.Forms.Label();
            this.word2 = new System.Windows.Forms.Label();
            this.word3 = new System.Windows.Forms.Label();
            this.word4 = new System.Windows.Forms.Label();
            this.word5 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_Condition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(689, 330);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(75, 22);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "Score: 0";
            this.lblscore.Click += new System.EventHandler(this.lbl_score);
            // 
            // write_box
            // 
            this.write_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.write_box.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write_box.Location = new System.Drawing.Point(579, 254);
            this.write_box.Name = "write_box";
            this.write_box.Size = new System.Drawing.Size(324, 48);
            this.write_box.TabIndex = 3;
            this.write_box.TextChanged += new System.EventHandler(this.write_Box);
            // 
            // lblopen
            // 
            this.lblopen.Location = new System.Drawing.Point(495, 8);
            this.lblopen.Name = "lblopen";
            this.lblopen.Size = new System.Drawing.Size(75, 23);
            this.lblopen.TabIndex = 4;
            this.lblopen.Text = "Open File";
            this.lblopen.UseVisualStyleBackColor = true;
            this.lblopen.Click += new System.EventHandler(this.btn_open);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(576, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File:";
            this.label2.Click += new System.EventHandler(this.lbl_file);
            // 
            // word1
            // 
            this.word1.AutoSize = true;
            this.word1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.word1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1.Location = new System.Drawing.Point(16, 11);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(58, 21);
            this.word1.TabIndex = 6;
            this.word1.Tag = "";
            this.word1.Text = "word1";
            this.word1.Click += new System.EventHandler(this.lbl_word1);
            // 
            // word2
            // 
            this.word2.AutoSize = true;
            this.word2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.word2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2.Location = new System.Drawing.Point(99, 11);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(58, 21);
            this.word2.TabIndex = 7;
            this.word2.Text = "word2";
            this.word2.Click += new System.EventHandler(this.lbl_word2);
            // 
            // word3
            // 
            this.word3.AutoSize = true;
            this.word3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.word3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word3.Location = new System.Drawing.Point(187, 10);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(58, 21);
            this.word3.TabIndex = 8;
            this.word3.Text = "word3";
            this.word3.Click += new System.EventHandler(this.lbl_word3);
            // 
            // word4
            // 
            this.word4.AutoSize = true;
            this.word4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.word4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word4.Location = new System.Drawing.Point(290, 10);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(58, 21);
            this.word4.TabIndex = 9;
            this.word4.Text = "word4";
            this.word4.Click += new System.EventHandler(this.lbl_word4);
            // 
            // word5
            // 
            this.word5.AutoSize = true;
            this.word5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.word5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word5.Location = new System.Drawing.Point(388, 10);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(58, 21);
            this.word5.TabIndex = 10;
            this.word5.Text = "word5";
            this.word5.Click += new System.EventHandler(this.lbl_word5);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(483, 254);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 28);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(483, 288);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(90, 23);
            this.btn_stop.TabIndex = 12;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_Condition
            // 
            this.lbl_Condition.AutoSize = true;
            this.lbl_Condition.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Condition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Condition.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Condition.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Condition.Location = new System.Drawing.Point(107, 176);
            this.lbl_Condition.Name = "lbl_Condition";
            this.lbl_Condition.Size = new System.Drawing.Size(226, 63);
            this.lbl_Condition.TabIndex = 13;
            this.lbl_Condition.Text = "You Lose";
            this.lbl_Condition.Click += new System.EventHandler(this.lbl_condition);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.lbl_Condition);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.word5);
            this.Controls.Add(this.word4);
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblopen);
            this.Controls.Add(this.write_box);
            this.Controls.Add(this.lblscore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.TextBox write_box;
        private System.Windows.Forms.Button lblopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label word1;
        private System.Windows.Forms.Label word2;
        private System.Windows.Forms.Label word3;
        private System.Windows.Forms.Label word4;
        private System.Windows.Forms.Label word5;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_Condition;
    }
}

