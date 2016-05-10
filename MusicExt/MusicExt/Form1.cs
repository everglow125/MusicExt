using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Shell32;

namespace MusicExt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            InitList();
        }

        public void InitList()
        {
            string dirPath = this.txtAddress.Text.Trim();
            List<TFile> list = new List<TFile>();
            ScanFile(dirPath, list);
            this.lstMusic.DataSource = list;
            this.lstMusic.DisplayMember = "Name";
            this.lstMusic.ValueMember = "FullName";
        }

        public void ScanFile(string floder, List<TFile> list)
        {
            DirectoryInfo TheFolder = new DirectoryInfo(floder);
            foreach (FileInfo file in TheFolder.GetFiles())
                list.Add(new TFile(file.Name, floder + "\\" + file.Name));
            if (this.cbxChild.Checked)
            {
                foreach (DirectoryInfo folderItem in TheFolder.GetDirectories())
                    ScanFile(floder + "\\" + folderItem.Name, list);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.ShowDialog();
                this.txtAddress.Text = path.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ShowDetail()
        {
            //OpenFileDialog ofd = new OpenFileDialog();  //new一个方法  
            //ofd.Filter = "MP3 Files(.mp3)|*.mp3|WMA Files(*.wma)|*.WMA|ALL Files(*.*)|*.*";
            //ofd.Multiselect = true;         //允许多选  
            //ofd.RestoreDirectory = true;    //记住上一次的文件路径  
            //ofd.ShowDialog();               //显示打开文件的窗口  
            //string filePath = ofd.FileName;        //获取文件的完整的路径  

            //FileInfo fInfo = new FileInfo(filePath);

            string filePath = this.lstMusic.SelectedValue.ToString();
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(Path.GetDirectoryName(filePath));
            FolderItem item = dir.ParseName(Path.GetFileName(filePath));
            StringBuilder sb = new StringBuilder();
            for (int i = -1; i < 50; i++)
            {
                sb.Append(i.ToString());
                sb.Append(":");
                sb.Append(dir.GetDetailsOf(item, i));
                sb.Append("\r\n");
            }
            rtxDetail.Text = sb.ToString();
        }

        private void lstMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileNameEx = txtFileName.Text.Trim();
            try
            {

                foreach (var item in this.lstMusic.Items)
                {
                    var filePath = (item as TFile).FullName;
                    MediaTags mt = new MediaTags(filePath);
                    mt.AlbumArtist = this.txtSinger.Text;
                    mt.AlbumTitle = this.txtSpecial.Text;
                    mt.Author = this.txtSinger.Text;
                    mt.Comment = "";
                    mt.SubTitle = "";
                    mt.SaveChanged(filePath);
                    if (!string.IsNullOrEmpty(fileNameEx))
                    {
                        string[] temp = filePath.Split('\\');
                        if (rbtnAdd.Checked)
                            temp[temp.Count() - 1] = fileNameEx + temp[temp.Count() - 1];
                        else if (rbtnRemove.Checked)
                            temp[temp.Count() - 1] = temp[temp.Count() - 1].Replace(fileNameEx, "");
                        File.Move(filePath, string.Join("\\", temp));
                    }
                }
                InitList();
                MessageBox.Show("更新完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败" + ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //  this.lstMusic.Items.Add();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //this.lstMusic.Items.RemoveAt(this.lstMusic.SelectedIndex);
        }
    }

    public class TFile
    {
        public TFile(string name, string fullName)
        {
            Name = name;
            FullName = fullName;
        }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}
