namespace ProjectGeometry
{
    partial class FormSquare
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
            panel1 = new Panel();
            label3 = new Label();
            SbtnResult = new TextBox();
            btnSide = new TextBox();
            btnBackToMenu = new Button();
            btnClearCircle = new Button();
            SbtnDiagonal = new Button();
            SbtnArea = new Button();
            label2 = new Label();
            SbtnSide = new Label();
            SbtnPerimeter = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 56);
            panel1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 9);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 0;
            label3.Text = "SQUARE";
            // 
            // SbtnResult
            // 
            SbtnResult.Enabled = false;
            SbtnResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SbtnResult.Location = new Point(195, 131);
            SbtnResult.Name = "SbtnResult";
            SbtnResult.Size = new Size(160, 29);
            SbtnResult.TabIndex = 24;
            SbtnResult.TextChanged += SbtnResult_TextChanged;
            // 
            // btnSide
            // 
            btnSide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSide.Location = new Point(23, 131);
            btnSide.Name = "btnSide";
            btnSide.Size = new Size(160, 29);
            btnSide.TabIndex = 23;
            btnSide.TextChanged += btnSide_TextChanged;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMenu.Location = new Point(105, 371);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(160, 49);
            btnBackToMenu.TabIndex = 22;
            btnBackToMenu.Text = "BACK TO MENU";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnClearCircle
            // 
            btnClearCircle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCircle.Location = new Point(195, 289);
            btnClearCircle.Name = "btnClearCircle";
            btnClearCircle.Size = new Size(160, 49);
            btnClearCircle.TabIndex = 21;
            btnClearCircle.Text = "CLEAR";
            btnClearCircle.UseVisualStyleBackColor = true;
            btnClearCircle.Click += btnClearCircle_Click;
            // 
            // SbtnDiagonal
            // 
            SbtnDiagonal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SbtnDiagonal.Location = new Point(195, 218);
            SbtnDiagonal.Name = "SbtnDiagonal";
            SbtnDiagonal.Size = new Size(160, 49);
            SbtnDiagonal.TabIndex = 20;
            SbtnDiagonal.Text = "DIAGONAL";
            SbtnDiagonal.UseVisualStyleBackColor = true;
            SbtnDiagonal.Click += SbtnDiagonal_Click;
            // 
            // SbtnArea
            // 
            SbtnArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SbtnArea.Location = new Point(23, 218);
            SbtnArea.Name = "SbtnArea";
            SbtnArea.Size = new Size(160, 47);
            SbtnArea.TabIndex = 19;
            SbtnArea.Text = "AREA";
            SbtnArea.UseVisualStyleBackColor = true;
            SbtnArea.Click += btnArea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(195, 107);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 18;
            label2.Text = "RESULT:";
            // 
            // SbtnSide
            // 
            SbtnSide.AutoSize = true;
            SbtnSide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SbtnSide.Location = new Point(23, 107);
            SbtnSide.Name = "SbtnSide";
            SbtnSide.Size = new Size(49, 21);
            SbtnSide.TabIndex = 17;
            SbtnSide.Text = "SIDE:";
            SbtnSide.Click += label1_Click;
            // 
            // SbtnPerimeter
            // 
            SbtnPerimeter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SbtnPerimeter.Location = new Point(23, 289);
            SbtnPerimeter.Name = "SbtnPerimeter";
            SbtnPerimeter.Size = new Size(160, 49);
            SbtnPerimeter.TabIndex = 26;
            SbtnPerimeter.Text = "PERIMETER";
            SbtnPerimeter.UseVisualStyleBackColor = true;
            SbtnPerimeter.Click += SbtnPerimeter_Click;
            // 
            // FormSquare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(378, 450);
            Controls.Add(SbtnPerimeter);
            Controls.Add(panel1);
            Controls.Add(SbtnResult);
            Controls.Add(btnSide);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnClearCircle);
            Controls.Add(SbtnDiagonal);
            Controls.Add(SbtnArea);
            Controls.Add(label2);
            Controls.Add(SbtnSide);
            Name = "FormSquare";
            Text = "Square";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox SbtnResult;
        private TextBox btnSide;
        private Button btnBackToMenu;
        private Button btnClearCircle;
        private Button SbtnDiagonal;
        private Button SbtnArea;
        private Label label2;
        private Label SbtnSide;
        private Button SbtnPerimeter;
    }
}