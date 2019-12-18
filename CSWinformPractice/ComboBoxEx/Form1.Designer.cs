namespace ComboBoxEx
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSimple = new System.Windows.Forms.ComboBox();
            this.comboBoxDropDown = new System.Windows.Forms.ComboBox();
            this.comboBoxDropDownList = new System.Windows.Forms.ComboBox();
            this.selectedItem1 = new System.Windows.Forms.Label();
            this.selectedItem2 = new System.Windows.Forms.Label();
            this.selectedItem3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(89, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(312, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drop Down";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(544, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Drop Down List";
            // 
            // comboBoxSimple
            // 
            this.comboBoxSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxSimple.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxSimple.FormattingEnabled = true;
            this.comboBoxSimple.Location = new System.Drawing.Point(93, 114);
            this.comboBoxSimple.Name = "comboBoxSimple";
            this.comboBoxSimple.Size = new System.Drawing.Size(121, 150);
            this.comboBoxSimple.TabIndex = 1;
            this.comboBoxSimple.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.comboBoxSimple.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.comboBoxSimple.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // comboBoxDropDown
            // 
            this.comboBoxDropDown.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxDropDown.FormattingEnabled = true;
            this.comboBoxDropDown.Location = new System.Drawing.Point(316, 114);
            this.comboBoxDropDown.Name = "comboBoxDropDown";
            this.comboBoxDropDown.Size = new System.Drawing.Size(121, 27);
            this.comboBoxDropDown.TabIndex = 2;
            this.comboBoxDropDown.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.comboBoxDropDown.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
            this.comboBoxDropDown.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // comboBoxDropDownList
            // 
            this.comboBoxDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropDownList.Font = new System.Drawing.Font("D2Coding", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxDropDownList.FormattingEnabled = true;
            this.comboBoxDropDownList.Location = new System.Drawing.Point(548, 114);
            this.comboBoxDropDownList.Name = "comboBoxDropDownList";
            this.comboBoxDropDownList.Size = new System.Drawing.Size(121, 27);
            this.comboBoxDropDownList.TabIndex = 3;
            this.comboBoxDropDownList.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.comboBoxDropDownList.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // selectedItem1
            // 
            this.selectedItem1.AutoSize = true;
            this.selectedItem1.Font = new System.Drawing.Font("D2Coding ligature", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectedItem1.Location = new System.Drawing.Point(87, 40);
            this.selectedItem1.Name = "selectedItem1";
            this.selectedItem1.Size = new System.Drawing.Size(90, 35);
            this.selectedItem1.TabIndex = 4;
            this.selectedItem1.Text = "Hello";
            // 
            // selectedItem2
            // 
            this.selectedItem2.AutoSize = true;
            this.selectedItem2.Font = new System.Drawing.Font("D2Coding ligature", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectedItem2.Location = new System.Drawing.Point(310, 40);
            this.selectedItem2.Name = "selectedItem2";
            this.selectedItem2.Size = new System.Drawing.Size(90, 35);
            this.selectedItem2.TabIndex = 4;
            this.selectedItem2.Text = "Hello";
            // 
            // selectedItem3
            // 
            this.selectedItem3.AutoSize = true;
            this.selectedItem3.Font = new System.Drawing.Font("D2Coding ligature", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectedItem3.Location = new System.Drawing.Point(542, 40);
            this.selectedItem3.Name = "selectedItem3";
            this.selectedItem3.Size = new System.Drawing.Size(90, 35);
            this.selectedItem3.TabIndex = 4;
            this.selectedItem3.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedItem3);
            this.Controls.Add(this.selectedItem2);
            this.Controls.Add(this.selectedItem1);
            this.Controls.Add(this.comboBoxDropDownList);
            this.Controls.Add(this.comboBoxDropDown);
            this.Controls.Add(this.comboBoxSimple);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSimple;
        private System.Windows.Forms.ComboBox comboBoxDropDown;
        private System.Windows.Forms.ComboBox comboBoxDropDownList;
        private System.Windows.Forms.Label selectedItem1;
        private System.Windows.Forms.Label selectedItem2;
        private System.Windows.Forms.Label selectedItem3;
    }
}

