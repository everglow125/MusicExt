namespace MusicExt
{
    partial class fmDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Singer = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Collection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "演唱者";
            // 
            // Singer
            // 
            this.Singer.Location = new System.Drawing.Point(84, 23);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(100, 21);
            this.Singer.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(295, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 21);
            this.Title.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "歌曲名";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(295, 50);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 21);
            this.FileName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "文件名";
            // 
            // Collection
            // 
            this.Collection.Location = new System.Drawing.Point(84, 50);
            this.Collection.Name = "Collection";
            this.Collection.Size = new System.Drawing.Size(100, 21);
            this.Collection.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "专辑名";
            // 
            // fmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 140);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Collection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Singer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "fmDetail";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Singer;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Collection;
        private System.Windows.Forms.Label label4;
    }
}