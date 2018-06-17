using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHGetFileInfoExample {
    public partial class DownloadFileDialog : Component {
        public DownloadFileDialog() {
            InitializeComponent();
            Title = "File Download";
        }

        public DownloadFileDialog(IContainer container) {
            container.Add(this);
            InitializeComponent();
            Title = "File Download";
        }
        [DefaultValue("File Download")]
        public string Title { get; set; }
        [DefaultValue(null)]
        public string FileName { get; set; }
        public DownloadFileResult ShowDialog() {
            if (string.IsNullOrEmpty(FileName))
                throw new Exception($"'{nameof(FileName)}' cannot be null or empty.");
            if (!File.Exists(FileName))
                throw new Exception($"'{FileName}' doesn't exists.");

            var result = DownloadFileResult.None;

            using (var f = new DownloadForm()) {
                var info = new SHFILEINFO();
                NativeMethods.SHGetFileInfo(FileName,
                    FileAttributes.Normal,
                    ref info,
                    (uint)Marshal.SizeOf(info),
                    SHGetFileInfoFlags.SHGFI_ICON |
                    SHGetFileInfoFlags.SHGFI_DISPLAYNAME |
                    SHGetFileInfoFlags.SHGFI_TYPENAME |
                    SHGetFileInfoFlags.SHGFI_USEFILEATTRIBUTES);

                f.Text = Title;
                f.StartPosition = FormStartPosition.CenterParent;
                f.NameLabel.Text = info.szDisplayName;
                f.TypeLabel.Text = info.szTypeName;
                f.IconPictureBox.Image = Icon.FromHandle(info.hIcon).ToBitmap();

                //Setup event handlers
                f.CancelCommandButton.Click += (s, e) => {
                    f.DialogResult = DialogResult.Cancel;
                };
                f.OpenCommandButton.Click += (s, e) => {
                    result = DownloadFileResult.Open;
                    f.DialogResult = DialogResult.OK;
                };
                f.SaveCommandButton.Click += (s, e) => {
                    result = DownloadFileResult.Save;
                    f.DialogResult = DialogResult.OK;
                };
                if (f.ShowDialog() == DialogResult.Cancel) {
                    result = DownloadFileResult.Cancel;
                }
            }

            return result;
        }
    }
}
