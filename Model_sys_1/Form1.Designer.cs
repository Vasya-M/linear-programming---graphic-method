namespace Model_sys_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.result_text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drawp = new System.Windows.Forms.Panel();
            this.drawpic = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.drawp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ведіть коефіцієнти цільової ф-ції F(x1,x2)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // X1
            // 
            this.X1.AccessibleDescription = " ";
            this.X1.AccessibleName = "x1";
            this.X1.Location = new System.Drawing.Point(383, 20);
            this.X1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(47, 20);
            this.X1.TabIndex = 1;
            this.X1.Text = "1";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(462, 20);
            this.X2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(47, 20);
            this.X2.TabIndex = 2;
            this.X2.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть кількість обмежень (без x1, x2 >= 0)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // n
            // 
            this.n.AccessibleDescription = " ";
            this.n.AccessibleName = "x1";
            this.n.Location = new System.Drawing.Point(383, 64);
            this.n.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(47, 20);
            this.n.TabIndex = 4;
            this.n.Text = "1";
            this.n.TextChanged += new System.EventHandler(this.n_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(13, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 268);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "  X1      X2     sign     B";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(462, 60);
            this.start.Margin = new System.Windows.Forms.Padding(0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 25);
            this.start.TabIndex = 8;
            this.start.Text = "Вирахувати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // result_text
            // 
            this.result_text.AutoSize = true;
            this.result_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_text.Location = new System.Drawing.Point(3, 0);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(26, 16);
            this.result_text.TabIndex = 9;
            this.result_text.Text = "  x  ";
            this.result_text.Visible = false;
            this.result_text.Click += new System.EventHandler(this.result_text_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.result_text);
            this.panel2.Location = new System.Drawing.Point(277, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 268);
            this.panel2.TabIndex = 10;
            // 
            // drawp
            // 
            this.drawp.AutoScroll = true;
            this.drawp.AutoScrollMinSize = new System.Drawing.Size(587, 237);
            this.drawp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawp.Controls.Add(this.drawpic);
            this.drawp.Location = new System.Drawing.Point(13, 401);
            this.drawp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawp.MaximumSize = new System.Drawing.Size(1110, 1100);
            this.drawp.Name = "drawp";
            this.drawp.Size = new System.Drawing.Size(683, 258);
            this.drawp.TabIndex = 11;
            this.drawp.Paint += new System.Windows.Forms.PaintEventHandler(this.drawp_Paint);
            // 
            // drawpic
            // 
            this.drawpic.BackColor = System.Drawing.SystemColors.Window;
            this.drawpic.Location = new System.Drawing.Point(0, 0);
            this.drawpic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawpic.Name = "drawpic";
            this.drawpic.Size = new System.Drawing.Size(683, 258);
            this.drawpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawpic.TabIndex = 12;
            this.drawpic.TabStop = false;
            this.drawpic.Click += new System.EventHandler(this.drawpic_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(576, 60);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(699, 401);
            this.vScrollBar1.Maximum = 1200;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 258);
            this.vScrollBar1.TabIndex = 13;
            this.vScrollBar1.Value = 600;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(11, 661);
            this.hScrollBar1.Maximum = 1200;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(685, 19);
            this.hScrollBar1.TabIndex = 15;
            this.hScrollBar1.Value = 600;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(541, 66);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = " ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = " ";
            this.AccessibleName = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.drawp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.Text = "Solving optimal control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.drawp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label result_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel drawp;
        private System.Windows.Forms.PictureBox drawpic;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

