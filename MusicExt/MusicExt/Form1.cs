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
using System.Threading;

namespace MusicExt
{
    public partial class Form1 : Form
    {
        public List<TFile> fileList = new List<TFile>();
        public List<MusicInfo> musicList = new List<MusicInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BindFileList()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = fileList;
            this.lstMusic.DataSource = bs;
            this.lstMusic.DisplayMember = "Name";
            this.lstMusic.ValueMember = "FullName";
            foreach (var item in fileList)
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(item.FullName));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ImportFolder();
        }

        public void ImportFolder()
        {
            string folder = this.txtAddress.Text.Trim();
            ScanFile(folder);
            BindFileList();
        }

        private void ScanFile(string folder)
        {
            DirectoryInfo directory = new DirectoryInfo(folder);
            foreach (FileInfo file in directory.GetFiles())
            {
                string fullName = folder + "\\" + file.Name;
                var existsItem = fileList.Where(x => x.FullName == fullName).ToList();
                if (existsItem != null && existsItem.Count > 0) continue;
                fileList.Add(new TFile(file.Name, fullName));
            }
            if (this.cbxChild.Checked)
            {
                foreach (DirectoryInfo folderItem in directory.GetDirectories())
                    ScanFile(folder + "\\" + folderItem.Name);
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
            MusicInfo music = new MusicInfo();
            string filePath = this.lstMusic.SelectedValue.ToString();
            var existsFile = musicList.Where(x => x.FilePath == filePath).ToList();
            if (existsFile != null && existsFile.Count > 0)
                music = existsFile[0];
            else
            {
                ShellClass sh = new ShellClass();
                Folder dir = sh.NameSpace(Path.GetDirectoryName(filePath));
                FolderItem item = dir.ParseName(Path.GetFileName(filePath));
                music.FileName = dir.GetDetailsOf(item, 0);
                music.Singer = dir.GetDetailsOf(item, 13);
                music.Anthor = dir.GetDetailsOf(item, 20);
                music.Title = dir.GetDetailsOf(item, 21);
                music.KBps = dir.GetDetailsOf(item, 28).Trim();
                music.Collection = dir.GetDetailsOf(item, 14);
                music.Time = dir.GetDetailsOf(item, 27);
                music.FileSize = dir.GetDetailsOf(item, 1);
                music.Category = dir.GetDetailsOf(item, 16);
                musicList.Add(music);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  文件名：" + music.FileName);
            sb.AppendLine("  演唱者：" + music.Singer);
            sb.AppendLine("  创作者：" + music.Anthor);
            sb.AppendLine("  歌曲名：" + music.Title);
            sb.AppendLine("  专辑名：" + music.Collection);
            sb.AppendLine("  比特率：" + music.KBps);
            sb.AppendLine("时间长度：" + music.Time);
            sb.AppendLine("文件大小：" + music.FileSize);
            sb.AppendLine("    流派：" + music.Category);
            rtxDetail.Text = sb.ToString();
        }

        private void lstMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileNameEx = txtPrefix.Text.Trim();
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
                }
                MessageBox.Show("更新完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败" + ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  //new一个方法  
            ofd.Filter = "MP3 Files(.mp3)|*.mp3|WMA Files(*.wma)|*.WMA|ALL Files(*.*)|*.*";
            ofd.Multiselect = true;         //允许多选  
            ofd.RestoreDirectory = true;    //记住上一次的文件路径  
            ofd.ShowDialog();               //显示打开文件的窗口  
            foreach (var item in ofd.FileNames)
            {
                var existsItem = fileList.Where(x => x.FullName == item).ToList();
                if (existsItem != null && existsItem.Count > 0) continue;
                var temp = item.Split('\\');
                fileList.Add(new TFile(temp[temp.Length - 1], item));
            }
            BindFileList();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (this.lstMusic.SelectedIndex > -1)
            {
                this.fileList.RemoveAt(this.lstMusic.SelectedIndex);
                BindFileList();
            }
        }

        private void lstMusic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstMusic_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var item in files)
            {
                var existsItem = fileList.Where(x => x.FullName == item).ToList();
                if (existsItem != null && existsItem.Count > 0) continue;
                var temp = item.Split('\\');
                fileList.Add(new TFile(temp[temp.Length - 1], item));
            }
            BindFileList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.fileList = new List<TFile>();
            BindFileList();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in this.fileList)
                {
                    MediaTags mt = new MediaTags(item.FullName);
                    string[] temp = item.FullName.Split('\\');
                    if (this.rbtnMusicName.Checked || string.IsNullOrEmpty(mt.Author))
                        temp[temp.Count() - 1] = string.Format("{0}.mp3", mt.Title);
                    else if (this.btnBoth.Checked)
                        temp[temp.Count() - 1] = string.Format("{0} - {1}.mp3", mt.Author.Replace(";", "&"), mt.Title);
                    string newFilePath = string.Join("\\", temp);
                    if (newFilePath.Substring(0, newFilePath.Length - 4) != item.FullName.Substring(0, item.FullName.Length - 4))
                    {
                        if (File.Exists(newFilePath)) continue;
                        File.Move(item.FullName, newFilePath);
                        item.Name = temp[temp.Count() - 1];
                        item.FullName = newFilePath;

                    }
                }
                MessageBox.Show("重命名操作完成！");
                BindFileList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("重命名操作失败：" + ex.Message);
            }
        }

        private void btnEditPrefix_Click(object sender, EventArgs e)
        {
            try
            {
                string prefix = this.txtPrefix.Text.Trim();
                if (string.IsNullOrEmpty(prefix)) return;
                foreach (var item in this.fileList)
                {
                    MediaTags mt = new MediaTags(item.FullName);
                    string[] temp = item.FullName.Split('\\');
                    if (this.rbtnAddPrefix.Checked)
                        temp[temp.Count() - 1] = string.Format("{1}{0}.mp3", temp[temp.Count() - 1], prefix);
                    else if (this.rbtnRemovePrefix.Checked)
                        temp[temp.Count() - 1] = temp[temp.Count() - 1].Replace(prefix, "");
                    string newFilePath = string.Join("\\", temp);
                    if (newFilePath.Substring(0, newFilePath.Length - 4) != item.FullName.Substring(0, item.FullName.Length - 4))
                    {
                        if (File.Exists(newFilePath))
                            continue;
                        File.Move(item.FullName, newFilePath);
                        item.Name = temp[temp.Count() - 1];
                        item.FullName = newFilePath;

                    }
                }
                MessageBox.Show("重命名操作完成！");
                BindFileList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("重命名操作失败：" + ex.Message);
            }
        }

        private void lstMusic_DoubleClick(object sender, EventArgs e)
        {

            //   axWindowsMediaPlayer1.URL = this.lstMusic.SelectedValue.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.currentItem = axWindowsMediaPlayer1.currentPlaylist.get_Item(this.lstMusic.SelectedIndex);
            axWindowsMediaPlayer1.currentMedia.setItemInfo("Title", this.lstMusic.SelectedValue.ToString());
            axWindowsMediaPlayer1.Ctlcontrols.play();

            return;
            MusicInfo music = new MusicInfo();
            string filePath = this.lstMusic.SelectedValue.ToString();
            var existsFile = musicList.Where(x => x.FilePath == filePath).ToList();
            if (existsFile != null && existsFile.Count > 0)
                music = existsFile[0];
            else
            {
                ShellClass sh = new ShellClass();
                Folder dir = sh.NameSpace(Path.GetDirectoryName(filePath));
                FolderItem item = dir.ParseName(Path.GetFileName(filePath));
                music.FileName = dir.GetDetailsOf(item, 0);
                music.Singer = dir.GetDetailsOf(item, 13);
                music.Anthor = dir.GetDetailsOf(item, 20);
                music.Title = dir.GetDetailsOf(item, 21);
                music.KBps = dir.GetDetailsOf(item, 28).Trim();
                music.Collection = dir.GetDetailsOf(item, 14);
                music.Time = dir.GetDetailsOf(item, 27);
                music.FileSize = dir.GetDetailsOf(item, 1);
                music.Category = dir.GetDetailsOf(item, 16);
                musicList.Add(music);
            }
            fmDetail fd = new fmDetail(music);
            fd.Show();
        }



    }

    public class MusicInfo
    {
        public string Title { get; set; }
        public string Anthor { get; set; }
        public string Singer { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string KBps { get; set; }
        public string FileSize { get; set; }
        public string Time { get; set; }
        public string Category { get; set; }
        public string Collection { get; set; }
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
