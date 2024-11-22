namespace RandomAnimalViewer
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
            this.drawRandomAnimalButton = new System.Windows.Forms.Button();
            this.animalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.animalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawRandomAnimalButton
            // 
            this.drawRandomAnimalButton.Location = new System.Drawing.Point(132, 54);
            this.drawRandomAnimalButton.Name = "drawRandomAnimalButton";
            this.drawRandomAnimalButton.Size = new System.Drawing.Size(75, 23);
            this.drawRandomAnimalButton.TabIndex = 0;
            this.drawRandomAnimalButton.Text = "랜덤 뽑기";
            this.drawRandomAnimalButton.UseVisualStyleBackColor = true;
            this.drawRandomAnimalButton.Click += new System.EventHandler(this.drawRandomAnimalButton_Click);
            // 
            // animalPictureBox
            // 
            this.animalPictureBox.Location = new System.Drawing.Point(46, 110);
            this.animalPictureBox.Name = "animalPictureBox";
            this.animalPictureBox.Size = new System.Drawing.Size(250, 189);
            this.animalPictureBox.TabIndex = 1;
            this.animalPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 354);
            this.Controls.Add(this.animalPictureBox);
            this.Controls.Add(this.drawRandomAnimalButton);
            this.Name = "Form1";
            this.Text = "랜덤한 동물 보기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawRandomAnimalButton;
        private System.Windows.Forms.PictureBox animalPictureBox;
    }
}

