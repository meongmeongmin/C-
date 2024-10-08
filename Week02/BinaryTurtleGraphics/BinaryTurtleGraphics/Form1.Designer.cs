namespace BinaryTurtleGraphics
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.InitButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(86, 50);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(139, 21);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(115, 98);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(75, 23);
            this.InitButton.TabIndex = 1;
            this.InitButton.Text = "초기화";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(115, 142);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 23);
            this.DrawButton.TabIndex = 2;
            this.DrawButton.Text = "그리기";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 417);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.Button DrawButton;
    }
}

