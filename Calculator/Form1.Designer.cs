namespace Calculator
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
            editBox = new TextBox();
            btnClear = new Button();
            btnMod = new Button();
            btnBackspace = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSubtract = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEqual = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnPM = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // editBox
            // 
            editBox.BackColor = SystemColors.Control;
            editBox.BorderStyle = BorderStyle.None;
            editBox.Dock = DockStyle.Top;
            editBox.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            editBox.Location = new Point(0, 25);
            editBox.Margin = new Padding(0);
            editBox.Multiline = true;
            editBox.Name = "editBox";
            editBox.Size = new Size(345, 39);
            editBox.TabIndex = 1;
            editBox.Text = "0";
            editBox.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(13, 95);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 75);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = SystemColors.MenuHighlight;
            btnMod.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMod.ForeColor = SystemColors.ButtonHighlight;
            btnMod.Location = new Point(94, 95);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 75);
            btnMod.TabIndex = 3;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnOperation_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.MenuHighlight;
            btnBackspace.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackspace.ForeColor = SystemColors.ButtonHighlight;
            btnBackspace.Location = new Point(175, 95);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(75, 75);
            btnBackspace.TabIndex = 4;
            btnBackspace.Text = "<-";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.MenuHighlight;
            btnDivide.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.ForeColor = SystemColors.ButtonHighlight;
            btnDivide.Location = new Point(256, 95);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 75);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.MenuHighlight;
            btnMultiply.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.ForeColor = SystemColors.ButtonHighlight;
            btnMultiply.Location = new Point(256, 176);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 75);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnOperation_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(175, 176);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 75);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(94, 176);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 75);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(13, 176);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 75);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.MenuHighlight;
            btnSubtract.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.ForeColor = SystemColors.ButtonHighlight;
            btnSubtract.Location = new Point(256, 257);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 75);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnOperation_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(175, 257);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 75);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(94, 257);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 75);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(13, 257);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 75);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(256, 338);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 75);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnOperation_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(175, 338);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(94, 338);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(13, 338);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.MenuHighlight;
            btnEqual.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.ForeColor = SystemColors.ButtonHighlight;
            btnEqual.Location = new Point(256, 418);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 75);
            btnEqual.TabIndex = 21;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimal.Location = new Point(175, 418);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 75);
            btnDecimal.TabIndex = 20;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnNum_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(94, 418);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 75);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPM.Location = new Point(13, 418);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 75);
            btnPM.TabIndex = 18;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // label
            // 
            label.BackColor = SystemColors.Control;
            label.Dock = DockStyle.Top;
            label.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.WindowFrame;
            label.Location = new Point(0, 0);
            label.Margin = new Padding(0);
            label.Name = "label";
            label.Size = new Size(345, 25);
            label.TabIndex = 22;
            label.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(345, 512);
            Controls.Add(btnEqual);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnPM);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSubtract);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btnBackspace);
            Controls.Add(btnMod);
            Controls.Add(btnClear);
            Controls.Add(editBox);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox editBox;
        private Button btnClear;
        private Button btnMod;
        private Button btnBackspace;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnSubtract;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEqual;
        private Button btnDecimal;
        private Button btn0;
        private Button btnPM;
        private Label label;
    }
}