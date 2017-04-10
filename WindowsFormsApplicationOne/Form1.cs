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

namespace WindowsFormsApplicationOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var dataObject = e.Data;
            var formats = dataObject.GetFormats();
            
            foreach (var format in formats)
            {
                var data = e.Data.GetData(format);
                var row = new DataGridViewRow();
                row.CreateCells(gridView);
                row.Cells[0].Value = format;
                row.Cells[1].Value = e.AllowedEffect.ToString();
                row.Cells[2].Value = data == null ? "" : data.GetType().ToString();
                row.Cells[3].Value = data;

                if (data != null && data.ToString() == "System.String[]")
                {
                    var value = String.Join(",", (string[])data);
                    row.Cells[3].Value = value;
                }
                if (data != null && data.ToString() == "System.IO.MemoryStream")
                {
                    row.Cells[3].Value = ReadStream((MemoryStream)data);
                }

                gridView.Rows.Add(row);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private string ReadStream(MemoryStream stream)
        {
            var bufferCount = 1024;
            var buffer = new char[bufferCount];
            var str = "";
            using (var reader = new StreamReader(stream))
            {
                reader.ReadBlock(buffer, 0, bufferCount);
                str = String.Join("", buffer);
            }
            return str;
        }

        private void btnDrag_MouseDown(object sender, MouseEventArgs e)
        {
            var file = @"C:\Users\guill\onedrive\SoftwareInc.md";
            var fileW = Encoding.UTF8.GetString(Encoding.Convert(Encoding.UTF8, Encoding.Unicode, Encoding.UTF8.GetBytes(file + "\0")));
            var filenames = new String[] { file };
            var filenamesW = new String[] { fileW };

            // Testing drop on Chrome's browser view.
            var url = "file:///C:/Users/guill/OneDrive/SoftwareInc.md"; // Doesn't work, goes to blank.
            //url = "http://www.google.ca"; // Works.
            //url = "file://"; // Doesn't work, goes to blank.
            //url = "file"; // Ignored, uses FileDrop instead.

            var urlWideBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, Encoding.UTF8.GetBytes(url + "\0"));
            var data = new DataObject();

            data.SetData("FileDrop", filenames);
            data.SetData("UniformResourceLocatorW", true, new MemoryStream(urlWideBytes));
            data.SetData("UniformResourceLocator", true, new MemoryStream(Encoding.UTF8.GetBytes(url + "\0")));
            ((Button)sender).DoDragDrop(data, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnHdrop_MouseDown(object sender, MouseEventArgs e)
        {
            var file = @"C:\Users\guill\onedrive\SoftwareInc.md";
            var filenames = new String[] { file };
            var data = new DataObject();

            data.SetData("FileDrop", filenames);
            ((Button)sender).DoDragDrop(data, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnIneturl_MouseDown(object sender, MouseEventArgs e)
        {
            var url = "file:///C:/Users/guill/OneDrive/SoftwareInc.md"; // Doesn't work, goes to blank.
            var urlWideBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, Encoding.UTF8.GetBytes(url + "\0"));
            var data = new DataObject();

            data.SetData("UniformResourceLocatorW", true, new MemoryStream(urlWideBytes));
            data.SetData("UniformResourceLocator", true, new MemoryStream(Encoding.UTF8.GetBytes(url + "\0")));
            ((Button)sender).DoDragDrop(data, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void btnHdrop_Click(object sender, EventArgs e)
        {
            // Nothing.
        }

        private void btnIneturl_Click(object sender, EventArgs e)
        {
            // Nothing.
        }

        private void btnDrag_Click(object sender, EventArgs e)
        {
            // Nothing.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
        }
    }
}
