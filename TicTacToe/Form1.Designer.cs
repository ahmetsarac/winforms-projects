namespace TicTacToe
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
            label1 = new Label();
            label2 = new Label();
            labelPlayerX = new Label();
            labelPlayerO = new Label();
            btnNew = new Button();
            btnReset = new Button();
            btnBoard1 = new Button();
            btnBoard2 = new Button();
            btnBoard3 = new Button();
            btnBoard4 = new Button();
            btnBoard5 = new Button();
            btnBoard6 = new Button();
            btnBoard7 = new Button();
            btnBoard8 = new Button();
            btnBoard9 = new Button();
            labelTurn = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 38);
            label1.TabIndex = 0;
            label1.Text = "Player X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(593, 9);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 1;
            label2.Text = "Player O:";
            // 
            // labelPlayerX
            // 
            labelPlayerX.AutoSize = true;
            labelPlayerX.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerX.Location = new Point(149, 9);
            labelPlayerX.Name = "labelPlayerX";
            labelPlayerX.Size = new Size(35, 38);
            labelPlayerX.TabIndex = 2;
            labelPlayerX.Text = "0";
            // 
            // labelPlayerO
            // 
            labelPlayerO.AutoSize = true;
            labelPlayerO.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerO.Location = new Point(736, 9);
            labelPlayerO.Name = "labelPlayerO";
            labelPlayerO.Size = new Size(35, 38);
            labelPlayerO.TabIndex = 3;
            labelPlayerO.Text = "0";
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(241, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(138, 35);
            btnNew.TabIndex = 4;
            btnNew.Text = "New Game";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(397, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(138, 35);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset Board";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBoard1
            // 
            btnBoard1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard1.Location = new Point(56, 84);
            btnBoard1.Name = "btnBoard1";
            btnBoard1.Size = new Size(215, 191);
            btnBoard1.TabIndex = 6;
            btnBoard1.UseVisualStyleBackColor = true;
            btnBoard1.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard1.Click += btnBoardClick;
            // 
            // btnBoard2
            // 
            btnBoard2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard2.Location = new Point(277, 84);
            btnBoard2.Name = "btnBoard2";
            btnBoard2.Size = new Size(215, 191);
            btnBoard2.TabIndex = 7;
            btnBoard2.UseVisualStyleBackColor = true;
            btnBoard2.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard2.Click += btnBoardClick;
            // 
            // btnBoard3
            // 
            btnBoard3.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard3.Location = new Point(498, 84);
            btnBoard3.Name = "btnBoard3";
            btnBoard3.Size = new Size(215, 191);
            btnBoard3.TabIndex = 8;
            btnBoard3.UseVisualStyleBackColor = true;
            btnBoard3.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard3.Click += btnBoardClick;
            // 
            // btnBoard4
            // 
            btnBoard4.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard4.Location = new Point(56, 281);
            btnBoard4.Name = "btnBoard4";
            btnBoard4.Size = new Size(215, 191);
            btnBoard4.TabIndex = 9;
            btnBoard4.UseVisualStyleBackColor = true;
            btnBoard4.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard4.Click += btnBoardClick;
            // 
            // btnBoard5
            // 
            btnBoard5.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard5.Location = new Point(277, 281);
            btnBoard5.Name = "btnBoard5";
            btnBoard5.Size = new Size(215, 191);
            btnBoard5.TabIndex = 10;
            btnBoard5.UseVisualStyleBackColor = true;
            btnBoard5.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard5.Click += btnBoardClick;
            // 
            // btnBoard6
            // 
            btnBoard6.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard6.Location = new Point(498, 281);
            btnBoard6.Name = "btnBoard6";
            btnBoard6.Size = new Size(215, 191);
            btnBoard6.TabIndex = 11;
            btnBoard6.UseVisualStyleBackColor = true;
            btnBoard6.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard6.Click += btnBoardClick;
            // 
            // btnBoard7
            // 
            btnBoard7.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard7.Location = new Point(56, 478);
            btnBoard7.Name = "btnBoard7";
            btnBoard7.Size = new Size(215, 191);
            btnBoard7.TabIndex = 12;
            btnBoard7.UseVisualStyleBackColor = true;
            btnBoard7.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard7.Click += btnBoardClick;
            // 
            // btnBoard8
            // 
            btnBoard8.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard8.Location = new Point(277, 478);
            btnBoard8.Name = "btnBoard8";
            btnBoard8.Size = new Size(215, 191);
            btnBoard8.TabIndex = 13;
            btnBoard8.UseVisualStyleBackColor = true;
            btnBoard8.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard8.Click += btnBoardClick;
            // 
            // btnBoard9
            // 
            btnBoard9.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBoard9.Location = new Point(498, 478);
            btnBoard9.Name = "btnBoard9";
            btnBoard9.Size = new Size(215, 191);
            btnBoard9.TabIndex = 14;
            btnBoard9.UseVisualStyleBackColor = true;
            btnBoard9.EnabledChanged += btnBoard_Enable_Changed;
            btnBoard9.Click += btnBoardClick;
            // 
            // labelTurn
            // 
            labelTurn.AutoSize = true;
            labelTurn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTurn.Location = new Point(307, 50);
            labelTurn.Name = "labelTurn";
            labelTurn.Size = new Size(152, 26);
            labelTurn.TabIndex = 15;
            labelTurn.Text = "Player X's turn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 705);
            Controls.Add(labelTurn);
            Controls.Add(btnBoard9);
            Controls.Add(btnBoard8);
            Controls.Add(btnBoard7);
            Controls.Add(btnBoard6);
            Controls.Add(btnBoard5);
            Controls.Add(btnBoard4);
            Controls.Add(btnBoard3);
            Controls.Add(btnBoard2);
            Controls.Add(btnBoard1);
            Controls.Add(btnReset);
            Controls.Add(btnNew);
            Controls.Add(labelPlayerO);
            Controls.Add(labelPlayerX);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelPlayerX;
        private Label labelPlayerO;
        private Button btnNew;
        private Button btnReset;
        private Button btnBoard1;
        private Button btnBoard2;
        private Button btnBoard3;
        private Button btnBoard4;
        private Button btnBoard5;
        private Button btnBoard6;
        private Button btnBoard7;
        private Button btnBoard8;
        private Button btnBoard9;
        private Label labelTurn;
    }
}