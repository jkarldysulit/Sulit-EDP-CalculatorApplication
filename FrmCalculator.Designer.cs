namespace CalculatorApplication
{
    partial class FrmCalculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblFirstNumber = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            lblSecondNumber = new Label();
            txtBoxInput2 = new TextBox();
            lblAnswer = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // lblFirstNumber
            // 
            lblFirstNumber.AutoSize = true;
            lblFirstNumber.ForeColor = Color.FromArgb(228, 228, 232);
            lblFirstNumber.Location = new Point(30, 40);
            lblFirstNumber.Name = "lblFirstNumber";
            lblFirstNumber.Size = new Size(120, 15);
            lblFirstNumber.TabIndex = 0;
            lblFirstNumber.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.BackColor = Color.FromArgb(42, 42, 60);
            txtBoxInput1.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.ForeColor = Color.FromArgb(228, 228, 232);
            txtBoxInput1.Location = new Point(180, 35);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(180, 29);
            txtBoxInput1.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.BackColor = Color.FromArgb(42, 42, 60);
            cbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperator.FlatStyle = FlatStyle.Flat;
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.ForeColor = Color.FromArgb(228, 228, 232);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(280, 75);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(80, 31);
            cbOperator.TabIndex = 2;
            // 
            // lblSecondNumber
            // 
            lblSecondNumber.AutoSize = true;
            lblSecondNumber.ForeColor = Color.FromArgb(228, 228, 232);
            lblSecondNumber.Location = new Point(30, 125);
            lblSecondNumber.Name = "lblSecondNumber";
            lblSecondNumber.Size = new Size(135, 15);
            lblSecondNumber.TabIndex = 3;
            lblSecondNumber.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.BackColor = Color.FromArgb(42, 42, 60);
            txtBoxInput2.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.ForeColor = Color.FromArgb(228, 228, 232);
            txtBoxInput2.Location = new Point(180, 120);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(180, 29);
            txtBoxInput2.TabIndex = 4;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.ForeColor = Color.FromArgb(228, 228, 232);
            lblAnswer.Location = new Point(100, 170);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(50, 15);
            lblAnswer.TabIndex = 5;
            lblAnswer.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = false;
            lblDisplayTotal.BackColor = Color.FromArgb(42, 42, 60);
            lblDisplayTotal.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayTotal.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblDisplayTotal.ForeColor = Color.FromArgb(127, 209, 174);
            lblDisplayTotal.Location = new Point(180, 168);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(180, 28);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "";
            lblDisplayTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(92, 158, 234);
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Consolas", 14F);
            btnEqual.ForeColor = Color.FromArgb(30, 30, 46);
            btnEqual.Location = new Point(180, 220);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(180, 45);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(430, 290);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(lblAnswer);
            Controls.Add(txtBoxInput2);
            Controls.Add(lblSecondNumber);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            Controls.Add(lblFirstNumber);
            Name = "FrmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstNumber;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private Label lblSecondNumber;
        private TextBox txtBoxInput2;
        private Label lblAnswer;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}