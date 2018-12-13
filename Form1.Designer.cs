namespace WindowsFormsApplication1
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnlev = new System.Windows.Forms.Button();
            this.btnprav = new System.Windows.Forms.Button();
            this.ex = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnzanovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пройди по тропам \r\nволшебной страны и \r\nполучить в награду \r\nАленький цветочек\r\n";
            // 
            // btnlev
            // 
            this.btnlev.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnlev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlev.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnlev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlev.Location = new System.Drawing.Point(12, 148);
            this.btnlev.Name = "btnlev";
            this.btnlev.Size = new System.Drawing.Size(110, 61);
            this.btnlev.TabIndex = 1;
            this.btnlev.Text = "Налево пойдешь, \r\nв лес попадешь ";
            this.btnlev.UseVisualStyleBackColor = false;
            this.btnlev.Click += new System.EventHandler(this.btnlev_Click);
            // 
            // btnprav
            // 
            this.btnprav.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnprav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprav.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnprav.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnprav.Location = new System.Drawing.Point(366, 148);
            this.btnprav.Name = "btnprav";
            this.btnprav.Size = new System.Drawing.Size(110, 61);
            this.btnprav.TabIndex = 2;
            this.btnprav.Text = "Направо пойдешь, в дом попадешь\r\n";
            this.btnprav.UseVisualStyleBackColor = false;
            this.btnprav.Click += new System.EventHandler(this.btnprav_Click);
            // 
            // ex
            // 
            this.ex.BackColor = System.Drawing.Color.LightBlue;
            this.ex.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ex.Location = new System.Drawing.Point(207, 339);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(53, 25);
            this.ex.TabIndex = 11;
            this.ex.Text = "Выход\r\n";
            this.ex.UseVisualStyleBackColor = false;
            this.ex.Click += new System.EventHandler(this.ex_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.kotik;
            this.pictureBox1.Location = new System.Drawing.Point(12, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.flover;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(363, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 97);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnzanovo
            // 
            this.btnzanovo.BackColor = System.Drawing.Color.MediumBlue;
            this.btnzanovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnzanovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnzanovo.Location = new System.Drawing.Point(12, 9);
            this.btnzanovo.Name = "btnzanovo";
            this.btnzanovo.Size = new System.Drawing.Size(75, 23);
            this.btnzanovo.TabIndex = 14;
            this.btnzanovo.Text = "Заново";
            this.btnzanovo.UseVisualStyleBackColor = false;
            this.btnzanovo.Visible = false;
            this.btnzanovo.Click += new System.EventHandler(this.btnzanovo_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 389);
            this.Controls.Add(this.btnzanovo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.btnprav);
            this.Controls.Add(this.btnlev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аленький цветочек";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnlev;
        public System.Windows.Forms.Button btnprav;
        private System.Windows.Forms.Button btnzanovo;
    }
}

