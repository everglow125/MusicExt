using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicExt
{
    public partial class fmDetail : Form
    {
        MusicInfo music;

        public fmDetail(MusicInfo _music)
        {
            InitializeComponent();
            music = _music;
            this.FileName.Text = music.FileName;
            this.Singer.Text = music.Singer;
            this.Collection.Text = music.Collection;
            this.Title.Text = music.Title;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MediaTags mt = new MediaTags(music.FilePath);
            music.FileName = this.FileName.Text;
            music.Singer = this.Singer.Text;
            music.Collection = this.Collection.Text;
            music.Title = this.Title.Text;

            mt.AlbumArtist = music.Singer;
            mt.AlbumTitle = music.Collection;
            mt.Author = music.Anthor;
            mt.Comment = "";
            mt.SubTitle = "";
            mt.Title = music.Title;
            mt.SaveChanged(music.FilePath);
        }

    }
}
