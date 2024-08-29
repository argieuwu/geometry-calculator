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
            TbtnResult = new TextBox();
            TbtnBase = new TextBox();
            btnBackToMenu = new Button();
            btnClearCircle = new Button();
            btnPerimeter = new Button();
            btnArea = new Button();
            label2 = new Label();
            txtBase = new Label();
            panel1 = new Panel();
            label3 = new Label();
            TbtnHeight = new TextBox();
            txtHeight = new Label();
            btnHeight = new Button();
            btnGamma = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TbtnResult
            // 
            TbtnResult.Enabled = false;
            TbtnResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TbtnResult.Location = new Point(206, 96);
            TbtnResult.Name = "TbtnResult";
            TbtnResult.Size = new Size(160, 33);
            TbtnResult.TabIndex = 15;
            TbtnResult.TextChanged += textBox2_TextChanged;
            // 
            // TbtnBase
            // 
            TbtnBase.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbtnBase.Location = new Point(12, 96);
            TbtnBase.Name = "TbtnBase";
            TbtnBase.Size = new Size(160, 33);
            TbtnBase.TabIndex = 14;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMenu.Location = new Point(208, 373);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(160, 40);
            btnBackToMenu.TabIndex = 13;
            btnBackToMenu.Text = "BACK TO MENU";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnClearCircle
            // 
            btnClearCircle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCircle.Location = new Point(12, 373);
            btnClearCircle.Name = "btnClearCircle";
            btnClearCircle.Size = new Size(160, 40);
            btnClearCircle.TabIndex = 12;
            btnClearCircle.Text = "CLEAR";
            btnClearCircle.UseVisualStyleBackColor = true;
            btnClearCircle.Click += btnClearCircle_Click;
            // 
            // btnPerimeter
            // 
            btnPerimeter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerimeter.Location = new Point(208, 229);
            btnPerimeter.Name = "btnPerimeter";
            btnPerimeter.Size = new Size(160, 61);
            btnPerimeter.TabIndex = 11;
            btnPerimeter.Text = "PERIMETER";
            btnPerimeter.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            btnArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArea.Location = new Point(12, 229);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(160, 61);
            btnArea.TabIndex = 10;
            btnArea.Text = "AREA";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 72);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 9;
            label2.Text = "RESULT:";
            // 
            // txtBase
            // 
            txtBase.AutoSize = true;
            txtBase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBase.Location = new Point(12, 72);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(53, 21);
            txtBase.TabIndex = 8;
            txtBase.Text = "BASE:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 56);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 9);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 0;
            label3.Text = "TRIANGLE";
            // 
            // TbtnHeight
            // 
            TbtnHeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbtnHeight.Location = new Point(12, 156);
            TbtnHeight.Name = "TbtnHeight";
            TbtnHeight.Size = new Size(160, 33);
            TbtnHeight.TabIndex = 18;
            // 
            // txtHeight
            // 
            txtHeight.AutoSize = true;
            txtHeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(12, 132);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(72, 21);
            txtHeight.TabIndex = 17;
            txtHeight.Text = "HEIGHT:";
            // 
            // btnHeight
            // 
            btnHeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeight.Location = new Point(12, 296);
            btnHeight.Name = "btnHeight";
            btnHeight.Size = new Size(160, 61);
            btnHeight.TabIndex = 19;
            btnHeight.Text = "HEIGHT";
            btnHeight.UseVisualStyleBackColor = true;
            // 
            // btnGamma
            // 
            btnGamma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGamma.Location = new Point(208, 296);
            btnGamma.Name = "btnGamma";
            btnGamma.Size = new Size(160, 61);
            btnGamma.TabIndex = 20;
            btnGamma.Text = "GAMMA";
            btnGamma.UseVisualStyleBackColor = true;
            // 
            // FormTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(378, 450);
            Controls.Add(btnGamma);
            Controls.Add(btnHeight);
            Controls.Add(TbtnHeight);
            Controls.Add(txtHeight);
            Controls.Add(panel1);
            Controls.Add(TbtnResult);
            Controls.Add(TbtnBase);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnClearCircle);
            Controls.Add(btnPerimeter);
            Controls.Add(btnArea);
            Controls.Add(label2);
            Controls.Add(txtBase);
            Name = "FormTriangle";
            Text = "Triangle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbtnResult;
        private TextBox TbtnBase;
        private Button btnBackToMenu;
        private Button btnClearCircle;
        private Button btnPerimeter;
        private Button btnArea;
        private Label label2;
        private Label txtBase;
        private Panel panel1;
        private Label label3;
        private TextBox TbtnHeight;
        private Label txtHeight;
        private Button btnHeight;
        private Button btnGamma;
    }
}