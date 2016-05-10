using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicExt
{
    public class MediaTags
    {
        #region Mp3文件属性
        //// 
        /// 标题
        /// 
        [MediaProperty("Title")]
        public string Title { get; set; }

        /// 
        /// 子标题
        /// 
        [MediaProperty("Media.SubTitle")]
        public string SubTitle { get; set; }

        /// 
        /// 备注
        /// 
        [MediaProperty("Comment")]
        public string Comment { get; set; }

        /// 
        /// 艺术家
        /// 
        [MediaProperty("Author")]
        public string Author { get; set; }

        /// 
        /// 唱片集
        /// 
        [MediaProperty("Music.AlbumTitle")]
        public string AlbumTitle { get; set; }

        /// 
        /// 唱片集艺术家
        /// 
        [MediaProperty("Music.AlbumArtist")]
        public string AlbumArtist { get; set; }


        /// 
        /// 流派
        /// 
        [MediaProperty("Music.Genre")]
        public string Genre { get; set; }

        #endregion
        public MediaTags(string mediaPath)
        {
            Init(mediaPath);
        }

        void Init(string mediaPath)
        {
            using (var file = ShellObject.FromParsingName(mediaPath))
            {
                var temp = this.GetType().GetProperties();
                foreach (var properItem in temp)
                {
                    var attributes = properItem.GetCustomAttributes(typeof(MediaPropertyAttribute), false).FirstOrDefault();
                    IShellProperty property = file.Properties.GetProperty("System." + attributes);
                    if (property.ValueAsObject == null)
                        continue;
                    if (property.ValueType == typeof(string[]))    //艺术家，流派等多值属性
                    {
                        properItem.SetValue(this, string.Join(";", property.ValueAsObject as string[]), null);
                    }
                    else
                    {
                        try
                        {
                            properItem.SetValue(this, property.ValueAsObject, null);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        public void SaveChanged(string filePath)
        {
            var originalFile = new MediaTags(filePath);
            using (var item = ShellObject.FromParsingName(filePath))
            {
                foreach (var proper in this.GetType().GetProperties())
                {
                    var originalValue = proper.GetValue(originalFile, null);
                    var currentValue = proper.GetValue(this, null);
                    if (originalValue == null && currentValue == null)
                        continue;
                    if (currentValue != originalValue)
                    {
                        var attributes = proper.GetCustomAttributes(typeof(MediaPropertyAttribute), false).FirstOrDefault();
                        var shellProper = item.Properties.GetProperty("System." + attributes);
                        SetProperty(shellProper, currentValue);
                    }
                }
            }
        }


        public static void SetProperty(IShellProperty prop, object value)
        {
            try
            {
                if (prop.ValueType == typeof(string[]))        //只读属性不会改变，故与实际类型不符的只有string[]这一种
                {
                    string[] values = (value as string).Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    (prop as ShellProperty<string[]>).Value = values;
                }
                if (prop.ValueType == typeof(string))
                {
                    (prop as ShellProperty<string>).Value = value.ToString();
                }
                else if (prop.ValueType == typeof(ushort?))
                {
                    (prop as ShellProperty<ushort?>).Value = (ushort?)value;
                }
                else if (prop.ValueType == typeof(short?))
                {
                    (prop as ShellProperty<short?>).Value = (short?)value;
                }
                else if (prop.ValueType == typeof(uint?))
                {
                    (prop as ShellProperty<uint?>).Value = (uint?)value;
                }
                else if (prop.ValueType == typeof(int?))
                {
                    (prop as ShellProperty<int?>).Value = (int?)value;
                }
                else if (prop.ValueType == typeof(ulong?))
                {
                    (prop as ShellProperty<ulong?>).Value = (ulong?)value;
                }
                else if (prop.ValueType == typeof(long?))
                {
                    (prop as ShellProperty<long?>).Value = (long?)value;
                }
                else if (prop.ValueType == typeof(DateTime?))
                {
                    (prop as ShellProperty<DateTime?>).Value = (DateTime?)value;
                }
                else if (prop.ValueType == typeof(double?))
                {
                    (prop as ShellProperty<double?>).Value = (double?)value;
                }
            }
            catch (Exception ex)
            {
            }
        }


        #region MediaPropertyAttribute
        [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
        sealed class MediaPropertyAttribute : Attribute
        {
            public string PropertyKey { get; private set; }
            public MediaPropertyAttribute(string propertyKey)
            {
                this.PropertyKey = propertyKey;
            }

            public override string ToString()
            {
                return PropertyKey;
            }
        }
        #endregion
    }

}
