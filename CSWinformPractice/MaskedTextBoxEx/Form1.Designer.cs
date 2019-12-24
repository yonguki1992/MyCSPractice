namespace MaskedTextBoxEx
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
            this.components = new System.ComponentModel.Container();
            this.maskedDayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedHPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedCPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // maskedDayTextBox
            // 
            this.maskedDayTextBox.Location = new System.Drawing.Point(148, 58);
            this.maskedDayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedDayTextBox.Mask = "0000년 90월 90일";
            this.maskedDayTextBox.Name = "maskedDayTextBox";
            this.maskedDayTextBox.Size = new System.Drawing.Size(156, 27);
            this.maskedDayTextBox.TabIndex = 0;
            this.maskedDayTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "날짜";
            // 
            // maskedHPTextBox
            // 
            this.maskedHPTextBox.Location = new System.Drawing.Point(148, 108);
            this.maskedHPTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedHPTextBox.Name = "maskedHPTextBox";
            this.maskedHPTextBox.Size = new System.Drawing.Size(156, 27);
            this.maskedHPTextBox.TabIndex = 0;
            this.maskedHPTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedHPTextBox_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "전화번호";
            // 
            // maskedCPTextBox
            // 
            this.maskedCPTextBox.Location = new System.Drawing.Point(148, 156);
            this.maskedCPTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedCPTextBox.Mask = "000-9000-0000";
            this.maskedCPTextBox.Name = "maskedCPTextBox";
            this.maskedCPTextBox.Size = new System.Drawing.Size(156, 27);
            this.maskedCPTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "핸드폰";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(148, 216);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 35);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 299);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedCPTextBox);
            this.Controls.Add(this.maskedHPTextBox);
            this.Controls.Add(this.maskedDayTextBox);
            this.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedDayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedHPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedCPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

