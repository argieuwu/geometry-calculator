namespace ProjectGeometry
{
    partial class FormRectangle
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
            RbtnResult = new TextBox();
            RbtnLength = new TextBox();
            btnBackToMenu = new Button();
            btnClearCircle = new Button();
            btnDiagonal = new Button();
            btnArea = new Button();
            label2 = new Label();
            label1 = new Label();
            RbtnWidth = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 56);
            panel1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 9);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 0;
            label3.Text = "RECTANGLE";
            // 
            // RbtnResult
            // 
            RbtnResult.Enabled = false;
            RbtnResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RbtnResult.Location = new Point(197, 109);
            RbtnResult.Name = "RbtnResult";
            RbtnResult.Size = new Size(160, 33);
            RbtnResult.TabIndex = 33;
            RbtnResult.TextChanged += RbtnResult_TextChanged;
            // 
            // RbtnLength
            // 
            RbtnLength.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RbtnLength.Location = new Point(22, 109);
            RbtnLength.Name = "RbtnLength";
            RbtnLength.Size = new Size(160, 33);
            RbtnLength.TabIndex = 32;
            RbtnLength.TextChanged += RbtnLength_TextChanged;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMenu.Location = new Point(197, 320);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(160, 48);
            btnBackToMenu.TabIndex = 31;
            btnBackToMenu.Text = "BACK TO MENU";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnClearCircle
            // 
            btnClearCircle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCircle.Location = new Point(22, 320);
            btnClearCircle.Name = "btnClearCircle";
            btnClearCircle.Size = new Size(160, 48);
            btnClearCircle.TabIndex = 30;
            btnClearCircle.Text = "CLEAR";
            btnClearCircle.UseVisualStyleBackColor = true;
            btnClearCircle.Click += btnClearCircle_Click;
            // 
            // btnDiagonal
            // 
            btnDiagonal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiagonal.Location = new Point(197, 250);
            btnDiagonal.Name = "btnDiagonal";
            btnDiagonal.Size = new Size(160, 52);
            btnDiagonal.TabIndex = 29;
            btnDiagonal.Text = "DIAGONAL";
            btnDiagonal.UseVisualStyleBackColor = true;
            btnDiagonal.Click += btnDiagonal_Click;
            // 
            // btnArea
            // 
            btnArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArea.Location = new Point(22, 250);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(160, 52);
            btnArea.TabIndex = 28;
            btnArea.Text = "AREA";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 27;
            label2.Text = "RESULT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 26;
            label1.Text = "LENGTH:";
            // 
            // RbtnWidth
            // 
            RbtnWidth.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RbtnWidth.Location = new Point(22, 169);
            RbtnWidth.Name = "RbtnWidth";
            RbtnWidth.Size = new Size(160, 33);
            RbtnWidth.TabIndex = 36;
            RbtnWidth.TextChanged += RbtnWidth_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 145);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 35;
            label4.Text = "WIDTH:";
            // 
            // FormRectangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(378, 450);
            Controls.Add(RbtnWidth);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(RbtnResult);
            Controls.Add(RbtnLength);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnClearCircle);
            Controls.Add(btnDiagonal);
            Controls.Add(btnArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRectangle";
            Text = "Rectangle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox RbtnResult;
        private TextBox RbtnLength;
        private Button btnBackToMenu;
        private Button btnClearCircle;
        private Button btnDiagonal;
        private Button btnArea;
        private Label label2;
        private Label label1;
        private TextBox RbtnWidth;
        private Label label4;
    }
}