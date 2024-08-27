namespace ProjectGeometry
{
    partial class FormTriangle
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnBackToMenu = new Button();
            btnClearCircle = new Button();
            btnCircumference = new Button();
            btnArea = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMenu.Location = new Point(292, 246);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(123, 34);
            btnBackToMenu.TabIndex = 13;
            btnBackToMenu.Text = "BACK TO MENU";
            btnBackToMenu.UseVisualStyleBackColor = true;
            // 
            // btnClearCircle
            // 
            btnClearCircle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCircle.Location = new Point(128, 246);
            btnClearCircle.Name = "btnClearCircle";
            btnClearCircle.Size = new Size(115, 34);
            btnClearCircle.TabIndex = 12;
            btnClearCircle.Text = "CLEAR";
            btnClearCircle.UseVisualStyleBackColor = true;
            // 
            // btnCircumference
            // 
            btnCircumference.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCircumference.Location = new Point(292, 186);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(123, 33);
            btnCircumference.TabIndex = 11;
            btnCircumference.Text = "CIRCUMFERENCE";
            btnCircumference.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            btnArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArea.Location = new Point(128, 186);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(115, 33);
            btnArea.TabIndex = 10;
            btnArea.Text = "AREA";
            btnArea.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 107);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 9;
            label2.Text = "RESULT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 105);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 8;
            label1.Text = "RADIUS:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 56);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 0;
            label3.Text = "TRIANGLE";
            label3.Click += label3_Click;
            // 
            // FormTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(543, 450);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnClearCircle);
            Controls.Add(btnCircumference);
            Controls.Add(btnArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTriangle";
            Text = "Triangle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnBackToMenu;
        private Button btnClearCircle;
        private Button btnCircumference;
        private Button btnArea;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}