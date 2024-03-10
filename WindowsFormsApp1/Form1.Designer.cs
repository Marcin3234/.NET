namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.przetasuj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.ruchy = new System.Windows.Forms.Label();
            this.gbZdjecie = new System.Windows.Forms.GroupBox();
            this.czasy = new System.Windows.Forms.Timer(this.components);
            this.czas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(836, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pauza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wznowienie);
            // 
            // przetasuj
            // 
            this.przetasuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.przetasuj.Location = new System.Drawing.Point(681, 473);
            this.przetasuj.Name = "przetasuj";
            this.przetasuj.Size = new System.Drawing.Size(91, 33);
            this.przetasuj.TabIndex = 1;
            this.przetasuj.Text = "przetasuj";
            this.przetasuj.UseVisualStyleBackColor = true;
            this.przetasuj.Click += new System.EventHandler(this.przetasuj_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(950, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "wyłącz grę";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbx1);
            this.groupBox1.Controls.Add(this.pbx2);
            this.groupBox1.Controls.Add(this.pbx3);
            this.groupBox1.Controls.Add(this.pbx4);
            this.groupBox1.Controls.Add(this.pbx5);
            this.groupBox1.Controls.Add(this.pbx6);
            this.groupBox1.Controls.Add(this.pbx7);
            this.groupBox1.Controls.Add(this.pbx8);
            this.groupBox1.Controls.Add(this.pbx9);
            this.groupBox1.Location = new System.Drawing.Point(63, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puzzle";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(20, 19);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(132, 119);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(150, 19);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(140, 119);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(288, 19);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(134, 119);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(20, 138);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(132, 123);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 3;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(150, 138);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(140, 123);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 4;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(288, 138);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(133, 123);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 5;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(20, 259);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(132, 121);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 6;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(150, 259);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(140, 121);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 7;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(288, 259);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(134, 121);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 8;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.ZmianaPictureBox);
            // 
            // ruchy
            // 
            this.ruchy.AutoSize = true;
            this.ruchy.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ruchy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ruchy.Location = new System.Drawing.Point(80, 473);
            this.ruchy.Name = "ruchy";
            this.ruchy.Size = new System.Drawing.Size(159, 33);
            this.ruchy.TabIndex = 4;
            this.ruchy.Text = "Ilość ruchów: ";
            this.ruchy.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbZdjecie
            // 
            this.gbZdjecie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbZdjecie.BackgroundImage")));
            this.gbZdjecie.Location = new System.Drawing.Point(681, 61);
            this.gbZdjecie.Name = "gbZdjecie";
            this.gbZdjecie.Size = new System.Drawing.Size(400, 400);
            this.gbZdjecie.TabIndex = 5;
            this.gbZdjecie.TabStop = false;
            this.gbZdjecie.Text = "zdjecie";
            // 
            // czasy
            // 
            this.czasy.Enabled = true;
            this.czasy.Interval = 90;
            this.czasy.Tick += new System.EventHandler(this.reset_czasu);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.czas.Location = new System.Drawing.Point(542, 236);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(120, 31);
            this.czas.TabIndex = 6;
            this.czas.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(676, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oto zdjęcie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1150, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.gbZdjecie);
            this.Controls.Add(this.ruchy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.przetasuj);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button przetasuj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.Label ruchy;
        private System.Windows.Forms.GroupBox gbZdjecie;
        private System.Windows.Forms.Timer czasy;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}

