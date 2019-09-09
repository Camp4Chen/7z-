using SevenZip;
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

namespace ZipDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZip_Click(object sender, EventArgs e)
        {
            string path = @"20170605-H3C S12500X-AF系列交换机 软件升级指南-6W101";
            var rootPath = @"D:\work_file\demo_file";
            var sourceDir = Path.Combine(rootPath, path);
            if (Environment.Is64BitProcess)
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x64\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            else
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x86\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            var compressor = new SevenZipCompressor();
            compressor.ArchiveFormat = OutArchiveFormat.SevenZip;
            compressor.CompressionMode = CompressionMode.Create;
            compressor.CompressDirectory(sourceDir, sourceDir + ".7z");
        }

        private void Btn_Unzip_Click(object sender, EventArgs e)
        {
            string zipPath = @"D:\work_file\demo_file\20170605-H3C S12500X-AF系列交换机 软件升级指南-6W101.7z";
            DirectoryInfo directoryInfo = new DirectoryInfo(zipPath);
            FileInfo file = new FileInfo(zipPath);
            string destPath = @"D:\work_file\demo_file\Temp";
            if (Environment.Is64BitProcess)
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x64\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            else
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x86\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            if (file.Exists)
            {
                using (SevenZipExtractor tmp = new SevenZipExtractor(zipPath))
                {
                    tmp.ExtractArchive(Path.Combine(destPath, file.Name.Replace(directoryInfo.Extension, "")));
                }
            }
        }

        private void Btn_html_Click(object sender, EventArgs e)
        {
            string path = @"D:\work_file\demo_file\Temp\20170605-H3C S12500X-AF系列交换机 软件升级指南-6W101";
            string destPath = @"D:\work_file\demo_file\Document";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var htmls = directoryInfo.GetFiles("html.*");
            if (htmls.Length == 1)
            {
                UnZipHtml(htmls[0].FullName, directoryInfo.Name, destPath);
                ZipHtml(destPath, directoryInfo.Name);
            }
        }

        private void ZipHtml(string destPath, string name)
        {
            var sourceDir = Path.Combine(destPath, name,"html");
            var fileName = Path.Combine(destPath,name);
            if (Environment.Is64BitProcess)
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x64\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            else
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x86\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            var compressor = new SevenZipCompressor();
            compressor.ArchiveFormat = OutArchiveFormat.SevenZip;
            compressor.CompressionMode = CompressionMode.Create;
            compressor.CompressDirectory(sourceDir, fileName + ".7z");
        }

        private void UnZipHtml(string fullPath, string name, string destPath)
        {
            DirectoryInfo directory = new DirectoryInfo(fullPath);
            FileInfo file = new FileInfo(fullPath);
            if (Environment.Is64BitProcess)
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x64\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            else
            {
                SevenZipBase.SetLibraryPath(string.Format(@"{0}\x86\7z.dll", AppDomain.CurrentDomain.BaseDirectory));
            }
            if (file.Exists)
            {
                using (SevenZipExtractor tmp = new SevenZipExtractor(fullPath))
                {
                    tmp.ExtractArchive(Path.Combine(destPath, name));
                }
            }
        }
    }
}
