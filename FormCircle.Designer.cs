namespace ProjectGeometry
{
    partial class FormCircle
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
            label1 = new Label();
            label2 = new Label();
            btnArea = new Button();
            btnCircumference = new Button();
            btnClearCircle = new Button();
            btnBackToMenu = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 99);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "RADIUS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 1;
            label2.Text = "RESULT:";
            // 
            // btnArea
            // 
            btnArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArea.Location = new Point(131, 170);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(115, 33);
            btnArea.TabIndex = 2;
            btnArea.Text = "AREA";
            btnArea.UseVisualStyleBackColor = true;
            // 
            // btnCircumference
            // 
            btnCircumference.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCircumference.Location = new Point(282, 170);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(123, 33);
            btnCircumference.TabIndex = 3;
            btnCircumference.Text = "CIRCUMFERENCE";
            btnCircumference.UseVisualStyleBackColor = true;
            // 
            // btnClearCircle
            // 
            btnClearCircle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCircle.Location = new Point(131, 227);
            btnClearCircle.Name = "btnClearCircle";
            btnClearCircle.Size = new Size(115, 34);
            btnClearCircle.TabIndex = 4;
            btnClearCircle.Text = "CLEAR";
            btnClearCircle.UseVisualStyleBackColor = true;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMenu.Location = new Point(282, 227);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(123, 34);
            btnBackToMenu.TabIndex = 5;
            btnBackToMenu.Text = "BACK TO MENU";
            btnBackToMenu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 52);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 9);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 0;
            label3.Text = "CIRCLE";
            label3.Click += label3_Click;
            // 
            // FormCircle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(515, 450);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnClearCircle);
            Controls.Add(btnCircumference);
            Controls.Add(btnArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCircle";
            Text = "Circle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnArea;
        private Button btnCircumference;
        private Button btnClearCircle;
        private Button btnBackToMenu;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label3;
    }
}