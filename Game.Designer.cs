namespace _98Cards
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btnundo = new System.Windows.Forms.Button();
            this.pnlboard = new System.Windows.Forms.Panel();
            this.lblbrd6 = new System.Windows.Forms.Label();
            this.lblbrd7 = new System.Windows.Forms.Label();
            this.lblbrd5 = new System.Windows.Forms.Label();
            this.lblbrd8 = new System.Windows.Forms.Label();
            this.lblbrd4 = new System.Windows.Forms.Label();
            this.lblbrd3 = new System.Windows.Forms.Label();
            this.lblbrd2 = new System.Windows.Forms.Label();
            this.lblbrd1 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblpileup1 = new System.Windows.Forms.Label();
            this.lblpileup2 = new System.Windows.Forms.Label();
            this.lblpiledwn1 = new System.Windows.Forms.Label();
            this.lblpiledwn2 = new System.Windows.Forms.Label();
            this.pnlpile = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcardsleft = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlboard.SuspendLayout();
            this.pnlpile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnundo
            // 
            this.btnundo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnundo.Location = new System.Drawing.Point(591, 105);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 46);
            this.btnundo.TabIndex = 13;
            this.btnundo.Text = "Undo";
            this.btnundo.UseVisualStyleBackColor = true;
            this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
            // 
            // pnlboard
            // 
            this.pnlboard.Controls.Add(this.lblbrd6);
            this.pnlboard.Controls.Add(this.lblbrd7);
            this.pnlboard.Controls.Add(this.lblbrd5);
            this.pnlboard.Controls.Add(this.lblbrd8);
            this.pnlboard.Controls.Add(this.lblbrd4);
            this.pnlboard.Controls.Add(this.lblbrd3);
            this.pnlboard.Controls.Add(this.lblbrd2);
            this.pnlboard.Controls.Add(this.lblbrd1);
            this.pnlboard.Location = new System.Drawing.Point(35, 279);
            this.pnlboard.Name = "pnlboard";
            this.pnlboard.Size = new System.Drawing.Size(665, 202);
            this.pnlboard.TabIndex = 14;
            this.pnlboard.Click += new System.EventHandler(this.Game_Click);
            // 
            // lblbrd6
            // 
            this.lblbrd6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd6.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd6.Location = new System.Drawing.Point(201, 117);
            this.lblbrd6.Name = "lblbrd6";
            this.lblbrd6.Size = new System.Drawing.Size(45, 70);
            this.lblbrd6.TabIndex = 16;
            this.lblbrd6.Tag = "6";
            this.lblbrd6.Text = "label1";
            this.lblbrd6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd6.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd7
            // 
            this.lblbrd7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd7.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd7.Location = new System.Drawing.Point(344, 117);
            this.lblbrd7.Name = "lblbrd7";
            this.lblbrd7.Size = new System.Drawing.Size(45, 70);
            this.lblbrd7.TabIndex = 16;
            this.lblbrd7.Tag = "7";
            this.lblbrd7.Text = "label1";
            this.lblbrd7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd7.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd5
            // 
            this.lblbrd5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd5.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd5.Location = new System.Drawing.Point(73, 117);
            this.lblbrd5.Name = "lblbrd5";
            this.lblbrd5.Size = new System.Drawing.Size(45, 70);
            this.lblbrd5.TabIndex = 16;
            this.lblbrd5.Tag = "5";
            this.lblbrd5.Text = "label1";
            this.lblbrd5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd5.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd8
            // 
            this.lblbrd8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd8.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd8.Location = new System.Drawing.Point(492, 117);
            this.lblbrd8.Name = "lblbrd8";
            this.lblbrd8.Size = new System.Drawing.Size(45, 70);
            this.lblbrd8.TabIndex = 16;
            this.lblbrd8.Tag = "8";
            this.lblbrd8.Text = "label1";
            this.lblbrd8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd8.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd4
            // 
            this.lblbrd4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd4.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd4.Location = new System.Drawing.Point(492, 28);
            this.lblbrd4.Name = "lblbrd4";
            this.lblbrd4.Size = new System.Drawing.Size(45, 70);
            this.lblbrd4.TabIndex = 16;
            this.lblbrd4.Tag = "4";
            this.lblbrd4.Text = "label1";
            this.lblbrd4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd4.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd3
            // 
            this.lblbrd3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd3.Location = new System.Drawing.Point(344, 28);
            this.lblbrd3.Name = "lblbrd3";
            this.lblbrd3.Size = new System.Drawing.Size(45, 70);
            this.lblbrd3.TabIndex = 16;
            this.lblbrd3.Tag = "3";
            this.lblbrd3.Text = "label1";
            this.lblbrd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd3.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd2
            // 
            this.lblbrd2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd2.Location = new System.Drawing.Point(201, 28);
            this.lblbrd2.Name = "lblbrd2";
            this.lblbrd2.Size = new System.Drawing.Size(45, 70);
            this.lblbrd2.TabIndex = 16;
            this.lblbrd2.Tag = "2";
            this.lblbrd2.Text = "label1";
            this.lblbrd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd2.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblbrd1
            // 
            this.lblbrd1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblbrd1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrd1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbrd1.Location = new System.Drawing.Point(73, 28);
            this.lblbrd1.Name = "lblbrd1";
            this.lblbrd1.Size = new System.Drawing.Size(45, 70);
            this.lblbrd1.TabIndex = 16;
            this.lblbrd1.Tag = "1";
            this.lblbrd1.Text = "label1";
            this.lblbrd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbrd1.Click += new System.EventHandler(this.lblbrd_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(137, 48);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(28, 32);
            this.lblscore.TabIndex = 15;
            this.lblscore.Text = "0";
            // 
            // lblpileup1
            // 
            this.lblpileup1.BackColor = System.Drawing.Color.Gray;
            this.lblpileup1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpileup1.Location = new System.Drawing.Point(43, 18);
            this.lblpileup1.Name = "lblpileup1";
            this.lblpileup1.Size = new System.Drawing.Size(45, 70);
            this.lblpileup1.TabIndex = 16;
            this.lblpileup1.Tag = "0";
            this.lblpileup1.Text = "1";
            this.lblpileup1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpileup1.Click += new System.EventHandler(this.lblpile_Click);
            // 
            // lblpileup2
            // 
            this.lblpileup2.BackColor = System.Drawing.Color.Gray;
            this.lblpileup2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpileup2.Location = new System.Drawing.Point(158, 18);
            this.lblpileup2.Name = "lblpileup2";
            this.lblpileup2.Size = new System.Drawing.Size(45, 70);
            this.lblpileup2.TabIndex = 18;
            this.lblpileup2.Tag = "1";
            this.lblpileup2.Text = "1";
            this.lblpileup2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpileup2.Click += new System.EventHandler(this.lblpile_Click);
            // 
            // lblpiledwn1
            // 
            this.lblpiledwn1.BackColor = System.Drawing.Color.Gray;
            this.lblpiledwn1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpiledwn1.Location = new System.Drawing.Point(43, 134);
            this.lblpiledwn1.Name = "lblpiledwn1";
            this.lblpiledwn1.Size = new System.Drawing.Size(45, 70);
            this.lblpiledwn1.TabIndex = 16;
            this.lblpiledwn1.Tag = "2";
            this.lblpiledwn1.Text = "100";
            this.lblpiledwn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpiledwn1.Click += new System.EventHandler(this.lblpile_Click);
            // 
            // lblpiledwn2
            // 
            this.lblpiledwn2.BackColor = System.Drawing.Color.Gray;
            this.lblpiledwn2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpiledwn2.Location = new System.Drawing.Point(158, 134);
            this.lblpiledwn2.Name = "lblpiledwn2";
            this.lblpiledwn2.Size = new System.Drawing.Size(45, 70);
            this.lblpiledwn2.TabIndex = 16;
            this.lblpiledwn2.Tag = "3";
            this.lblpiledwn2.Text = "100";
            this.lblpiledwn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpiledwn2.Click += new System.EventHandler(this.lblpile_Click);
            // 
            // pnlpile
            // 
            this.pnlpile.Controls.Add(this.pictureBox4);
            this.pnlpile.Controls.Add(this.pictureBox3);
            this.pnlpile.Controls.Add(this.pictureBox2);
            this.pnlpile.Controls.Add(this.pictureBox1);
            this.pnlpile.Controls.Add(this.lblpileup2);
            this.pnlpile.Controls.Add(this.lblpiledwn2);
            this.pnlpile.Controls.Add(this.lblpiledwn1);
            this.pnlpile.Controls.Add(this.lblpileup1);
            this.pnlpile.Location = new System.Drawing.Point(213, 30);
            this.pnlpile.Name = "pnlpile";
            this.pnlpile.Size = new System.Drawing.Size(249, 225);
            this.pnlpile.TabIndex = 20;
            this.pnlpile.Click += new System.EventHandler(this.Game_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(209, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 30);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(2, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 30);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(209, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblcardsleft
            // 
            this.lblcardsleft.AutoSize = true;
            this.lblcardsleft.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcardsleft.Location = new System.Drawing.Point(137, 86);
            this.lblcardsleft.Name = "lblcardsleft";
            this.lblcardsleft.Size = new System.Drawing.Size(42, 32);
            this.lblcardsleft.TabIndex = 21;
            this.lblcardsleft.Text = "98";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cards Left:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcardsleft);
            this.Controls.Add(this.pnlpile);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.pnlboard);
            this.Controls.Add(this.btnundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "98 Cards";
            this.Click += new System.EventHandler(this.Game_Click);
            this.pnlboard.ResumeLayout(false);
            this.pnlpile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnundo;
        private System.Windows.Forms.Panel pnlboard;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblpileup1;
        private System.Windows.Forms.Label lblpileup2;
        private System.Windows.Forms.Label lblbrd6;
        private System.Windows.Forms.Label lblbrd7;
        private System.Windows.Forms.Label lblbrd5;
        private System.Windows.Forms.Label lblbrd8;
        private System.Windows.Forms.Label lblbrd4;
        private System.Windows.Forms.Label lblbrd3;
        private System.Windows.Forms.Label lblbrd2;
        private System.Windows.Forms.Label lblbrd1;
        private System.Windows.Forms.Label lblpiledwn1;
        private System.Windows.Forms.Label lblpiledwn2;
        private System.Windows.Forms.Panel pnlpile;
        private System.Windows.Forms.Label lblcardsleft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

