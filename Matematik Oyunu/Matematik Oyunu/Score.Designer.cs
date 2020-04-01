namespace Matematik_Oyunu
{
    partial class Score
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.listBoxPlus = new System.Windows.Forms.ListBox();
            this.listBoxMinus = new System.Windows.Forms.ListBox();
            this.listBoxDivided = new System.Windows.Forms.ListBox();
            this.listBoxCross = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Panforte Serif", 20F);
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "SKOR  TABLOSU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "SKOR - İSİM";
            this.label1.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.Location = new System.Drawing.Point(650, 423);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 50);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Oyundan Çık";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_score
            // 
            this.btn_score.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_score.Location = new System.Drawing.Point(343, 125);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(75, 100);
            this.btn_score.TabIndex = 16;
            this.btn_score.Text = "Skor Tablosu Göster";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_restart.Location = new System.Drawing.Point(12, 423);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(100, 50);
            this.btn_restart.TabIndex = 17;
            this.btn_restart.Text = "Yeniden Başlat";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // listBoxPlus
            // 
            this.listBoxPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxPlus.FormattingEnabled = true;
            this.listBoxPlus.ItemHeight = 16;
            this.listBoxPlus.Location = new System.Drawing.Point(12, 125);
            this.listBoxPlus.Name = "listBoxPlus";
            this.listBoxPlus.ScrollAlwaysVisible = true;
            this.listBoxPlus.Size = new System.Drawing.Size(180, 292);
            this.listBoxPlus.TabIndex = 15;
            this.listBoxPlus.Visible = false;
            // 
            // listBoxMinus
            // 
            this.listBoxMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxMinus.FormattingEnabled = true;
            this.listBoxMinus.ItemHeight = 16;
            this.listBoxMinus.Location = new System.Drawing.Point(198, 125);
            this.listBoxMinus.Name = "listBoxMinus";
            this.listBoxMinus.ScrollAlwaysVisible = true;
            this.listBoxMinus.Size = new System.Drawing.Size(180, 292);
            this.listBoxMinus.TabIndex = 15;
            this.listBoxMinus.Visible = false;
            // 
            // listBoxDivided
            // 
            this.listBoxDivided.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxDivided.FormattingEnabled = true;
            this.listBoxDivided.ItemHeight = 16;
            this.listBoxDivided.Location = new System.Drawing.Point(384, 125);
            this.listBoxDivided.Name = "listBoxDivided";
            this.listBoxDivided.ScrollAlwaysVisible = true;
            this.listBoxDivided.Size = new System.Drawing.Size(180, 292);
            this.listBoxDivided.TabIndex = 15;
            this.listBoxDivided.Visible = false;
            // 
            // listBoxCross
            // 
            this.listBoxCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxCross.FormattingEnabled = true;
            this.listBoxCross.ItemHeight = 16;
            this.listBoxCross.Location = new System.Drawing.Point(570, 125);
            this.listBoxCross.Name = "listBoxCross";
            this.listBoxCross.ScrollAlwaysVisible = true;
            this.listBoxCross.Size = new System.Drawing.Size(180, 292);
            this.listBoxCross.TabIndex = 15;
            this.listBoxCross.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(194, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "SKOR - İSİM";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(380, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "SKOR - İSİM";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Panforte Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(566, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "SKOR - İSİM";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Panforte Serif", 15F);
            this.label6.Location = new System.Drawing.Point(59, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "TOPLAMA";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Panforte Serif", 15F);
            this.label7.Location = new System.Drawing.Point(249, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "ÇIKARMA";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Panforte Serif", 15F);
            this.label8.Location = new System.Drawing.Point(446, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "BÖLME";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Panforte Serif", 15F);
            this.label9.Location = new System.Drawing.Point(629, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "ÇARPMA";
            this.label9.Visible = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.listBoxCross);
            this.Controls.Add(this.listBoxDivided);
            this.Controls.Add(this.listBoxMinus);
            this.Controls.Add(this.listBoxPlus);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.Button btn_restart;
        public System.Windows.Forms.ListBox listBoxPlus;
        public System.Windows.Forms.ListBox listBoxMinus;
        public System.Windows.Forms.ListBox listBoxDivided;
        public System.Windows.Forms.ListBox listBoxCross;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}