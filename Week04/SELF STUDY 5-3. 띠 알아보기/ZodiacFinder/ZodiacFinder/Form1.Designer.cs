namespace ZodiacFinder
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
            this.zodiacTextBox = new System.Windows.Forms.TextBox();
            this.zodiacFinderButton = new System.Windows.Forms.Button();
            this.zodiacPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zodiacPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // zodiacTextBox
            // 
            this.zodiacTextBox.Location = new System.Drawing.Point(123, 62);
            this.zodiacTextBox.Name = "zodiacTextBox";
            this.zodiacTextBox.Size = new System.Drawing.Size(100, 21);
            this.zodiacTextBox.TabIndex = 0;
            // 
            // zodiacFinderButton
            // 
            this.zodiacFinderButton.Location = new System.Drawing.Point(266, 59);
            this.zodiacFinderButton.Name = "zodiacFinderButton";
            this.zodiacFinderButton.Size = new System.Drawing.Size(128, 23);
            this.zodiacFinderButton.TabIndex = 1;
            this.zodiacFinderButton.Text = "띠 알아보기";
            this.zodiacFinderButton.UseVisualStyleBackColor = true;
            this.zodiacFinderButton.Click += new System.EventHandler(this.zodiacFinderButton_Click);
            // 
            // zodiacPictureBox
            // 
            this.zodiacPictureBox.Location = new System.Drawing.Point(123, 124);
            this.zodiacPictureBox.Name = "zodiacPictureBox";
            this.zodiacPictureBox.Size = new System.Drawing.Size(313, 287);
            this.zodiacPictureBox.TabIndex = 2;
            this.zodiacPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 483);
            this.Controls.Add(this.zodiacPictureBox);
            this.Controls.Add(this.zodiacFinderButton);
            this.Controls.Add(this.zodiacTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zodiacPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zodiacTextBox;
        private System.Windows.Forms.Button zodiacFinderButton;
        private System.Windows.Forms.PictureBox zodiacPictureBox;
    }
}

