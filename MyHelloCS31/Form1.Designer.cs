namespace MyHelloCS31
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
            this.btnGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreeting
            // 
            this.btnGreeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreeting.Font = new System.Drawing.Font("궁서체", 17F);
            this.btnGreeting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGreeting.Location = new System.Drawing.Point(434, 221);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(196, 89);
            this.btnGreeting.TabIndex = 0;
            this.btnGreeting.Text = "환영 인사하기";
            this.btnGreeting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 652);
            this.Controls.Add(this.btnGreeting);
            this.Name = "Form1";
            this.Text = "마이헬로우";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreeting;
    }
}

