namespace DateTimePickerEx
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
            this.formatLong = new System.Windows.Forms.Label();
            this.formatShort = new System.Windows.Forms.Label();
            this.formatTime = new System.Windows.Forms.Label();
            this.formatCustom = new System.Windows.Forms.Label();
            this.pickerLong = new System.Windows.Forms.DateTimePicker();
            this.pickerShort = new System.Windows.Forms.DateTimePicker();
            this.pickerTime = new System.Windows.Forms.DateTimePicker();
            this.pickerCustom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // formatLong
            // 
            this.formatLong.AutoSize = true;
            this.formatLong.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.formatLong.Location = new System.Drawing.Point(64, 43);
            this.formatLong.Name = "formatLong";
            this.formatLong.Size = new System.Drawing.Size(113, 19);
            this.formatLong.TabIndex = 0;
            this.formatLong.Text = "Format = Long";
            // 
            // formatShort
            // 
            this.formatShort.AutoSize = true;
            this.formatShort.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.formatShort.Location = new System.Drawing.Point(64, 144);
            this.formatShort.Name = "formatShort";
            this.formatShort.Size = new System.Drawing.Size(121, 19);
            this.formatShort.TabIndex = 0;
            this.formatShort.Text = "Format = Short";
            // 
            // formatTime
            // 
            this.formatTime.AutoSize = true;
            this.formatTime.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.formatTime.Location = new System.Drawing.Point(64, 243);
            this.formatTime.Name = "formatTime";
            this.formatTime.Size = new System.Drawing.Size(113, 19);
            this.formatTime.TabIndex = 0;
            this.formatTime.Text = "Format = Time";
            // 
            // formatCustom
            // 
            this.formatCustom.AutoSize = true;
            this.formatCustom.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.formatCustom.Location = new System.Drawing.Point(64, 338);
            this.formatCustom.Name = "formatCustom";
            this.formatCustom.Size = new System.Drawing.Size(273, 19);
            this.formatCustom.TabIndex = 0;
            this.formatCustom.Text = "Format = Custom(yyyy.MM.dd hh:mm)";
            // 
            // pickerLong
            // 
            this.pickerLong.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pickerLong.Location = new System.Drawing.Point(68, 65);
            this.pickerLong.Name = "pickerLong";
            this.pickerLong.Size = new System.Drawing.Size(269, 27);
            this.pickerLong.TabIndex = 1;
            this.pickerLong.ValueChanged += new System.EventHandler(this.picker_ValueChanged);
            // 
            // pickerShort
            // 
            this.pickerShort.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pickerShort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerShort.Location = new System.Drawing.Point(68, 166);
            this.pickerShort.Name = "pickerShort";
            this.pickerShort.Size = new System.Drawing.Size(269, 27);
            this.pickerShort.TabIndex = 1;
            this.pickerShort.ValueChanged += new System.EventHandler(this.picker_ValueChanged);
            // 
            // pickerTime
            // 
            this.pickerTime.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerTime.Location = new System.Drawing.Point(68, 265);
            this.pickerTime.Name = "pickerTime";
            this.pickerTime.Size = new System.Drawing.Size(269, 27);
            this.pickerTime.TabIndex = 1;
            this.pickerTime.ValueChanged += new System.EventHandler(this.picker_ValueChanged);
            // 
            // pickerCustom
            // 
            this.pickerCustom.CustomFormat = "yyyy.MM.dd hh:mm";
            this.pickerCustom.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pickerCustom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerCustom.Location = new System.Drawing.Point(68, 360);
            this.pickerCustom.Name = "pickerCustom";
            this.pickerCustom.Size = new System.Drawing.Size(269, 27);
            this.pickerCustom.TabIndex = 1;
            this.pickerCustom.ValueChanged += new System.EventHandler(this.picker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.pickerCustom);
            this.Controls.Add(this.pickerTime);
            this.Controls.Add(this.pickerShort);
            this.Controls.Add(this.pickerLong);
            this.Controls.Add(this.formatCustom);
            this.Controls.Add(this.formatTime);
            this.Controls.Add(this.formatShort);
            this.Controls.Add(this.formatLong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formatLong;
        private System.Windows.Forms.Label formatShort;
        private System.Windows.Forms.Label formatTime;
        private System.Windows.Forms.Label formatCustom;
        private System.Windows.Forms.DateTimePicker pickerLong;
        private System.Windows.Forms.DateTimePicker pickerShort;
        private System.Windows.Forms.DateTimePicker pickerTime;
        private System.Windows.Forms.DateTimePicker pickerCustom;
    }
}

