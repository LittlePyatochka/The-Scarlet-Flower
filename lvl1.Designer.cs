namespace WindowsFormsApplication1
{
    partial class lvl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl1));
            this.btnpodskazka = new System.Windows.Forms.Button();
            this.btnstart1 = new System.Windows.Forms.Button();
            this.btnvopros = new System.Windows.Forms.Button();
            this.btnex2 = new System.Windows.Forms.Button();
            this.prgbar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblrez = new System.Windows.Forms.Label();
            this.btnzak = new System.Windows.Forms.Button();
            this.pnllev1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnpodskazka
            // 
            this.btnpodskazka.BackColor = System.Drawing.Color.OliveDrab;
            this.btnpodskazka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpodskazka.Location = new System.Drawing.Point(12, 505);
            this.btnpodskazka.Name = "btnpodskazka";
            this.btnpodskazka.Size = new System.Drawing.Size(75, 23);
            this.btnpodskazka.TabIndex = 1;
            this.btnpodskazka.Text = "Подсказка";
            this.btnpodskazka.UseVisualStyleBackColor = false;
            this.btnpodskazka.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstart1
            // 
            this.btnstart1.BackColor = System.Drawing.Color.YellowGreen;
            this.btnstart1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstart1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart1.Location = new System.Drawing.Point(12, 534);
            this.btnstart1.Name = "btnstart1";
            this.btnstart1.Size = new System.Drawing.Size(75, 34);
            this.btnstart1.TabIndex = 2;
            this.btnstart1.Text = "Start";
            this.btnstart1.UseVisualStyleBackColor = false;
            this.btnstart1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnvopros
            // 
            this.btnvopros.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnvopros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvopros.Location = new System.Drawing.Point(108, 506);
            this.btnvopros.Name = "btnvopros";
            this.btnvopros.Size = new System.Drawing.Size(29, 23);
            this.btnvopros.TabIndex = 3;
            this.btnvopros.Text = "?";
            this.btnvopros.UseVisualStyleBackColor = false;
            this.btnvopros.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnex2
            // 
            this.btnex2.BackColor = System.Drawing.Color.DarkGreen;
            this.btnex2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnex2.Location = new System.Drawing.Point(713, 545);
            this.btnex2.Name = "btnex2";
            this.btnex2.Size = new System.Drawing.Size(75, 23);
            this.btnex2.TabIndex = 4;
            this.btnex2.Text = "Выход";
            this.btnex2.UseVisualStyleBackColor = false;
            this.btnex2.Click += new System.EventHandler(this.button4_Click);
            // 
            // prgbar
            // 
            this.prgbar.Location = new System.Drawing.Point(108, 545);
            this.prgbar.Maximum = 300;
            this.prgbar.Name = "prgbar";
            this.prgbar.Size = new System.Drawing.Size(586, 23);
            this.prgbar.TabIndex = 5;
            this.prgbar.Click += new System.EventHandler(this.zel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblrez
            // 
            this.lblrez.AutoSize = true;
            this.lblrez.Font = new System.Drawing.Font("Brush Script MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrez.Location = new System.Drawing.Point(359, 505);
            this.lblrez.Name = "lblrez";
            this.lblrez.Size = new System.Drawing.Size(86, 29);
            this.lblrez.TabIndex = 7;
            this.lblrez.Text = "0 из 10";
            // 
            // btnzak
            // 
            this.btnzak.BackColor = System.Drawing.Color.LightGreen;
            this.btnzak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzak.ForeColor = System.Drawing.Color.Black;
            this.btnzak.Location = new System.Drawing.Point(713, 506);
            this.btnzak.Name = "btnzak";
            this.btnzak.Size = new System.Drawing.Size(75, 28);
            this.btnzak.TabIndex = 8;
            this.btnzak.Text = "Заново";
            this.btnzak.UseVisualStyleBackColor = false;
            this.btnzak.Click += new System.EventHandler(this.btnzak_Click);
            // 
            // pnllev1
            // 
            this.pnllev1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.les;
            this.pnllev1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnllev1.Location = new System.Drawing.Point(-1, -2);
            this.pnllev1.Name = "pnllev1";
            this.pnllev1.Size = new System.Drawing.Size(803, 502);
            this.pnllev1.TabIndex = 6;
            this.pnllev1.Click += new System.EventHandler(this.pmllev1_Click);
            // 
            // lvl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnzak);
            this.Controls.Add(this.lblrez);
            this.Controls.Add(this.pnllev1);
            this.Controls.Add(this.prgbar);
            this.Controls.Add(this.btnex2);
            this.Controls.Add(this.btnvopros);
            this.Controls.Add(this.btnstart1);
            this.Controls.Add(this.btnpodskazka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lvl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Волшебный лес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpodskazka;
        private System.Windows.Forms.Button btnstart1;
        private System.Windows.Forms.Button btnvopros;
        private System.Windows.Forms.Button btnex2;
        private System.Windows.Forms.ProgressBar prgbar;
        private System.Windows.Forms.Panel pnllev1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblrez;
        private System.Windows.Forms.Button btnzak;
    }
}