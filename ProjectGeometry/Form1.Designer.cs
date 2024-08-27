namespace ProjectGeometry
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 49);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(140, 71);
            button1.Name = "button1";
            button1.Size = new Size(152, 37);
            button1.TabIndex = 1;
            button1.Text = "CIRCLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(140, 114);
            button2.Name = "button2";
            button2.Size = new Size(152, 37);
            button2.TabIndex = 2;
            button2.Text = "TRIANGLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGoldenrod;
            button3.Location = new Point(140, 157);
            button3.Name = "button3";
            button3.Size = new Size(152, 37);
            button3.TabIndex = 3;
            button3.Text = "RECTANGLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.Location = new Point(140, 200);
            button4.Name = "button4";
            button4.Size = new Size(152, 37);
            button4.TabIndex = 4;
            button4.Text = "SQUARE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCoral;
            button5.Location = new Point(140, 243);
            button5.Name = "button5";
            button5.Size = new Size(152, 37);
            button5.TabIndex = 5;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(411, 351);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Project Geometry";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
