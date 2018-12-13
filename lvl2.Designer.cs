namespace WindowsFormsApplication1
{
    partial class lvl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lvl2));
            this.pnlzadanie = new System.Windows.Forms.Panel();
            this.btnstart2 = new System.Windows.Forms.Button();
            this.btnpodkaz = new System.Windows.Forms.Button();
            this.btnex3 = new System.Windows.Forms.Button();
            this.btnvoprosik = new System.Windows.Forms.Button();
            this.pnllev2 = new System.Windows.Forms.Panel();
            this.lblrez2 = new System.Windows.Forms.Label();
            this.btnzan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlzadanie
            // 
            this.pnlzadanie.Location = new System.Drawing.Point(12, 508);
            this.pnlzadanie.Name = "pnlzadanie";
            this.pnlzadanie.Size = new System.Drawing.Size(530, 77);
            this.pnlzadanie.TabIndex = 1;
            // 
            // btnstart2
            // 
            this.btnstart2.BackColor = System.Drawing.Color.Maroon;
            this.btnstart2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstart2.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart2.ForeColor = System.Drawing.Color.Transparent;
            this.btnstart2.Location = new System.Drawing.Point(548, 507);
            this.btnstart2.Name = "btnstart2";
            this.btnstart2.Size = new System.Drawing.Size(75, 35);
            this.btnstart2.TabIndex = 2;
            this.btnstart2.Text = "Start";
            this.btnstart2.UseVisualStyleBackColor = false;
            this.btnstart2.Click += new System.EventHandler(this.btnstart2_Click);
            // 
            // btnpodkaz
            // 
            this.btnpodkaz.BackColor = System.Drawing.Color.Sienna;
            this.btnpodkaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpodkaz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpodkaz.Location = new System.Drawing.Point(635, 550);
            this.btnpodkaz.Name = "btnpodkaz";
            this.btnpodkaz.Size = new System.Drawing.Size(75, 35);
            this.btnpodkaz.TabIndex = 3;
            this.btnpodkaz.Text = "Пдсказка";
            this.btnpodkaz.UseVisualStyleBackColor = false;
            this.btnpodkaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnex3
            // 
            this.btnex3.BackColor = System.Drawing.Color.Maroon;
            this.btnex3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnex3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnex3.Location = new System.Drawing.Point(716, 551);
            this.btnex3.Name = "btnex3";
            this.btnex3.Size = new System.Drawing.Size(75, 33);
            this.btnex3.TabIndex = 4;
            this.btnex3.Text = "Выход";
            this.btnex3.UseVisualStyleBackColor = false;
            this.btnex3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnvoprosik
            // 
            this.btnvoprosik.BackColor = System.Drawing.Color.LightCoral;
            this.btnvoprosik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvoprosik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvoprosik.Location = new System.Drawing.Point(761, 511);
            this.btnvoprosik.Name = "btnvoprosik";
            this.btnvoprosik.Size = new System.Drawing.Size(30, 28);
            this.btnvoprosik.TabIndex = 5;
            this.btnvoprosik.Text = "?";
            this.btnvoprosik.UseVisualStyleBackColor = false;
            this.btnvoprosik.Click += new System.EventHandler(this.btnvoprosik_Click);
            // 
            // pnllev2
            // 
            this.pnllev2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.komnata;
            this.pnllev2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnllev2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnllev2.Location = new System.Drawing.Point(-3, -4);
            this.pnllev2.Name = "pnllev2";
            this.pnllev2.Size = new System.Drawing.Size(805, 509);
            this.pnllev2.TabIndex = 0;
            this.pnllev2.Click += new System.EventHandler(this.pnllev2_Click);
            // 
            // lblrez2
            // 
            this.lblrez2.AutoSize = true;
            this.lblrez2.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrez2.Location = new System.Drawing.Point(629, 508);
            this.lblrez2.Name = "lblrez2";
            this.lblrez2.Size = new System.Drawing.Size(119, 34);
            this.lblrez2.TabIndex = 1;
            this.lblrez2.Text = "0 из 10";
            // 
            // btnzan
            // 
            this.btnzan.BackColor = System.Drawing.Color.Brown;
            this.btnzan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnzan.Location = new System.Drawing.Point(548, 550);
            this.btnzan.Name = "btnzan";
            this.btnzan.Size = new System.Drawing.Size(75, 35);
            this.btnzan.TabIndex = 0;
            this.btnzan.Text = "Заново";
            this.btnzan.UseVisualStyleBackColor = false;
            this.btnzan.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(801, 594);
            this.Controls.Add(this.lblrez2);
            this.Controls.Add(this.btnvoprosik);
            this.Controls.Add(this.btnzan);
            this.Controls.Add(this.btnex3);
            this.Controls.Add(this.btnpodkaz);
            this.Controls.Add(this.btnstart2);
            this.Controls.Add(this.pnlzadanie);
            this.Controls.Add(this.pnllev2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lvl2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комната волшебника ";
            this.Load += new System.EventHandler(this.lvl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnllev2;
        private System.Windows.Forms.Label lblrez2;
        private System.Windows.Forms.Panel pnlzadanie;
        private System.Windows.Forms.Button btnstart2;
        private System.Windows.Forms.Button btnpodkaz;
        private System.Windows.Forms.Button btnex3;
        private System.Windows.Forms.Button btnvoprosik;
        private System.Windows.Forms.Button btnzan;

    }
}