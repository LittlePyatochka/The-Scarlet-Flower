namespace WindowsFormsApplication1
{
    partial class rezyltat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezyltat));
            this.btnzakonpr = new System.Windows.Forms.Button();
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.btninfo = new System.Windows.Forms.Button();
            this.lbltxt2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnzakonpr
            // 
            this.btnzakonpr.BackColor = System.Drawing.Color.Khaki;
            this.btnzakonpr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzakonpr.Location = new System.Drawing.Point(53, 12);
            this.btnzakonpr.Name = "btnzakonpr";
            this.btnzakonpr.Size = new System.Drawing.Size(187, 34);
            this.btnzakonpr.TabIndex = 0;
            this.btnzakonpr.Text = "Играть заново";
            this.btnzakonpr.UseVisualStyleBackColor = false;
            this.btnzakonpr.Click += new System.EventHandler(this.btnzakonpr_Click);
            // 
            // lbltxt1
            // 
            this.lbltxt1.AutoSize = true;
            this.lbltxt1.BackColor = System.Drawing.Color.Transparent;
            this.lbltxt1.ForeColor = System.Drawing.Color.Yellow;
            this.lbltxt1.Location = new System.Drawing.Point(50, 132);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(0, 13);
            this.lbltxt1.TabIndex = 1;
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninfo.Location = new System.Drawing.Point(53, 52);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(188, 34);
            this.btninfo.TabIndex = 2;
            this.btninfo.Text = "Информация об авторе ";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // lbltxt2
            // 
            this.lbltxt2.AutoSize = true;
            this.lbltxt2.BackColor = System.Drawing.Color.Transparent;
            this.lbltxt2.ForeColor = System.Drawing.Color.Yellow;
            this.lbltxt2.Location = new System.Drawing.Point(50, 170);
            this.lbltxt2.Name = "lbltxt2";
            this.lbltxt2.Size = new System.Drawing.Size(0, 13);
            this.lbltxt2.TabIndex = 3;
            // 
            // rezyltat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(303, 206);
            this.Controls.Add(this.lbltxt2);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.lbltxt1);
            this.Controls.Add(this.btnzakonpr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rezyltat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Победа!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnzakonpr;
        private System.Windows.Forms.Button btninfo;
        public System.Windows.Forms.Label lbltxt1;
        public System.Windows.Forms.Label lbltxt2;
    }
}