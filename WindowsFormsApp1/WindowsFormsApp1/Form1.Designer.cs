namespace WindowsFormsApp1
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
            this.RTrackBarBackground = new Guna.UI2.WinForms.Guna2TrackBar();
            this.GTrackBarBackground = new Guna.UI2.WinForms.Guna2TrackBar();
            this.BTrackBarBackground = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.RTrackBarFont = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.GTrackBarFont = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.BTrackBarFont = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTrackBarBackground
            // 
            this.RTrackBarBackground.LargeChange = 1;
            this.RTrackBarBackground.Location = new System.Drawing.Point(5, 32);
            this.RTrackBarBackground.Maximum = 255;
            this.RTrackBarBackground.Name = "RTrackBarBackground";
            this.RTrackBarBackground.Size = new System.Drawing.Size(97, 23);
            this.RTrackBarBackground.TabIndex = 5;
            this.RTrackBarBackground.ThumbColor = System.Drawing.Color.Red;
            this.RTrackBarBackground.Value = 27;
            this.RTrackBarBackground.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RTrackBar_Scroll);
            // 
            // GTrackBarBackground
            // 
            this.GTrackBarBackground.LargeChange = 1;
            this.GTrackBarBackground.Location = new System.Drawing.Point(5, 61);
            this.GTrackBarBackground.Maximum = 255;
            this.GTrackBarBackground.Name = "GTrackBarBackground";
            this.GTrackBarBackground.Size = new System.Drawing.Size(97, 23);
            this.GTrackBarBackground.TabIndex = 6;
            this.GTrackBarBackground.ThumbColor = System.Drawing.Color.Red;
            this.GTrackBarBackground.Value = 27;
            this.GTrackBarBackground.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GTrackBar_Scroll);
            // 
            // BTrackBarBackground
            // 
            this.BTrackBarBackground.LargeChange = 1;
            this.BTrackBarBackground.Location = new System.Drawing.Point(5, 90);
            this.BTrackBarBackground.Maximum = 255;
            this.BTrackBarBackground.Name = "BTrackBarBackground";
            this.BTrackBarBackground.Size = new System.Drawing.Size(97, 23);
            this.BTrackBarBackground.TabIndex = 7;
            this.BTrackBarBackground.ThumbColor = System.Drawing.Color.Red;
            this.BTrackBarBackground.Value = 27;
            this.BTrackBarBackground.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "27";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "27";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "27";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.RTrackBarBackground);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.GTrackBarBackground);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.BTrackBarBackground);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(133, 125);
            this.guna2Panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Background Color";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.RTrackBarFont);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.GTrackBarFont);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.BTrackBarFont);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Location = new System.Drawing.Point(151, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(133, 125);
            this.guna2Panel2.TabIndex = 12;
            // 
            // RTrackBarFont
            // 
            this.RTrackBarFont.LargeChange = 1;
            this.RTrackBarFont.Location = new System.Drawing.Point(5, 32);
            this.RTrackBarFont.Maximum = 255;
            this.RTrackBarFont.Name = "RTrackBarFont";
            this.RTrackBarFont.Size = new System.Drawing.Size(97, 23);
            this.RTrackBarFont.TabIndex = 5;
            this.RTrackBarFont.ThumbColor = System.Drawing.Color.Red;
            this.RTrackBarFont.Value = 255;
            this.RTrackBarFont.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "255";
            // 
            // GTrackBarFont
            // 
            this.GTrackBarFont.LargeChange = 1;
            this.GTrackBarFont.Location = new System.Drawing.Point(5, 61);
            this.GTrackBarFont.Maximum = 255;
            this.GTrackBarFont.Name = "GTrackBarFont";
            this.GTrackBarFont.Size = new System.Drawing.Size(97, 23);
            this.GTrackBarFont.TabIndex = 6;
            this.GTrackBarFont.ThumbColor = System.Drawing.Color.Red;
            this.GTrackBarFont.Value = 255;
            this.GTrackBarFont.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GTrackBarFont_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "255";
            // 
            // BTrackBarFont
            // 
            this.BTrackBarFont.LargeChange = 1;
            this.BTrackBarFont.Location = new System.Drawing.Point(5, 90);
            this.BTrackBarFont.Maximum = 255;
            this.BTrackBarFont.Name = "BTrackBarFont";
            this.BTrackBarFont.Size = new System.Drawing.Size(97, 23);
            this.BTrackBarFont.TabIndex = 7;
            this.BTrackBarFont.ThumbColor = System.Drawing.Color.Red;
            this.BTrackBarFont.Value = 255;
            this.BTrackBarFont.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BTrackBarFont_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Font Color";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(293, 142);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TrackBar RTrackBarBackground;
        private Guna.UI2.WinForms.Guna2TrackBar GTrackBarBackground;
        private Guna.UI2.WinForms.Guna2TrackBar BTrackBarBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TrackBar RTrackBarFont;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TrackBar GTrackBarFont;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TrackBar BTrackBarFont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

