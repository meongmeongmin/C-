namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1Label = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.num1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.num2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // number1Label
            // 
            this.number1Label.AutoSize = true;
            this.number1Label.Location = new System.Drawing.Point(102, 57);
            this.number1Label.Name = "number1Label";
            this.number1Label.Size = new System.Drawing.Size(35, 12);
            this.number1Label.TabIndex = 0;
            this.number1Label.Text = "숫자1";
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Location = new System.Drawing.Point(282, 57);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(35, 12);
            this.number2Label.TabIndex = 1;
            this.number2Label.Text = "숫자2";
            // 
            // num1NumericUpDown
            // 
            this.num1NumericUpDown.DecimalPlaces = 2;
            this.num1NumericUpDown.Location = new System.Drawing.Point(62, 90);
            this.num1NumericUpDown.Name = "num1NumericUpDown";
            this.num1NumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.num1NumericUpDown.TabIndex = 2;
            // 
            // num2NumericUpDown
            // 
            this.num2NumericUpDown.DecimalPlaces = 2;
            this.num2NumericUpDown.Location = new System.Drawing.Point(240, 90);
            this.num2NumericUpDown.Name = "num2NumericUpDown";
            this.num2NumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.num2NumericUpDown.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(193, 198);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(29, 12);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "결과";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(160, 227);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 21);
            this.resultTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(31, 157);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(128, 157);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(69, 23);
            this.subButton.TabIndex = 7;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(229, 157);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(69, 23);
            this.mulButton.TabIndex = 8;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(331, 157);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(69, 23);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "%";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 295);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.num2NumericUpDown);
            this.Controls.Add(this.num1NumericUpDown);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number1Label);
            this.Name = "Form1";
            this.Text = "객체지향 간단 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.NumericUpDown num1NumericUpDown;
        private System.Windows.Forms.NumericUpDown num2NumericUpDown;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
    }
}

