namespace ListViewEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.radioDetail = new System.Windows.Forms.RadioButton();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.radioLargeIcon = new System.Windows.Forms.RadioButton();
            this.radioSmallIcon = new System.Windows.Forms.RadioButton();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageListLarge;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(603, 363);
            this.listView1.StateImageList = this.imageListSmall;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // radioDetail
            // 
            this.radioDetail.AutoSize = true;
            this.radioDetail.Location = new System.Drawing.Point(626, 12);
            this.radioDetail.Margin = new System.Windows.Forms.Padding(8);
            this.radioDetail.Name = "radioDetail";
            this.radioDetail.Size = new System.Drawing.Size(118, 23);
            this.radioDetail.TabIndex = 1;
            this.radioDetail.TabStop = true;
            this.radioDetail.Text = "View Detail";
            this.radioDetail.UseVisualStyleBackColor = true;
            this.radioDetail.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioList
            // 
            this.radioList.AutoSize = true;
            this.radioList.Location = new System.Drawing.Point(626, 51);
            this.radioList.Margin = new System.Windows.Forms.Padding(8);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(102, 23);
            this.radioList.TabIndex = 1;
            this.radioList.TabStop = true;
            this.radioList.Text = "View List";
            this.radioList.UseVisualStyleBackColor = true;
            this.radioList.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioLargeIcon
            // 
            this.radioLargeIcon.AutoSize = true;
            this.radioLargeIcon.Location = new System.Drawing.Point(626, 129);
            this.radioLargeIcon.Margin = new System.Windows.Forms.Padding(8);
            this.radioLargeIcon.Name = "radioLargeIcon";
            this.radioLargeIcon.Size = new System.Drawing.Size(142, 23);
            this.radioLargeIcon.TabIndex = 1;
            this.radioLargeIcon.TabStop = true;
            this.radioLargeIcon.Text = "View LargeIcon";
            this.radioLargeIcon.UseVisualStyleBackColor = true;
            this.radioLargeIcon.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioSmallIcon
            // 
            this.radioSmallIcon.AutoSize = true;
            this.radioSmallIcon.Location = new System.Drawing.Point(626, 168);
            this.radioSmallIcon.Margin = new System.Windows.Forms.Padding(8);
            this.radioSmallIcon.Name = "radioSmallIcon";
            this.radioSmallIcon.Size = new System.Drawing.Size(142, 23);
            this.radioSmallIcon.TabIndex = 1;
            this.radioSmallIcon.TabStop = true;
            this.radioSmallIcon.Text = "View SmallIcon";
            this.radioSmallIcon.UseVisualStyleBackColor = true;
            this.radioSmallIcon.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Location = new System.Drawing.Point(626, 90);
            this.radioTitle.Margin = new System.Windows.Forms.Padding(8);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(110, 23);
            this.radioTitle.TabIndex = 1;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "View Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            this.radioTitle.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "file.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "fileSmall.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.radioSmallIcon);
            this.Controls.Add(this.radioTitle);
            this.Controls.Add(this.radioLargeIcon);
            this.Controls.Add(this.radioList);
            this.Controls.Add(this.radioDetail);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("D2Coding ligature", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioDetail;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioLargeIcon;
        private System.Windows.Forms.RadioButton radioSmallIcon;
        private System.Windows.Forms.RadioButton radioTitle;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

