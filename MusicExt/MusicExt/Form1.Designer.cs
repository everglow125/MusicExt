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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lstMusic = new System.Windows.Forms.ListBox();
            this.cbxChild = new System.Windows.Forms.CheckBox();
            this.rtxDetail = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.rbtnAddPrefix = new System.Windows.Forms.RadioButton();
            this.rbtnRemovePrefix = new System.Windows.Forms.RadioButton();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.RadioButton();
            this.rbtnMusicName = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditPrefix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
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
            this.btnOpen.Location = new System.Drawing.Point(533, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(141, 40);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "扫描文件";
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
            this.lstMusic.AllowDrop = true;
            this.lstMusic.FormattingEnabled = true;
            this.lstMusic.ItemHeight = 12;
            this.lstMusic.Location = new System.Drawing.Point(29, 55);
            this.lstMusic.MultiColumn = true;
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMusic.Size = new System.Drawing.Size(273, 400);
            this.lstMusic.TabIndex = 10;
            this.lstMusic.SelectedIndexChanged += new System.EventHandler(this.lstMusic_SelectedIndexChanged);
            this.lstMusic.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstMusic_DragDrop);
            this.lstMusic.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstMusic_DragEnter);
            this.lstMusic.DoubleClick += new System.EventHandler(this.lstMusic_DoubleClick);
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
            this.rtxDetail.Location = new System.Drawing.Point(318, 222);
            this.rtxDetail.Name = "rtxDetail";
            this.rtxDetail.Size = new System.Drawing.Size(537, 267);
            this.rtxDetail.TabIndex = 12;
            this.rtxDetail.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "更改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(54, 19);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(94, 21);
            this.txtSinger.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "演唱者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "专辑名";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(227, 19);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(143, 21);
            this.txtSpecial.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 21;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(39, 19);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(96, 21);
            this.txtPrefix.TabIndex = 20;
            // 
            // rbtnAddPrefix
            // 
            this.rbtnAddPrefix.AutoSize = true;
            this.rbtnAddPrefix.Checked = true;
            this.rbtnAddPrefix.Location = new System.Drawing.Point(169, 20);
            this.rbtnAddPrefix.Name = "rbtnAddPrefix";
            this.rbtnAddPrefix.Size = new System.Drawing.Size(59, 16);
            this.rbtnAddPrefix.TabIndex = 22;
            this.rbtnAddPrefix.TabStop = true;
            this.rbtnAddPrefix.Text = "加前缀";
            this.rbtnAddPrefix.UseVisualStyleBackColor = true;
            // 
            // rbtnRemovePrefix
            // 
            this.rbtnRemovePrefix.AutoSize = true;
            this.rbtnRemovePrefix.Location = new System.Drawing.Point(286, 20);
            this.rbtnRemovePrefix.Name = "rbtnRemovePrefix";
            this.rbtnRemovePrefix.Size = new System.Drawing.Size(59, 16);
            this.rbtnRemovePrefix.TabIndex = 23;
            this.rbtnRemovePrefix.Text = "去前缀";
            this.rbtnRemovePrefix.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(29, 461);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(69, 28);
            this.btnAddItem.TabIndex = 24;
            this.btnAddItem.Text = "添加";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(132, 461);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(70, 28);
            this.btnRemoveItem.TabIndex = 25;
            this.btnRemoveItem.Text = "移除";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 28);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.btnBoth);
            this.groupBox1.Controls.Add(this.rbtnMusicName);
            this.groupBox1.Location = new System.Drawing.Point(318, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 49);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件名命名规则";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(416, 17);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 28;
            this.btnRename.Text = "重命名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnBoth
            // 
            this.btnBoth.AutoSize = true;
            this.btnBoth.Checked = true;
            this.btnBoth.Location = new System.Drawing.Point(9, 20);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(101, 16);
            this.btnBoth.TabIndex = 2;
            this.btnBoth.TabStop = true;
            this.btnBoth.Text = "歌手 - 歌曲名";
            this.btnBoth.UseVisualStyleBackColor = true;
            // 
            // rbtnMusicName
            // 
            this.rbtnMusicName.AutoSize = true;
            this.rbtnMusicName.Location = new System.Drawing.Point(169, 20);
            this.rbtnMusicName.Name = "rbtnMusicName";
            this.rbtnMusicName.Size = new System.Drawing.Size(59, 16);
            this.rbtnMusicName.TabIndex = 1;
            this.rbtnMusicName.Text = "歌曲名";
            this.rbtnMusicName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnEditPrefix);
            this.groupBox2.Controls.Add(this.txtPrefix);
            this.groupBox2.Controls.Add(this.rbtnRemovePrefix);
            this.groupBox2.Controls.Add(this.rbtnAddPrefix);
            this.groupBox2.Location = new System.Drawing.Point(318, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 49);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名前缀";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "前缀";
            // 
            // btnEditPrefix
            // 
            this.btnEditPrefix.Location = new System.Drawing.Point(416, 17);
            this.btnEditPrefix.Name = "btnEditPrefix";
            this.btnEditPrefix.Size = new System.Drawing.Size(75, 23);
            this.btnEditPrefix.TabIndex = 28;
            this.btnEditPrefix.Text = "重命名";
            this.btnEditPrefix.UseVisualStyleBackColor = true;
            this.btnEditPrefix.Click += new System.EventHandler(this.btnEditPrefix_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSinger);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSpecial);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(318, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 49);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "歌曲信息";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(29, 510);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(826, 46);
            this.axWindowsMediaPlayer1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 568);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxDetail);
            this.Controls.Add(this.cbxChild);
            this.Controls.Add(this.lstMusic);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "动次打次";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.RadioButton rbtnAddPrefix;
        private System.Windows.Forms.RadioButton rbtnRemovePrefix;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnBoth;
        private System.Windows.Forms.RadioButton rbtnMusicName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditPrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

