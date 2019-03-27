namespace CalculatorTrain
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
            this.PrintRes = new System.Windows.Forms.Button();
            this.Sum1 = new System.Windows.Forms.TextBox();
            this.Sum2 = new System.Windows.Forms.TextBox();
            this.ResSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrintRes
            // 
            this.PrintRes.Location = new System.Drawing.Point(407, 140);
            this.PrintRes.Name = "PrintRes";
            this.PrintRes.Size = new System.Drawing.Size(75, 23);
            this.PrintRes.TabIndex = 0;
            this.PrintRes.Text = "결과";
            this.PrintRes.UseVisualStyleBackColor = true;
            this.PrintRes.Click += new System.EventHandler(this.PrintRes_Click);
            // 
            // Sum1
            // 
            this.Sum1.Location = new System.Drawing.Point(106, 48);
            this.Sum1.Name = "Sum1";
            this.Sum1.Size = new System.Drawing.Size(100, 25);
            this.Sum1.TabIndex = 1;
            // 
            // Sum2
            // 
            this.Sum2.Location = new System.Drawing.Point(268, 48);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(100, 25);
            this.Sum2.TabIndex = 2;
            // 
            // ResSum
            // 
            this.ResSum.Location = new System.Drawing.Point(424, 48);
            this.ResSum.Name = "ResSum";
            this.ResSum.Size = new System.Drawing.Size(100, 25);
            this.ResSum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResSum);
            this.Controls.Add(this.Sum2);
            this.Controls.Add(this.Sum1);
            this.Controls.Add(this.PrintRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintRes;
        private System.Windows.Forms.TextBox Sum1;
        private System.Windows.Forms.TextBox Sum2;
        private System.Windows.Forms.TextBox ResSum;
    }
}

