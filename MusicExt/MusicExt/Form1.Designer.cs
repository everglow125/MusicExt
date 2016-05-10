namespace MusicExt
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lstMusic = new System.Windows.Forms.ListBox();
            this.cbxChild = new System.Windows.Forms.CheckBox();
            this.rtxDetail = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnRemove = new System.Windows.Forms.RadioButton();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件夹";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(574, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(114, 40);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "扫描";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(318, 17);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 9;
            this.btnSelectPath.Text = "选择路径";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(86, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 21);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.Text = "F:\\CloudMusic";
            // 
            // lstMusic
            // 
            this.lstMusic.FormattingEnabled = true;
            this.lstMusic.ItemHeight = 12;
            this.lstMusic.Location = new System.Drawing.Point(29, 215);
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.Size = new System.Drawing.Size(273, 184);
            this.lstMusic.TabIndex = 10;
            this.lstMusic.SelectedIndexChanged += new System.EventHandler(this.lstMusic_SelectedIndexChanged);
            // 
            // cbxChild
            // 
            this.cbxChild.AutoSize = true;
            this.cbxChild.Location = new System.Drawing.Point(399, 21);
            this.cbxChild.Name = "cbxChild";
            this.cbxChild.Size = new System.Drawing.Size(96, 16);
            this.cbxChild.TabIndex = 11;
            this.cbxChild.Text = "包含子文件夹";
            this.cbxChild.UseVisualStyleBackColor = true;
            // 
            // rtxDetail
            // 
            this.rtxDetail.Location = new System.Drawing.Point(318, 218);
            this.rtxDetail.Name = "rtxDetail";
            this.rtxDetail.Size = new System.Drawing.Size(405, 229);
            this.rtxDetail.TabIndex = 12;
            this.rtxDetail.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(574, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 44);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "更改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(216, 21);
            this.txtTitle.TabIndex = 14;
            this.txtTitle.Text = "友情岁月";
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(86, 102);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(216, 21);
            this.txtSinger.TabIndex = 15;
            this.txtSinger.Text = "郑伊健";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "歌曲名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "演唱者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "专辑名";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(86, 140);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(216, 21);
            this.txtSpecial.TabIndex = 18;
            this.txtSpecial.Text = "郑伊健";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "文件名";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(86, 176);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(216, 21);
            this.txtFileName.TabIndex = 20;
            this.txtFileName.Text = "郑伊健";
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(338, 180);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(59, 16);
            this.rbtnAdd.TabIndex = 22;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "加前缀";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnRemove
            // 
            this.rbtnRemove.AutoSize = true;
            this.rbtnRemove.Location = new System.Drawing.Point(457, 180);
            this.rbtnRemove.Name = "rbtnRemove";
            this.rbtnRemove.Size = new System.Drawing.Size(59, 16);
            this.rbtnRemove.TabIndex = 23;
            this.rbtnRemove.TabStop = true;
            this.rbtnRemove.Text = "去前缀";
            this.rbtnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(29, 405);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(99, 42);
            this.btnAddItem.TabIndex = 24;
            this.btnAddItem.Text = "添加";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(175, 405);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(99, 42);
            this.btnRemoveItem.TabIndex = 25;
            this.btnRemoveItem.Text = "移除";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 459);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.rbtnRemove);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxDetail);
            this.Controls.Add(this.cbxChild);
            this.Controls.Add(this.lstMusic);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ListBox lstMusic;
        private System.Windows.Forms.CheckBox cbxChild;
        private System.Windows.Forms.RichTextBox rtxDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnRemove;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

