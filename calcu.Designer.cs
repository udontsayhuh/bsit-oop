namespace calcu_oop
{
    partial class Form1
    {

        //ABTRACTION IMPLEMENTED IN THROUGH USERS INTERACTING WITH THE CALCULATOR
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
            txtResult = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            BtnDivide = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ButtonHighlight;
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Font = new Font("Segoe UI", 24F);
            txtResult.Location = new Point(25, 27);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(371, 88);
            txtResult.TabIndex = 0;
            txtResult.TextChanged += txtResult_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(26, 131);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 65);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(127, 131);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 65);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(225, 131);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 65);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(26, 211);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 61);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(127, 211);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 61);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(225, 211);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 61);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(26, 292);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 61);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(127, 292);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 61);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(225, 288);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 65);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(327, 288);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(69, 65);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(327, 211);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(69, 61);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(327, 131);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(69, 65);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDivide.Location = new Point(327, 373);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(69, 65);
            BtnDivide.TabIndex = 13;
            BtnDivide.Text = "÷";
            BtnDivide.UseVisualStyleBackColor = true;
            BtnDivide.Click += BtnDivide_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(26, 373);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(66, 65);
            btnEqual.TabIndex = 14;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(127, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 65);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Candara Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(225, 373);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 65);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(426, 450);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btnEqual);
            Controls.Add(BtnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculator-OOP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button BtnDivide;
        private Button btnEqual;
        private Button btnClear;
        private Button btn0;
    }
}
