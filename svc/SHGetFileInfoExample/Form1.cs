using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHGetFileInfoExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var filename = Path.Combine(Path.GetTempPath(), "image1.png");
            using (var bmp = new Bitmap(this.Width, this.Height)) {
                DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
                bmp.Save(filename, ImageFormat.Png);
            }
            ShowDownloadFileDialog(filename);
        }

        private void button2_Click(object sender, EventArgs e) {
            var filename = Path.Combine(Path.GetTempPath(), "file1.txt");
            File.WriteAllText(filename, DateTime.Now.ToLongDateString());
            ShowDownloadFileDialog(filename);
        }


        private void button3_Click(object sender, EventArgs e) {
            var filename = Path.Combine(Path.GetTempPath(), "book1.csv");
            File.WriteAllText(filename, "Column1,Column2");
            ShowDownloadFileDialog(filename);
        }

        private void ShowDownloadFileDialog(string filename) {
            downloadFileDialog1.FileName = filename;
            var result = downloadFileDialog1.ShowDialog();
            if (result == DownloadFileResult.Open)
                Process.Start(filename);
            else if (result == DownloadFileResult.Save) {
                using (var sfd = new SaveFileDialog()) {
                    sfd.FileName = Path.GetFileName(filename);
                    var ext = Path.GetExtension(filename);
                    sfd.Filter = $"{ext}|{ext}";
                    sfd.OverwritePrompt = true;
                    sfd.RestoreDirectory = true;
                    if (sfd.ShowDialog() == DialogResult.OK) {
                        File.Copy(filename, sfd.FileName);
                    }
                }
            }
        }

    }
}

