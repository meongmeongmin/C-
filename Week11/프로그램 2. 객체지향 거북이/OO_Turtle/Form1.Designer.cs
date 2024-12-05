namespace OO_Turtle
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
            this.initButton = new System.Windows.Forms.Button();
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.rectRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(46, 33);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(75, 23);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "초기화";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.AutoSize = true;
            this.lineRadioButton.Location = new System.Drawing.Point(46, 81);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(35, 16);
            this.lineRadioButton.TabIndex = 1;
            this.lineRadioButton.TabStop = true;
            this.lineRadioButton.Text = "선";
            this.lineRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectRadioButton
            // 
            this.rectRadioButton.AutoSize = true;
            this.rectRadioButton.Location = new System.Drawing.Point(98, 81);
            this.rectRadioButton.Name = "rectRadioButton";
            this.rectRadioButton.Size = new System.Drawing.Size(59, 16);
            this.rectRadioButton.TabIndex = 2;
            this.rectRadioButton.TabStop = true;
            this.rectRadioButton.Text = "사각형";
            this.rectRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.rectRadioButton);
            this.Controls.Add(this.lineRadioButton);
            this.Controls.Add(this.initButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private System.Windows.Forms.RadioButton rectRadioButton;
    }
}

