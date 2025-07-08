namespace oopdeneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Draw = new Button();
            xrotate = new TextBox();
            yrotate = new TextBox();
            X = new Label();
            length = new TextBox();
            label1 = new Label();
            edge = new TextBox();
            label2 = new Label();
            angel = new TextBox();
            label3 = new Label();
            rotate = new Button();
            reset = new Button();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Draw
            // 
            Draw.Location = new Point(655, 564);
            Draw.Name = "Draw";
            Draw.Size = new Size(182, 33);
            Draw.TabIndex = 0;
            Draw.Text = "draw";
            Draw.UseVisualStyleBackColor = true;
            Draw.Click += Draw_Click;
            // 
            // xrotate
            // 
            xrotate.Location = new Point(740, 37);
            xrotate.Name = "xrotate";
            xrotate.Size = new Size(59, 27);
            xrotate.TabIndex = 1;
            // 
            // yrotate
            // 
            yrotate.Location = new Point(833, 37);
            yrotate.Name = "yrotate";
            yrotate.Size = new Size(59, 27);
            yrotate.TabIndex = 2;
            // 
            // X
            // 
            X.AutoSize = true;
            X.Location = new Point(639, 40);
            X.Name = "X";
            X.Size = new Size(79, 20);
            X.TabIndex = 3;
            X.Text = "Center(x,y)";
            // 
            // length
            // 
            length.Location = new Point(740, 89);
            length.Name = "length";
            length.Size = new Size(152, 27);
            length.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 96);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Length";
            // 
            // edge
            // 
            edge.Location = new Point(719, 346);
            edge.Name = "edge";
            edge.Size = new Size(59, 27);
            edge.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(656, 349);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "Edge";
            // 
            // angel
            // 
            angel.Location = new Point(726, 391);
            angel.Name = "angel";
            angel.Size = new Size(99, 27);
            angel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(656, 394);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 9;
            label3.Text = "Angel";
            // 
            // rotate
            // 
            rotate.Location = new Point(655, 599);
            rotate.Name = "rotate";
            rotate.Size = new Size(182, 33);
            rotate.TabIndex = 10;
            rotate.Text = "rotate";
            rotate.UseVisualStyleBackColor = true;
            rotate.Click += rotate_Click;
            // 
            // reset
            // 
            reset.Location = new Point(655, 634);
            reset.Name = "reset";
            reset.Size = new Size(182, 33);
            reset.TabIndex = 11;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(655, 440);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 104);
            listBox1.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(797, 349);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "CCW";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(676, 148);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(183, 56);
            trackBar1.TabIndex = 14;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(676, 272);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(183, 56);
            trackBar2.TabIndex = 15;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(676, 210);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(183, 56);
            trackBar3.TabIndex = 16;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Location = new Point(30, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 595);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.RegionChanged += Draw_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 148);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 18;
            label4.Text = "Red";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(605, 210);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 19;
            label5.Text = "Green";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 282);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 20;
            label6.Text = "Blue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 680);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(reset);
            Controls.Add(rotate);
            Controls.Add(label3);
            Controls.Add(angel);
            Controls.Add(label2);
            Controls.Add(edge);
            Controls.Add(label1);
            Controls.Add(length);
            Controls.Add(X);
            Controls.Add(yrotate);
            Controls.Add(xrotate);
            Controls.Add(Draw);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Draw;
        private TextBox xrotate;
        private TextBox yrotate;
        private Label X;
        private TextBox length;
        private Label label1;
        private TextBox edge;
        private Label label2;
        private TextBox angel;
        private Label label3;
        private Button rotate;
        private Button reset;
        private ListBox listBox1;
        private CheckBox checkBox1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
